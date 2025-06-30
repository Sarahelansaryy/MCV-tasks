using System;
using System.Collections.Generic;
using System.IO;

class ToDoList
{
    public List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Task added: " + task);

    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine(" No tasks in the list.");
            return;
        }

        Console.WriteLine("ToDo List:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);

        }
    }
        public void EditTask(int index, string newTask)
    {
        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }
        Console.WriteLine("Task updated from: " + tasks[index] + " to " + newTask);
        tasks[index] = newTask;
    }

public void RemoveTask(int index)
    {
        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine(" Invalid task number.");
            return;
        }
        Console.WriteLine(" Task removed: " + tasks[index]);

        tasks.RemoveAt(index);
    }
}
class Program
{
   
static void Main(string[] args)
{
    string folderPath = "../TODOList";
    Directory.CreateDirectory(folderPath);

    string[] taskFiles = Directory.GetFiles(folderPath, "*.txt");
    if (taskFiles.Length == 0)
    {
        Console.WriteLine("No task files found. Creating default: tasks.txt");
        string defaultPath = Path.Combine(folderPath, "tasks.txt");
        File.Create(defaultPath).Close();
        taskFiles = Directory.GetFiles(folderPath, "*.txt"); 
    }

    Console.WriteLine("\nAvailable Task Files:");
    for (int i = 0; i < taskFiles.Length; i++)
    {
        Console.WriteLine((i + 1) + ". " + Path.GetFileName(taskFiles[i]));
    }

    Console.Write("Choose a file number: ");
    int fileChoice = Convert.ToInt32(Console.ReadLine());
    string filepath;
    if (fileChoice >= 1 && fileChoice <= taskFiles.Length)
    {
        filepath = taskFiles[fileChoice - 1];
    }
    else
    {
        Console.WriteLine("Invalid selection. Using first file.");
        filepath = taskFiles[0];
    }

    ToDoList list = new ToDoList();
    string[] lines = File.ReadAllLines(filepath);
    list.tasks = new List<string>(lines);

    bool exit = false;

    while (!exit)
    {
        Console.WriteLine("***** Menu ******");
        Console.WriteLine("1. View Tasks");
        Console.WriteLine("2. Add Task");
        Console.WriteLine("3. Remove Task");
        Console.WriteLine("4. Edit Task");
        Console.WriteLine("5. Rename File");
        Console.WriteLine("6. Delete File");
        Console.WriteLine("7. Exit");
        Console.WriteLine("8. Switch File");

        Console.Write("Enter your choice (1-8): ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                list.ViewTasks();
                break;

            case "2":
                Console.Write("Enter task: ");
                string newtask = Console.ReadLine();
                if (!list.tasks.Contains(newtask))
                {
                    list.AddTask(newtask);
                    File.WriteAllLines(filepath, list.tasks);
                }
                else
                {
                    Console.WriteLine("Task already exists.");
                }
                break;

            case "3":
                Console.Write("Enter task number to remove: ");
                int removetask = Convert.ToInt32(Console.ReadLine());
                list.RemoveTask(removetask - 1);
                File.WriteAllLines(filepath, list.tasks);
                break;

            case "4":
                list.ViewTasks();
                Console.Write("Enter task number to edit: ");
                int editIndex = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter new task: ");
                string updatedText = Console.ReadLine();
                list.EditTask(editIndex - 1, updatedText);
                File.WriteAllLines(filepath, list.tasks);
                break;

            case "5":
                Console.Write("Enter new file name (with extension): ");
                string newname = Console.ReadLine();
                string newPath = Path.Combine(Path.GetDirectoryName(filepath), newname);

                if (File.Exists(filepath))
                {
                    if (!File.Exists(newPath))
                    {
                        File.Move(filepath, newPath);
                        filepath = newPath;
                        Console.WriteLine("File renamed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("A file with that name already exists.");
                    }
                }
                else
                {
                    Console.WriteLine("Original file does not exist.");
                }
                break;

            case "6":
                Console.Write("Enter filename to delete (with extension): ");
                string deleteFile = Console.ReadLine();
                string deletePath = Path.Combine(Path.GetDirectoryName(filepath), deleteFile);
                if (File.Exists(deletePath))
                {
                    File.Delete(deletePath);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
                break;

            case "7":
                exit = true;
                Console.WriteLine("Exiting the program.");
                break;

            case "8":
                taskFiles = Directory.GetFiles(folderPath, "*.txt");
                Console.WriteLine("\nAvailable Task Files:");
                for (int i = 0; i < taskFiles.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + Path.GetFileName(taskFiles[i]));
                }

                Console.Write("Choose a file number to switch to: ");
                int switchChoice = Convert.ToInt32(Console.ReadLine());
                if (switchChoice >= 1 && switchChoice <= taskFiles.Length)
                {
                    filepath = taskFiles[switchChoice - 1];
                    string[] switchLines = File.ReadAllLines(filepath);
                    list.tasks = new List<string>(switchLines);
                    Console.WriteLine("Switched to file: " + Path.GetFileName(filepath));
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 8.");
                break;
        }
    }
}

}
