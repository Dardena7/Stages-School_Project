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
    public partial class SuccessDialog : Form
    {
        private List<String> successMessages;
        public SuccessDialog(List<String> successMessages)
        {
            InitializeComponent();
            this.successMessages = successMessages;
        }

        private void SuccessDialog_Load_1(object sender, EventArgs e)
        {
            String message = "Cette opération a été réalisée :\n\n";
            foreach (String m in successMessages)
                message += m + "\n";
            this.labelSuccessMessage.Text = message;
        }
    }

}
