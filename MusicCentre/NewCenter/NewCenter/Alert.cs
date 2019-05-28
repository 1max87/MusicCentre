using System;
using System.Windows.Forms;

namespace NewCenter
{
    public partial class Alert : Form
    {
        public Alert(string alert, int form)
        {
            InitializeComponent();
            if (form == 1)
            {
                Text = "Помощь - ''Music Service Center''";
            }
            if (form == 2)
            {
                Text = "Ошибка - ''Music Service Center''";
            }

            label1.Text = alert;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
