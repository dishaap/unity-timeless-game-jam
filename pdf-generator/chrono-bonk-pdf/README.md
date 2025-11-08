# Chrono-Bonk PDF Generator

A Next.js application for generating properly formatted, Google Docs-ready PDFs from game documentation (GDD and Technical Plan).

## Features

- ✅ Properly structured HTML output
- ✅ Google Docs compatible formatting
- ✅ Print-to-PDF functionality
- ✅ Download PDF directly
- ✅ Semantic HTML for accessibility
- ✅ Print-optimized CSS
- ✅ Markdown to HTML conversion with proper styling

## Setup

1. Install dependencies:
```bash
npm install
```

2. Make sure the markdown files are in the parent directory:
- `GDD_CHRONO_BONK.md`
- `CHRONO_BONK_PLAN_UPDATED.md`

3. Run the development server:
```bash
npm run dev
```

4. Open [http://localhost:3000](http://localhost:3000)

## Usage

1. Select a document (GDD or Technical Plan)
2. View the formatted document
3. Click "Download PDF" to generate and download a PDF
4. Or click "Print to PDF" to use browser's print functionality (better for Google Docs compatibility)

## PDF Generation

The app uses two methods for PDF generation:

1. **html2pdf.js**: Client-side PDF generation with custom styling
2. **Browser Print**: Uses browser's native print-to-PDF (recommended for Google Docs compatibility)

## Google Docs Compatibility

The generated HTML uses:
- Semantic HTML5 elements
- Standard fonts (Arial, Helvetica)
- Proper heading hierarchy
- Accessible table structures
- Print-optimized CSS

To import into Google Docs:
1. Use "Print to PDF" option
2. Upload the PDF to Google Drive
3. Open with Google Docs (it will convert automatically)
4. Or copy-paste the HTML content directly

## File Structure

```
chrono-bonk-pdf/
├── app/
│   ├── api/
│   │   └── document/
│   │       └── route.ts          # API route for loading markdown files
│   ├── globals.css               # Global styles
│   ├── layout.tsx                # Root layout
│   └── page.tsx                  # Main page
├── components/
│   ├── DocumentSelector.tsx      # Document selection UI
│   └── DocumentViewer.tsx        # Document display and PDF generation
├── utils/
│   └── pdfGenerator.ts          # PDF generation utilities
└── package.json
```

## Technical Details

- **Framework**: Next.js 14+ (App Router)
- **Markdown**: react-markdown with remark-gfm
- **PDF Generation**: html2pdf.js
- **Styling**: CSS with print media queries
- **TypeScript**: Full type safety

## Notes

- The app reads markdown files from the parent directory
- PDFs are generated client-side for privacy
- Print styles are optimized for A4/Letter paper size
- All styles are designed to be Google Docs compatible
