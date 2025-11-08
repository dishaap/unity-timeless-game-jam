import type { Metadata } from 'next'
import './globals.css'

export const metadata: Metadata = {
  title: 'Chrono-Bonk PDF Generator',
  description: 'Generate properly formatted PDFs from GDD and Technical Plan documents',
}

export default function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="en">
      <body>{children}</body>
    </html>
  )
}
