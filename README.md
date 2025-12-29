# HaulTextBase

A text-based space trading and exploration game built with C# and .NET 8.0.

## Overview

HaulTextBase is a console-based adventure game where players explore a sci-fi universe, starting at a remote spaceport on a distant planet. The game features a clean architecture with separated concerns between the game engine and user interface layers.

## Features

- **Text-based gameplay** with rich console UI powered by Spectre.Console
- **Space exploration** starting from a remote, poorly-maintained spaceport
- **Modular architecture** with clear separation between game logic and presentation
- **Dependency injection** for clean, testable code structure
- **Extensible design** with interfaces for interactable objects and tradeable items

## Project Structure

The solution consists of two main projects:

### HaulTextBase (Main Application)
The executable project that provides the user interface and manages the game loop.
- `Program.cs` - Application entry point with dependency injection setup
- `BasicUI.cs` - Console-based user interface handling input/output
- `SpectreTest.cs` - UI testing utilities

### Haul.Engine (Game Engine)
A class library containing the core game logic and models.
- **API/** - Controller and request/response models for game interaction
- **Game/** - Core game components (GameManager, GameState, Player, Description)
- **Interfaces/** - Contracts for game objects (IController, IGameManager, IInteractable, ITradeable)
- **Models/** - Base models (Place, Item, Vehicle)
- **Places/** - Specific location implementations (SpacePort)

## Technologies Used

- **.NET 8.0** - Target framework
- **C# 12** - Programming language
- **Spectre.Console** (v0.50.0) - Rich console UI library
- **Microsoft.Extensions.DependencyInjection** (v9.0.7) - Dependency injection framework

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

### Building the Project

```bash
# Clone the repository
git clone https://github.com/Zoranis/HaulTextBase.git
cd HaulTextBase

# Restore dependencies
dotnet restore

# Build the solution
dotnet build
```

### Running the Game

```bash
# Run from the solution directory
dotnet run --project HaulTextBase

# Or navigate to the project directory
cd HaulTextBase
dotnet run
```

## How to Play

1. The game starts with you at a remote spaceport
2. You'll receive descriptions of your current location
3. Enter your choice using number keys (0-9)
4. The game responds to your choices and updates the game state

## Architecture

The game follows a request-response pattern:

1. **UI Layer** (`BasicUI`) handles user input and displays responses
2. **Controller** (`IController`) manages the flow between UI and game logic
3. **Game Manager** (`IGameManager`) processes requests and maintains game state
4. **Models** represent game entities (Places, Items, Vehicles, Player)

```
User Input → BasicUI → Controller → GameManager → GameState
                ↑                          ↓
                └────── Response ──────────┘
```

## Development Status

This is an early-stage project with basic infrastructure in place:
- ✅ Core architecture and dependency injection
- ✅ Basic UI loop and user input handling
- ✅ Initial location (SpacePort) implementation
- ✅ Request/response system
- 🚧 Game mechanics and trading system (in development)
- 🚧 Multiple locations and navigation (planned)
- 🚧 Item and vehicle systems (planned)

## Contributing

This is a personal project by Zoranis. If you'd like to contribute, please feel free to open issues or submit pull requests.

## License

This project's license is not currently specified. Please contact the repository owner for licensing information.
