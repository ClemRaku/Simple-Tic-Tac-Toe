# Project Context: Simple Tic-Tac-Toe

## Project Overview

This is a **simple Tic-Tac-Toe game** built as a **Windows Forms (WinForms)** desktop application using **C#** and **.NET 8.0**. It is the creator's first program. The game pits a human player (X) against a CPU opponent (O) that makes random moves.

### Key Features
- **3x3 grid board** represented by 9 buttons
- **Player vs CPU** gameplay
- **Random CPU moves** with a 1-second delay timer
- **Score tracking** for both player and CPU wins displayed in text boxes
- **Restart functionality** via a button to reset the board
- **Visual feedback**: Player moves shown in cyan, CPU moves shown in red

### Architecture
- **Entry Point**: `Program.cs` — initializes the application and launches `Form1`
- **Main Form**: `Form1.cs` — contains all game logic (click handlers, win checking, CPU AI, score tracking)
- **Designer File**: `Form1.Designer.cs` — auto-generated UI layout (9 game buttons, 2 score textboxes, restart button, CPU timer)
- **Project File**: `Simple-Tic-Tac-Toe.csproj` — .NET 8.0 Windows desktop project with nullable references and implicit usings enabled

## Technologies & Dependencies

| Technology | Version/Detail |
|---|---|
| **Framework** | .NET 8.0 (`net8.0-windows`) |
| **UI Framework** | Windows Forms (`UseWindowsForms=true`) |
| **Language** | C# with nullable references and implicit usings |
| **IDE** | Likely Visual Studio (`.csproj.user` file present) |

## Building and Running

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Windows OS (WinForms is Windows-specific)

### Commands

```bash
# Navigate to the project directory
cd Simple-Tic-Toe

# Build the project
dotnet build

# Run the application
dotnet run

# Publish a self-contained executable
dotnet publish -c Release
```

### Alternative (from README)
The compiled executable can also be found at:
```
bin > Debug > net8.0-windows > Simple-Tic-Toe.exe
```

## Game Logic Summary

1. **Player (X)** clicks a button to place their mark (cyan background)
2. **CPU_Timer** starts and after 1 second, CPU (O) places a random mark (red background)
3. After each move, `Check_Game()` evaluates all 8 winning combinations
4. If a player wins, a message box displays the result and scores update
5. The board automatically restarts after a win
6. Player can manually restart by clicking the "Restarts" button

## Development Notes

- **Namespace**: The code uses `Super_Tic_Toe` as the namespace (not `Simple_Tic_Tac_Toe`)
- **No tests**: The project does not include any test files
- **Single-file game logic**: All game logic resides in `Form1.cs` (~100 lines)
- **CPU AI**: Purely random — selects from remaining available buttons
- **Known issues**:
  - No draw/tie detection (game only checks for wins)
  - Score label bug: `textBox2` displays "Player WIns" instead of "CPU Wins" when CPU wins
  - No validation preventing player clicks on already-disabled buttons (relies on `Enabled` property)

## File Structure

```
Simple-Tic-Tac-Toe/
├── README.md                          # Project description and run instructions
├── Simple-Tic-Toe/
│   ├── Form1.cs                       # Game logic
│   ├── Form1.Designer.cs              # Auto-generated UI layout
│   ├── Form1.resx                     # Resource file
│   ├── Program.cs                     # Application entry point
│   ├── Simple Tic-Tac-Toe.sln         # Visual Studio solution file
│   ├── Simple-Tic-Tac-Toe.csproj      # Project configuration
│   ├── Simple-Tic-Tac-Toe.csproj.user # User-specific project settings
│   ├── bin/                           # Compiled output
│   └── obj/                           # Build artifacts
└── QWEN.md                            # This file
```
