using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLO_WORLD
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //GoBtn.Text = "HELLO WORLD"
            //Inputtext.Text = "great";
            //outboxtext.item add(Input.text);
            //GoBtn.Text = "HELLO";
            outbox.Items.Add(InputText.Text);
            MessageBox.Show("click on button");
        }
    }
}
