using System;
using System.Windows.Forms;

namespace NewCenter
{
    public partial class DescriptionForm : Form
    {
        public DescriptionForm()
        {
            InitializeComponent();
        }

        public ProblemDescription ProblemDescription { get; set; }

        private void DescriptionForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = ProblemDescription.ModelOfInstrument;
            textBox2.Text = ProblemDescription.FullDescription;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProblemDescription.ModelOfInstrument = textBox1.Text;
            ProblemDescription.FullDescription = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
   }
}
