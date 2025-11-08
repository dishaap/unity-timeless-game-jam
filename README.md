# Chrono-Bonk - Unity Game Jam Project

**Theme:** "Timeless"  
**Platform:** WebGL (Browser)  
**Team:** Nico (Lead Design), Disha (Lead Dev), Dima (Tech Art), Andy (Audio), jsynk (3D Generalist)

## Game Overview

**Chrono-Bonk** is a fast-paced, auto-attacking ARPG that merges the power fantasy of *Vampire Survivors* with the time-bending mechanic of *Superhot*. Players take on the role of an archaeologist who has stumbled into a cursed cavern where time itself becomes a weapon.

**Core Mechanic:** Time moves at 100% when player moves, 10% when player stops. All combat is auto-attack. 5-minute global timer leads to boss wave.

## Project Structure

```
unity-timeless-game-jam/
├── Assets/                    # Unity project assets
│   ├── Blink/                 # RPG Builder, Controllers
│   ├── Malbers Animations/    # Animal Controller (AI)
│   ├── InfinityPBR/          # Projectile Factory
│   └── ...
├── docs/                      # Project documentation
│   ├── GDD_CHRONO_BONK.md    # Game Design Document
│   └── CHRONO_BONK_PLAN_UPDATED.md  # Technical Implementation Plan
├── pdf-generator/             # PDF generation tool
│   └── chrono-bonk-pdf/       # Next.js app for generating PDFs
├── Packages/                  # Unity packages
├── ProjectSettings/           # Unity project settings
└── README.md                  # This file
```

## Documentation

### Game Design Document (GDD)
See `docs/GDD_CHRONO_BONK.md` for complete game design, mechanics, and vision.

### Technical Plan
See `docs/CHRONO_BONK_PLAN_UPDATED.md` for detailed technical implementation plan, API references, and development phases.

### PDF Generator
The `pdf-generator/chrono-bonk-pdf/` directory contains a Next.js application for generating properly formatted, Google Docs-ready PDFs from the documentation.

**To use the PDF generator:**
```bash
cd pdf-generator/chrono-bonk-pdf
npm install
npm run dev
```

Then open http://localhost:3000 to generate PDFs.

## Development Setup

### Prerequisites
- Unity 2022.3 LTS or later
- Node.js 18+ (for PDF generator)
- Git

### Assets Used
- **RPG Builder 2.0** - Database, stats, items, combat system
- **Malbers Animal Controller** - AI system for enemies
- **Projectile Factory** - Combat projectiles and effects
- **Stylized Lost Cave** - Environment assets
- **Toon Shader Asset** - Art style shader

## Team Workflow

### Git Workflow
- Create feature branches: `feature/time-manager`, `feature/enemy-ai`, etc.
- Commit frequently with clear messages
- Push to GitHub regularly
- Disha manages main branch merges

### Branch Naming
- `feature/` - New features
- `fix/` - Bug fixes
- `docs/` - Documentation updates

## Quick Links

- **GitHub Repository:** https://github.com/dishaap/unity-timeless-game-jam
- **Game Design Document:** [docs/GDD_CHRONO_BONK.md](docs/GDD_CHRONO_BONK.md)
- **Technical Plan:** [docs/CHRONO_BONK_PLAN_UPDATED.md](docs/CHRONO_BONK_PLAN_UPDATED.md)

## Development Status

🚧 **In Development** - Game jam project in active development

### Completed
- ✅ Project structure setup
- ✅ Documentation (GDD & Technical Plan)
- ✅ PDF generator tool
- ✅ Git repository setup

### In Progress
- 🔄 Core systems implementation
- 🔄 Asset integration

### Planned
- ⏳ Enemy AI integration
- ⏳ Combat system
- ⏳ Loot system
- ⏳ UI systems
- ⏳ WebGL build

## License

This is a game jam project. All rights reserved by the team.

---

**It Is, Thank You Father, We Receive All That We Are, Now Move Through Us... S.O.L.**

