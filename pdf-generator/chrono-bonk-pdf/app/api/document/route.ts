import { NextRequest, NextResponse } from 'next/server'
import { readFile } from 'fs/promises'
import { join } from 'path'

export async function GET(request: NextRequest) {
  try {
    const searchParams = request.nextUrl.searchParams
    const fileName = searchParams.get('file')

    if (!fileName) {
      return NextResponse.json(
        { error: 'File parameter is required' },
        { status: 400 }
      )
    }

    // Security: Only allow specific files
    const allowedFiles = ['GDD_CHRONO_BONK.md', 'CHRONO_BONK_PLAN_UPDATED.md']
    if (!allowedFiles.includes(fileName)) {
      return NextResponse.json(
        { error: 'File not allowed' },
        { status: 403 }
      )
    }

    // Read file from docs directory (two levels up from this app)
    const filePath = join(process.cwd(), '..', '..', '..', 'docs', fileName)
    const content = await readFile(filePath, 'utf-8')

    return new NextResponse(content, {
      headers: {
        'Content-Type': 'text/plain; charset=utf-8',
      },
    })
  } catch (error) {
    console.error('Error reading file:', error)
    return NextResponse.json(
      { error: 'Failed to read file' },
      { status: 500 }
    )
  }
}
