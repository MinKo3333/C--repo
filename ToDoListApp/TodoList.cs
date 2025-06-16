using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoListApp
{
    internal class TodoList
    {
        int answer;
        public void welcome() 
        {
            Console.WriteLine("Welcome!");        
        }

        public (DateTime,string) GetUserInput() 
        {
            bool valid = false;
            DateTime deadline = new DateTime(2000,04,30);
            string text ="";
            while(valid == false) 
            { 
                Console.WriteLine("Write Deadline/Todo ex) 2025-06-13/Buy milk");
                string userInput =  Console.ReadLine();
                string[] Input = userInput.Split('/',2);
                valid  = DateTime.TryParse(Input[0], out deadline);
                text = Input[1];
            }
            return (deadline, text);
        }

        public void TodoListView() 
        {   
            Console.WriteLine("Choose work you want to do\n" +
                              "1. Add Todo\n" +
                              "2. View Todo\n" +
                              "3. Finish program");
        }

        public void GetAnswer() 
        {
            while (!int.TryParse(Console.ReadLine(), out answer)) {
                Console.WriteLine("Invalid Answer");
            }
        }

        public void inListView(Function function, TodoItem item, List<TodoItem> TodoItems) 
        {
            Console.WriteLine("Choose what you want to do with the work.\n" +
                "1. Remove the work\n" +
                "2. Finish the work\n" +
                "3. Back to the main manu");
            GetAnswer();
            inListFunction(function, item, TodoItems);

        }

        public void inListFunction(Function function,TodoItem item, List<TodoItem> TodoItems) 
        {
            switch (answer)
            {
                case 1:function.RemoveItem(TodoItems,item);
                    break;
                case 2:function.FinishItem(TodoItems,item);
                    break;
                case 3: break;
            }
        }
        public void RunFunction(Function function, List<TodoItem> TodoItems)
        {
            if (answer == 1)
            {   
                (DateTime Deadline, string text) = GetUserInput();
                TodoItem item = new TodoItem(text, Deadline);
                function.AddItem(TodoItems,item);
            }
            
            else if (answer == 2)
            {
                function.ShowList(TodoItems);
                Console.WriteLine("Choose Todo you want to work with");
                GetAnswer();
                TodoItem item = TodoItems[answer-1];
                inListView(function,item, TodoItems);
               
            }

            else if (answer == 3)
            {
                Environment.Exit(0);
            }

            else 
            {
                Console.WriteLine("Invalid answer");
                Environment.Exit(0);
            }

        }
    }
}
