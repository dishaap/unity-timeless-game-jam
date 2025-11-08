export async function generatePDF(element: HTMLElement, documentType: string) {
  // Dynamically import html2pdf to avoid SSR issues
  const html2pdf = (await import('html2pdf.js')).default

  const opt = {
    margin: [0.5, 0.5, 0.5, 0.5],
    filename: `${documentType === 'gdd' ? 'GDD_Chrono-Bonk' : 'Technical_Plan_Chrono-Bonk'}.pdf`,
    image: { type: 'jpeg', quality: 0.98 },
    html2canvas: {
      scale: 2,
      useCORS: true,
      letterRendering: true,
      logging: false,
    },
    jsPDF: {
      unit: 'in',
      format: 'letter',
      orientation: 'portrait',
      compress: true,
    },
    pagebreak: {
      mode: ['avoid-all', 'css', 'legacy'],
      before: '.page-break-before',
      after: '.page-break-after',
      avoid: ['h1', 'h2', 'h3', 'table', '.no-break'],
    },
  }

  // Add print styles
  const style = document.createElement('style')
  style.textContent = `
    @media print {
      body {
        background: white !important;
        color: black !important;
      }
      .no-print {
        display: none !important;
      }
      h1, h2, h3 {
        page-break-after: avoid;
        page-break-inside: avoid;
      }
      p, li {
        orphans: 3;
        widows: 3;
      }
      table {
        page-break-inside: avoid;
      }
    }
  `
  document.head.appendChild(style)

  try {
    await html2pdf().set(opt).from(element).save()
  } finally {
    document.head.removeChild(style)
  }
}

// Alternative: Use browser's print functionality (better for Google Docs compatibility)
export function printToPDF() {
  window.print()
}
