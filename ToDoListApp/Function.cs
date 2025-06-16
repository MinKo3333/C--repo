using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    internal class Function
    {
        public void AddItem(List<TodoItem> TodoItems,TodoItem item)
        {
            TodoItems.Add(item);
            Console.WriteLine("Todo is added");
        }

        public void RemoveItem(List<TodoItem> TodoItems, TodoItem item)
        {
            TodoItems.Remove(item);
            Console.WriteLine("Todo is removed");
        }

        public void FinishItem(List<TodoItem> TodoItems,TodoItem item)
        {
            item.Finished();
            ShowList(TodoItems);
        }

        public void ShowList(List<TodoItem> TodoItems)
        {
            int num = 1;
            foreach (var item in TodoItems)
            {
                Console.WriteLine($"{num}. {item.ToText()}");
                num++;
            }
        }


    }
}
