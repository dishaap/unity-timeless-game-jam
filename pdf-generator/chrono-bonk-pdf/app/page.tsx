'use client'

import { useState } from 'react'
import DocumentViewer from '@/components/DocumentViewer'
import DocumentSelector from '@/components/DocumentSelector'

export default function Home() {
  const [selectedDoc, setSelectedDoc] = useState<string | null>(null)

  return (
    <main className="min-h-screen bg-gray-50">
      <div className="container mx-auto px-4 py-8">
        <header className="mb-8 text-center">
          <h1 className="text-4xl font-bold text-gray-900 mb-2">
            Chrono-Bonk PDF Generator
          </h1>
          <p className="text-gray-600">
            Generate properly formatted, Google Docs-ready PDFs from game documentation
          </p>
        </header>

        <DocumentSelector onSelect={setSelectedDoc} selectedDoc={selectedDoc} />

        {selectedDoc && (
          <DocumentViewer documentType={selectedDoc} />
        )}
      </div>
    </main>
  )
}
