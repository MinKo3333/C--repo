using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    internal class TodoItem
    {
        private string Text;
        private DateTime Deadline;
        private DateTime? Done = null;

        public TodoItem(string text, DateTime deadline)
        {
            Text = text;
            Deadline = deadline;
        }

        public void Finished()
        {
            Done = DateTime.Today;
 }

        public string DateToString(DateTime? date)
        {
           return (date != null ? date.ToString().Substring(0, 10) : "");
        }

        public string ToText()
        {
                return DateToString(Deadline) + " " + DateToString(Done) + " " + Text;
        }

       
    }
}
