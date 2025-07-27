using Haul.Contracts.Interfaces;
using Haul.Engine.API;
using Haul.Engine.Game;
using HaulTextBase;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

// add IController to the DI container
Debug.WriteLine("Setting up dependency injection...");
var services = new ServiceCollection();


services.AddScoped<IGameManager, GameManager>();
services.AddScoped<IController, Controller>();

// Register UI services
services.AddScoped<BasicUI>();

var serviceProvider = services.BuildServiceProvider();

// Start the application
var ui = serviceProvider.GetRequiredService<BasicUI>();

