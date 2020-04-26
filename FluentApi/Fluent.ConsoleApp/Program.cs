using System;
using Fluent.ConsoleApp.Commands;

namespace Fluent.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Run();
		}

		static void Run()
		{
			while (true)
			{
				var consoleInput = ReadFromConsole();
				if (string.IsNullOrWhiteSpace(consoleInput)) continue;

				try
				{
					string result = Execute(consoleInput);
					WriteToConsole(result);
				}
				catch (Exception ex)
				{
					WriteToConsole(ex.Message);
				}
			}
		}


		static string Execute(string command)
		{
			if (command == "1")
			{
				PropertiesDataAnnotations.Get();
			}
			else if (command == "2")
			{
				PropertiesFluentAPI.Get();
			}
			else if (command == "3")
			{
				RelationshipsDataAnnotations.Get();
			}
			else if (command == "4")
			{
				RelationshipsFluentAPI.Get();
			}
			else if (command == "5")
			{
				TableInheritanceDataAnnotations.Get();
			}
			else if (command == "6")
			{
				TableInheritanceFluentAPI.Get();
			}

			return "Complete";
		}


		public static void WriteToConsole(string message = "")
		{
			if (message.Length > 0)
			{
				Console.WriteLine(message);
			}
		}


		const string _readPrompt = "console> ";
		public static string ReadFromConsole(string promptMessage = "")
		{
			Console.WriteLine();
			Console.WriteLine("1 - Properties - Data Annotations");
			Console.WriteLine("2 - Properties - Fluent API");
			Console.WriteLine("3 - Relationships - Data Annotations");
			Console.WriteLine("4 - Relationships - Fluent API");
			Console.WriteLine("5 - Table Inheritance - Data Annotations");
			Console.WriteLine("6 - Table Inheritance - Fluent API");
			Console.Write(_readPrompt + promptMessage);
			return Console.ReadLine();
		}
	}
}
