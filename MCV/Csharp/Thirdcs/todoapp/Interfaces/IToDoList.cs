

public interface IToDoList
{
    void AddTask(string task);
    void ViewTasks();
    void EditTask(int index, string newTask);
    void RemoveTask(int index);
}
