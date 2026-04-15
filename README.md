# Simple Tic-Tac-Toe 🎮

> My first desktop application — a classic Tic-Tac-Toe game where you (X) play against a CPU opponent (O).

## Languages & Technologies

This project was built using:

- **C#** — primary programming language
- **.NET 8.0** — framework
- **Windows Forms (WinForms)** — desktop UI framework

## How to Run This Application

### Option 1: Run via .NET CLI (Recommended)

1. Install the [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. Open a terminal and navigate to the project folder:
   ```bash
   cd Simple-Tic-Toe
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

### Option 2: Run the Compiled Executable

If the project has already been built, you can run it directly:

```
Simple-Tic-Toe > bin > Debug > net8.0-windows > Simple-Tic-Toe.exe
```

### Option 3: Open in Visual Studio

1. Open the solution file: `Simple Tic-Tac-Toe.sln`
2. Press **F5** or click **Start** to build and run

## How to Play

- You are **Player X** — click any button on the 3×3 grid to place your mark
- The **CPU (O)** responds automatically after 1 second with a random move
- The first to align 3 marks in a row, column, or diagonal wins
- Your score and the CPU's score are tracked at the top of the window
- Click the **Restarts** button to reset the board at any time
