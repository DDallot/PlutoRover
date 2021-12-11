# Introduction

After NASA’s New Horizon successfully flew past Pluto, they now plan to land a Pluto Rover
to further investigate the surface. You are responsible for developing an API that will allow
the Rover to move around the planet. As you won’t get a chance to fix your code once it is
onboard, you are expected to use test driven development.

To simplify navigation, the planet has been divided up into a grid. The rover's position and
location is represented by a combination of x and y coordinates and a letter representing
one of the four cardinal compass points. An example position might be 0, 0, N, which
means the rover is in the bottom left corner and facing North. Assume that the square
directly North from (x, y) is (x, y+1).

# Dependencies
* Api.Contract.Core.PlutoRover
* Api.Service.Core.PlutoRover
	* AutoMapper (10.1.1)
	* AutoMapper.Extensions.Microsoft.DependencyInjection (8.1.1)
    * Microsoft.AspNetCore.Mvc.Versioning (5.0.0)
    * Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer (5.0.0)
    * Swashbuckle.AspNetCore(6.2.3)
* Api.Services.Core.PlutoRover.UnitTests
    * FluentAssertions (6.2.0)
    * Microsoft.NET.Test.Sdk (16.11.0)
    * xunit (2.4.1)
    * xunit.runner.visualstudio (2.4.3)

# Features
* Get the current Rover's location
* Move Rover forward, backward, right and left

# Configuration
Define the grid area on the appsettings to determine robot's world.
```
  "Grid": {
    "MinX": 0,
    "MinY": 0,
    "MaxX": 100,
    "MaxY": 100
  }
```

# Implementation
`PlutoRoverService` is the core service responsible for getting the rover's current position, as well as mapping the object and calling the `CommandHandler`. 
The Command Handler's duty is to define the actions which will be applied on Robot, hence:
* Execute commands (a Builder class was made, `CommandBuilder`, to create the commands):
    * `BackwardCommand`
    * `ForwardCommand`
    * `LeftCommand `
    * `RightCommand`
* Validate the rover's new position through a Strategy design pattern:
    * `ValidateEdges` 
* Handle the errors.

# Extend
Through the implementation of the interface, `ICommand`, the Rover's movement can be expanded.

# Note
* At the moment, the code is not fully prepared to handle exceptions;
* The Database layer is mocked. 