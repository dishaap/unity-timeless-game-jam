# Quick Setup Guide

## Installation

1. Navigate to the PDF generator directory:
```bash
cd chrono-bonk-pdf
```

2. Install dependencies:
```bash
npm install
```

3. Ensure markdown files are in the parent directory:
   - `../GDD_CHRONO_BONK.md`
   - `../CHRONO_BONK_PLAN_UPDATED.md`

4. Run the development server:
```bash
npm run dev
```

5. Open [http://localhost:3000](http://localhost:3000) in your browser

## Usage

1. **Select Document**: Click on either "Game Design Document" or "Technical Plan"
2. **View Document**: The formatted document will appear below
3. **Generate PDF**:
   - Click "Download PDF" for direct download (uses html2pdf.js)
   - Click "Print to PDF" for browser's native print (recommended for Google Docs)

## Google Docs Import

### Method 1: Print to PDF (Recommended)
1. Click "Print to PDF"
2. Save the PDF
3. Upload to Google Drive
4. Right-click → "Open with" → "Google Docs"
5. Google Docs will automatically convert and preserve formatting

### Method 2: Direct HTML Copy
1. Right-click on the document content
2. Select "Inspect" or "View Source"
3. Copy the HTML from the `.pdf-content` div
4. Paste into Google Docs (it will auto-format)

## Features

✅ **Semantic HTML**: Proper heading hierarchy, lists, tables
✅ **Print-Optimized**: Page breaks, margins, typography
✅ **Google Docs Compatible**: Standard fonts, accessible structure
✅ **Accessible**: Proper ARIA labels, semantic markup
✅ **Professional Styling**: Clean, readable format

## Troubleshooting

**File not found error:**
- Ensure markdown files are in the parent directory (one level up from `chrono-bonk-pdf`)
- Check file names match exactly: `GDD_CHRONO_BONK.md` and `CHRONO_BONK_PLAN_UPDATED.md`

**PDF generation fails:**
- Try using "Print to PDF" instead of "Download PDF"
- Ensure pop-ups are not blocked
- Check browser console for errors

**Styling issues:**
- Clear browser cache
- Hard refresh (Ctrl+Shift+R or Cmd+Shift+R)
- Try a different browser
