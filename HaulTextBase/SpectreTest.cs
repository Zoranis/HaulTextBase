using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase
{
    internal static class SpectreTest
    {
        public static void TestSpectre()
        {
            AnsiConsole.MarkupLine("[green]Welcome to the Game![/]");
            AnsiConsole.Write(new Rule("[yellow]Main Menu[/]"));

            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What do you want to do?")
                    .AddChoices(new[] { "Start Game", "Load Game", "Exit" }));

            AnsiConsole.MarkupLine($"[blue]You selected:[/] {choice}");
        }
    }
}
