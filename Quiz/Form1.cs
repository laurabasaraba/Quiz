namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (radioButton1.Checked) s++;
            if (checkBox1.Checked) s++;
            if(checkBox3.Checked) s++;
            if (checkBox2.Checked) s =1;
            MessageBox.Show("Scor " + s.ToString());

        }
    }
}
