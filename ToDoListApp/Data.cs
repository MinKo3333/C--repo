using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    internal class Data
    {
        public List<TodoItem> TodoItems  {get; private set;}

        public Data()
        {
            TodoItems = new List<TodoItem>();
        }
    }
}
