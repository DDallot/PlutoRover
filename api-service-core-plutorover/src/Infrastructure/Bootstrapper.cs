using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Api.Services.Core.PlutoRover.Configuration;
using Api.Services.Core.PlutoRover.Services.PlutoRover;
using Api.Contracts.Core.PlutoRover.PlutoRover.v1;
using Api.Services.Core.PlutoRover.Dal.PlutoRover;
using Api.Services.Core.PlutoRover.Services;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Validations;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Commands;

namespace Api.Services.Core.PlutoRover.Infrastructure
{
    public static class Bootstrapper
    {
        public static IServiceProvider Initialize(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var grid = new GridConfig();
            configuration.Bind("Grid", grid);
            serviceCollection.AddSingleton(grid);

            // Services
            serviceCollection.AddSingleton<IPlutoRover, PlutoRoverService>();
            serviceCollection.AddSingleton<ICommandHandler, CommandHandler>();

            serviceCollection.AddSingleton<CommandBuilder, CommandBuilder>();
            serviceCollection.AddSingleton<ICommand, BackwardCommand>();
            serviceCollection.AddSingleton<ICommand, ForwardCommand>();
            serviceCollection.AddSingleton<ICommand, LeftCommand>();
            serviceCollection.AddSingleton<ICommand, RightCommand>();

            serviceCollection.AddSingleton<IValidator, Validator>();
            serviceCollection.AddSingleton<IValidate, ValidateEdges>();

            // Dal
            serviceCollection.AddSingleton<IPlutoRoverDal, PlutoRoverDal>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
