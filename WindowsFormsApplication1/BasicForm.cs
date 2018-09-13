using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
        }

        public class Item
        {
            public string name;
            public int value;
            public Item(string name, int value)
            {
                this.name = name; 
                this.value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return name;
            }

            public int getValue()
            {
                return value;
            }
        }
    }
}
