using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ComboBoxItem
    {
        public string Name;
        public int Value;
        public ComboBoxItem(string name, int value)
        {
            Name = name; Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
