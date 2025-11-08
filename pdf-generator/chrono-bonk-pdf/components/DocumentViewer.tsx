'use client'

import { useEffect, useState, useRef } from 'react'
import ReactMarkdown from 'react-markdown'
import remarkGfm from 'remark-gfm'
import { generatePDF } from '@/utils/pdfGenerator'
import '@/app/pdf-styles.css'
import '@/app/print.css'

interface DocumentViewerProps {
  documentType: string
}

export default function DocumentViewer({ documentType }: DocumentViewerProps) {
  const [content, setContent] = useState<string>('')
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)
  const contentRef = useRef<HTMLDivElement>(null)

  useEffect(() => {
    const loadDocument = async () => {
      setLoading(true)
      setError(null)

      try {
        const fileName = documentType === 'gdd'
          ? 'GDD_CHRONO_BONK.md'
          : 'CHRONO_BONK_PLAN_UPDATED.md'

        const response = await fetch(`/api/document?file=${fileName}`)
        if (!response.ok) {
          throw new Error('Failed to load document')
        }

        const text = await response.text()
        setContent(text)
      } catch (err) {
        setError(err instanceof Error ? err.message : 'Failed to load document')
      } finally {
        setLoading(false)
      }
    }

    if (documentType) {
      loadDocument()
    }
  }, [documentType])

  const handleDownloadPDF = async () => {
    if (contentRef.current) {
      await generatePDF(contentRef.current, documentType)
    }
  }

  const handlePrint = () => {
    window.print()
  }

  if (loading) {
    return (
      <div className="bg-white rounded-lg shadow-md p-8 text-center">
        <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-blue-500 mx-auto"></div>
        <p className="mt-4 text-gray-600">Loading document...</p>
      </div>
    )
  }

  if (error) {
    return (
      <div className="bg-red-50 border border-red-200 rounded-lg p-6">
        <p className="text-red-800">Error: {error}</p>
        <p className="text-sm text-red-600 mt-2">
          Make sure the markdown file exists in the project root.
        </p>
      </div>
    )
  }

  return (
    <div className="bg-white rounded-lg shadow-md">
      {/* Action Bar */}
      <div className="no-print border-b border-gray-200 p-4 flex gap-4">
        <button
          onClick={handleDownloadPDF}
          className="px-6 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700 transition-colors font-medium"
        >
          Download PDF
        </button>
        <button
          onClick={handlePrint}
          className="px-6 py-2 bg-gray-600 text-white rounded-lg hover:bg-gray-700 transition-colors font-medium"
        >
          Print to PDF
        </button>
      </div>

      {/* Document Content */}
      <div
        ref={contentRef}
        className="pdf-content p-8 md:p-12 max-w-4xl mx-auto"
      >
        <ReactMarkdown
          remarkPlugins={[remarkGfm]}
          components={{
            h1: ({ node, ...props }) => (
              <h1 className="text-4xl font-bold mt-8 mb-4 text-gray-900 border-b-2 border-gray-300 pb-2" {...props} />
            ),
            h2: ({ node, ...props }) => (
              <h2 className="text-3xl font-bold mt-6 mb-3 text-gray-800" {...props} />
            ),
            h3: ({ node, ...props }) => (
              <h3 className="text-2xl font-semibold mt-5 mb-2 text-gray-700" {...props} />
            ),
            h4: ({ node, ...props }) => (
              <h4 className="text-xl font-semibold mt-4 mb-2 text-gray-700" {...props} />
            ),
            h5: ({ node, ...props }) => (
              <h5 className="text-lg font-semibold mt-3 mb-2 text-gray-700" {...props} />
            ),
            h6: ({ node, ...props }) => (
              <h6 className="text-base font-semibold mt-3 mb-2 text-gray-700" {...props} />
            ),
            p: ({ node, ...props }) => (
              <p className="mb-4 text-gray-700 leading-relaxed" {...props} />
            ),
            ul: ({ node, ...props }) => (
              <ul className="mb-4 ml-6 list-disc space-y-2" {...props} />
            ),
            ol: ({ node, ...props }) => (
              <ol className="mb-4 ml-6 list-decimal space-y-2" {...props} />
            ),
            li: ({ node, ...props }) => (
              <li className="text-gray-700 leading-relaxed" {...props} />
            ),
            strong: ({ node, ...props }) => (
              <strong className="font-semibold text-gray-900" {...props} />
            ),
            em: ({ node, ...props }) => (
              <em className="italic text-gray-700" {...props} />
            ),
            code: ({ node, inline, ...props }) =>
              inline ? (
                <code className="bg-gray-100 px-1.5 py-0.5 rounded text-sm font-mono text-gray-800" {...props} />
              ) : (
                <code className="block bg-gray-100 p-4 rounded-lg text-sm font-mono text-gray-800 overflow-x-auto mb-4" {...props} />
              ),
            blockquote: ({ node, ...props }) => (
              <blockquote className="border-l-4 border-blue-500 pl-4 italic text-gray-600 my-4" {...props} />
            ),
            table: ({ node, ...props }) => (
              <div className="overflow-x-auto my-4">
                <table className="min-w-full border-collapse border border-gray-300" {...props} />
              </div>
            ),
            thead: ({ node, ...props }) => (
              <thead className="bg-gray-100" {...props} />
            ),
            th: ({ node, ...props }) => (
              <th className="border border-gray-300 px-4 py-2 text-left font-semibold text-gray-900" {...props} />
            ),
            td: ({ node, ...props }) => (
              <td className="border border-gray-300 px-4 py-2 text-gray-700" {...props} />
            ),
            hr: ({ node, ...props }) => (
              <hr className="my-8 border-gray-300" {...props} />
            ),
          }}
        >
          {content}
        </ReactMarkdown>
      </div>
    </div>
  )
}
