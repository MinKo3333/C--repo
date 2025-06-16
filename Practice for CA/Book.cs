using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_for_CA
{
    internal class Book : ILibraryItem
    {
        public string Name { get; set; }
        public int Pages { get; set; }

        public void ShowInfo();
    }
}
