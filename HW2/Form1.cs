using HW2.Properties;

namespace HW2
{
    public partial class HW1 : Form
    {
        public HW1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = Settings.Default.clientSize;
            this.Location = Settings.Default.clientLocation;
        }

        private bool verifyTextBox()
        {
            if (String.IsNullOrEmpty(this.textBox1.Text))
            {
                this.errorProvider1.SetError(this.textBox1, "Your name input is empty");
                return false;
            }
            if (this.textBox1.Text.Length >= 15)
            {
                this.errorProvider1.SetError(this.textBox1, "Your name input should not be longer than 15 character");
                return false;
            }
            return true;
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            verifyTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Focus();
            if (verifyTextBox())
            {
                this.listView1.Items.Add(this.textBox1.Text);
                this.textBox1.Clear();
                this.errorProvider1.SetError(this.textBox1, String.Empty);
            }
        }
    }
}