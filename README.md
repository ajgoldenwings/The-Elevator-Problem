# The Elevator Problem

A Blazor WebAssembly application simulating elevator operations and passenger management.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later

## Technology Stack

- **Framework**: Blazor WebAssembly with .NET 10
- **UI**: Bootstrap 5.3.2 (via CDN)
- **Deployment**: GitHub Pages with GitHub Actions (auto-deploys on push to master/main)
- **Hosting**: Client-side (runs entirely in the browser)

## Getting Started

### Running the Application Locally

1. Clone or download this repository
2. Navigate to the project directory:
   ```bash
   cd TheElevatorProblem
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
5. Open your browser and navigate to:
   - HTTPS: `https://localhost:5001`
   - HTTP: `http://localhost:5000`

### Building for Production

```bash
dotnet build -c Release
dotnet publish -c Release -o ./publish
```

## Overview

- Main logic within `TheElevatorProblem/Pages/ElevatorProblem/ElevatorProblem.razor`
- When entering the page with the list of elevators, it defaults to 10 floors and 3 elevators
- Floors are divided into two sections:
  - **Left side**: Elevators with passengers
  - **Right side**: Waiting passengers
- Elevators start at the bottom level
- Many options and statistics are shown
- Time is measured in 'units'
- Power is measured in 'floor changes'
- New passengers are placed on a random floor and request a random floor
- Pretty pictures are available within this directory

![Elevator Simulation Picture 1](/picture1.png)
![Elevator Simulation Picture 2](/picture2.png)

## Technical Challenges

- May take time to respond to a requesting passenger. Currently it looks to see if there is at least one passenger that exists and sends one elevator per direction. Does not send multiple. Does not take into account cost over time for power.
- Not efficient when running large datasets
- As more components are rendered on screen, the slower it gets. Best suited for shorter demonstrations or fewer passengers

## Architecture

- **Framework**: Blazor WebAssembly with .NET 10
- **UI**: Bootstrap 5.3.2 (via CDN)
- **Deployment**: Automated via GitHub Actions
- **Main Logic**: `TheElevatorProblem/Pages/ElevatorProblem/ElevatorProblem.razor`

## Known Limitations

- One requirement is to have the state of each button on the floor. A workaround: check for passengers not currently in an elevator where their current floor differs from their requested floor. You can deduce the button they pressed by the floor they are requesting relative to their current floor.
- Another missing requirement is time elapsed since each floor button was pushed. This could be easily implemented by tracking max wait time of requesting passengers per floor per direction.

