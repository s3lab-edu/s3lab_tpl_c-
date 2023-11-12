using s3lab_tpl_csharp_util;
using System;
using System.Windows.Forms;

namespace s3lab_tpl_csharp_app
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do you love me?";
            string title = "flirt with";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;          

            DialogResult result;
            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
            {
                result = MessageBox.Show(message, title, buttons);
            }

            if (result == DialogResult.Yes)
            {
                // Do something
            }
            else
            {
                // Do something
            }
        }
    }
}
