namespace HelloWorldWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter your name";
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello "+ txtName.Text);
        }
    }
}