using System;

class Program // The main class of the To-Do List App
{
    static void Main() //L'entrée principale de l'application, où l'utilisateur interagit avec le menu
    {

        int choice; // La variable pour stocker le choix de l'utilisateur



        Console.WriteLine("Welcome to the To-Do List App!");
        Console.WriteLine("------------------------------");
        Console.WriteLine("1. Add a task");
        Console.WriteLine("2. View tasks");
        Console.WriteLine("3. Delete a task");
        Console.WriteLine("4. Take a task for finish");
        Console.WriteLine("5. Exit"); 
        Console.WriteLine("------------------------------");

        Console.Write("Enter your choice: "); // L'invite pour que l'utilisateur entre son choix
        choice = int.Parse(Console.ReadLine()); // Lire le choix de l'utilisateur et le convertir en entier
         while (choice != 5) // Tant que l'utilisateur ne choisit pas de quitter
            
            switch (choice) // Utiliser une structure de contrôle pour gérer les différentes options
            {
                case 1:
                    Console.WriteLine("Adding a task");
                    
                    break;
                case 2:
                    Console.WriteLine("Viewing tasks...");
                    // Code to view tasks goes here
                    break;
                case 3:
                    Console.WriteLine("Deleting a task...");
                    // Code to delete a task goes here
                    break;
                case 4:
                    Console.WriteLine("Taking a task for finish...");
                    // Code to take a task for finish goes here
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Delete a task");
            Console.WriteLine("4. Take a task for finish");
            Console.WriteLine("5. Exit");
            Console.WriteLine("------------------------------");
            Console.Write("Enter your choice: "); // L'invite pour que l'utilisateur entre son choix à nouveau
            choice = int.Parse(Console.ReadLine()); // Lire le choix de l'utilisateur et le convertir en entier



        }
}