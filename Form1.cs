namespace Homework_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + " - " + textBox3.Text + " " + " - " + textBox2.Text + " " + " - " + textBox4.Text + " " + " - " + textBox5.Text + " ");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}