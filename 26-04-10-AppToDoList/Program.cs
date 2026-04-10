using System;

class Program // The main class of the To-Do List App
{
    static void Main() //L'entrée principale de l'application, où l'utilisateur interagit avec le menu
    {

        int choice; // La variable pour stocker le choix de l'utilisateur
        List<string> tasks = new List<string>(); // Créer une liste pour stocker les tâches


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
        {
            switch (choice) // Utiliser une structure de contrôle pour gérer les différentes options
            {
                case 1:
                    Console.WriteLine("Adding a task ");
                    Console.Write("Enter the task description: "); // L'invite pour que l'utilisateur entre la description de la tâche
                    string taskDescription = Console.ReadLine(); // Lire la description de la tâche
                    tasks.Add(taskDescription); // Ajouter la tâche à la liste
                    Console.WriteLine("Task added successfully!"); // Confirmer que la tâche a été ajoutée
                    break;
                case 2:
                    Console.WriteLine("===== Viewing Tasks =====");
                    if (tasks.Count == 0) // Vérification si la liste de tâches est vide
                    {
                        Console.WriteLine("No tasks displayed."); // Afficher un message si aucune tâche n'est présente)
                    }
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++) // Parcourir la liste des tâches et les afficher
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}"); // Afficher chaque tâche avec son numéro
                        }
                    }


                    break;
                case 3:
                    Console.WriteLine("Deleting a task");
                    Console.WriteLine("What do you want to delete? Enter the task number: "); // L'invite pour que l'utilisateur entre le numéro de la tâche à supprimer
                    int taskNumberToDelete = int.Parse(Console.ReadLine()); // Lire le numéro de la tâche à supprimer et le convertir en entier
                    if (taskNumberToDelete > 0 && taskNumberToDelete <= tasks.Count) // Vérification si le numéro de tâche est valide
                    {
                        tasks.RemoveAt(taskNumberToDelete - 1); // Supprimer la tâche de la liste
                        Console.WriteLine("Task deleted successfully!"); // Confirmer que la tâche a été supprimée
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number. Please try again."); // Afficher un message d'erreur si le numéro de tâche n'est pas valide
                    }
                    break;
                case 4:
                    Console.WriteLine("Taking a task for finish");
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
}