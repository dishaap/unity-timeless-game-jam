'use client'

interface DocumentSelectorProps {
  onSelect: (doc: string) => void
  selectedDoc: string | null
}

export default function DocumentSelector({ onSelect, selectedDoc }: DocumentSelectorProps) {
  const documents = [
    { id: 'gdd', name: 'Game Design Document (GDD)', file: 'GDD_CHRONO_BONK.md' },
    { id: 'plan', name: 'Technical Plan', file: 'CHRONO_BONK_PLAN_UPDATED.md' },
  ]

  return (
    <div className="bg-white rounded-lg shadow-md p-6 mb-8">
      <h2 className="text-2xl font-semibold mb-4 text-gray-800">
        Select Document
      </h2>
      <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
        {documents.map((doc) => (
          <button
            key={doc.id}
            onClick={() => onSelect(doc.id)}
            className={`p-4 rounded-lg border-2 transition-all ${
              selectedDoc === doc.id
                ? 'border-blue-500 bg-blue-50'
                : 'border-gray-200 hover:border-gray-300 hover:bg-gray-50'
            }`}
          >
            <h3 className="font-semibold text-lg mb-1">{doc.name}</h3>
            <p className="text-sm text-gray-600">{doc.file}</p>
          </button>
        ))}
      </div>
    </div>
  )
}
