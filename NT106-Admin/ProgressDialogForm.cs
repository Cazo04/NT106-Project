using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Admin
{
    public partial class ProgressDialogForm : Form
    {
        public ProgressDialogForm()
        {
            InitializeComponent();
        }

        public void ShowProgress(Control control, string? message = null)
        {
            if (message !=null) lblMessage.Text = message; else lblMessage.Text = "Please wait...";
            this.Show();
            control.Enabled = false;
        }
        public void CloseProgress(Control control)
        {
            this.Close();
            control.Enabled = true;
        }
    }
}
