using System;

class Program
{
    static void Main(string[] args)
    {
        IToDoList list = new ToDoList();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n***** ToDo List Menu *****");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Edit Task");
            Console.WriteLine("4. Remove Task");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    list.ViewTasks();
                    break;

                case "2":
                    Console.Write("Enter new task: ");
                    string task = Console.ReadLine();
                    list.AddTask(task);
                    break;

                case "3":
                    list.ViewTasks();
                    Console.Write("Enter task number to edit: ");
                    int editIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Enter new task text: ");
                    string newTask = Console.ReadLine();
                    list.EditTask(editIndex, newTask);
                    break;

                case "4":
                    list.ViewTasks();
                    Console.Write("Enter task number to remove: ");
                    int removeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    list.RemoveTask(removeIndex);
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
