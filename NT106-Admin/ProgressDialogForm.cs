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

        public void ShowProgress(Form form, string? message = null)
        {
            if (message !=null) lblMessage.Text = message; else lblMessage.Text = "Please wait...";
            this.Show();
            form.Enabled = false;
        }
        public void CloseProgress(Form form)
        {
            this.Close();
            form.Enabled = true;
        }
    }
}
