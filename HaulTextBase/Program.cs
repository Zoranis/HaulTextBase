using Haul.Contracts.Interfaces;
using Haul.Engine;
using Haul.Engine.API;
using Haul.Engine.Game;
using HaulTextBase;
using Microsoft.Extensions.DependencyInjection;

// add IController to the DI container
var services = new ServiceCollection();


services.AddScoped<IGameManager, GameManager>();
services.AddScoped<IController, Controller>();

// Register UI services
services.AddScoped<BasicUI>();

// Add External Services
services.AddEngineServices();

var serviceProvider = services.BuildServiceProvider();

// Start the application
var ui = serviceProvider.GetRequiredService<BasicUI>();

