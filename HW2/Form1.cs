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

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Your name input is empty", "Error Detected in Input");
                return;
            }
            if (this.textBox1.Text.Length >= 15)
            {
                MessageBox.Show("Your name input should not be longer than 15 characters", "Error Detected in Input");
                return;
            }
        }
    }
}