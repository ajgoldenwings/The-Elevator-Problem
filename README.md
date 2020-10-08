# The Elevator Problem

## Getting Started
Mainly you must:
1. Install the latest [.NET Core 3.0 Preview SDK](https://dotnet.microsoft.com/download/dotnet-core/3.0) release.
1. Install the latest [Visual Studio preview](https://visualstudio.microsoft.com/vs/preview/) with the ASP.NET and web development workload.

Or follow the [getting started documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor/get-started?view=aspnetcore-3.0&tabs=visual-studio) to run this application

## Overview
- Main logic within TheElevatorProblem\Pages\ElevatorProblem\ElevatorProblem.razor
- When entering the page with the list of elevators, it defaults to 10 floors and 3 elevators.
- Floors are divided into two sections. The Left side contains elevators with passengers. The Right side contains waiting passengers.
- Elevators start at the bottom level.
- There are many options and statistics shown.
- Time is measured in 'units'.
- Power is measured in 'floor changes'.
- New Passengers are placed on a random floor and requests a random floor.
- If deleting entities with entities within them, god help us all on how it was handled.
- Pretty pictures are available within this directory.

## Technical Challenges
- May take time to respond to a requesting passenger. Currently it looks to see if there is at least one passenger that exists and sends on elevator per direction. Does not send multiple. Does not take into account for cost over time for power.
- Not efficient if running large datasets.
- Having a Task wait is unavailable within Blazor since Blazor's implementation for WASM does not allow it. I could be wrong.
- As more components are rendered on screen, the slower it gets. Good for shorter demonstrations or fewer passengers.

## Missing
- One requirement is to have the state of each button of the floor. A work around if needed is to check for passengers that are not in a current elevator and their current floor is not their requested floor. You can deduct the button they pressed buy the floor they are requesting relative to their current floor.
- Another requirement missing is time elapsed since each floor-button pushed. This again would be easy to implement per max wait time of a requesting passenger per floor per direction.
