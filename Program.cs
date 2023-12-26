using System;
using System.Collections.Generic;

class TaskManager
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Task Manager!");

        while (true)
        {
            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayTasks();
                    break;

                case "2":
                    AddTask();
                    break;

                case "3":
                    RemoveTask();
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Incorrect choice. Please select again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Show tasks");
        Console.WriteLine("2. Add tasks");
        Console.WriteLine("3. Delete task");
        Console.WriteLine("4. Exit");
        Console.Write("Select an action (1-4): ");
    }

    static void DisplayTasks()
    {
        Console.WriteLine("\nTask List:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    static void AddTask()
    {
        Console.Write("\nEnter a new task: ");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("The task was added successfully!");
    }

    static void RemoveTask()
    {
        DisplayTasks();
        Console.Write("\nEnter the number of the task to delete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("The task was deleted successfully!");
        }
        else
        {
            Console.WriteLine("Incorrect input. The deletion has been canceled.");
        }
    }
}
