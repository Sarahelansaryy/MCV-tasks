

public class ToDoList : IToDoList
{
    private List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Task added: " + task);
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the list.");
            return;
        }

        Console.WriteLine("Current ToDo List:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    public void EditTask(int index, string newTask)
    {
        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }
        Console.WriteLine($"Task updated from '{tasks[index]}' to '{newTask}'");
        tasks[index] = newTask;
    }

    public void RemoveTask(int index)
    {
        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }
        Console.WriteLine("Task removed: " + tasks[index]);
        tasks.RemoveAt(index);
    }
}
