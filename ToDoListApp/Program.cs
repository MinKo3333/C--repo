namespace ToDoListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoList todolist = new TodoList();
            Function function = new Function();
            Data data = new Data();

            todolist.welcome();
            while (true)
            {
                todolist.TodoListView();
                todolist.GetAnswer();
                todolist.RunFunction(function , data.TodoItems);
            }

            
        }
    }
}
