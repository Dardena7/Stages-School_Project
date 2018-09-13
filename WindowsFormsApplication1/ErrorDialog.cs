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
    public partial class ErrorDialog : Form
    {
        private List<String> errorMessages;
        public ErrorDialog(List<String> errorMessages)
        {
            InitializeComponent();
            this.errorMessages = errorMessages;
        }

        private void ErrorDialog_Load(object sender, EventArgs e)
        {
            String message = "Veuillez corriger ces erreurs :\n\n";
            foreach(String m in errorMessages)
                message += "- "+m+"\n";
            this.labelErrorMessage.Text = message;
        }
    }
}
