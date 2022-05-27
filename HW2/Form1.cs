using HW2.Properties;

namespace HW2
{
    public partial class HW2 : Form
    {
        public HW2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1020, 560);
            this.ClientSize = Settings.Default.clientSize;
            this.Location = Settings.Default.clientLocation;
        }

        private bool verifyTextBox()
        {
            if (String.IsNullOrEmpty(this.textBox1.Text.Trim()))
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

        private void saveSizeButton_Click(object sender, EventArgs e)
        {
            Settings.Default.clientSize = this.ClientSize;
            Settings.Default.Save();
            //MessageBox.Show("Client size settings saved", "Success");
        }

        private void HW2_Deactivate(object sender, EventArgs e)
        {
            //will add once tray icon is working
            //this.Visible = false; 
        }

        private void HW2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listView1.Items.Count != 0) {
                if (MessageBox.Show("Are you sure you want to close the application?", "Names found!", MessageBoxButtons.YesNo) == DialogResult.No) {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Normal;
                    this.Visible = true;
                    this.Activate();
                }
            }
        }

        //Notify icon method
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //Checks if application is minimized
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

             //Activates the form
             this.Activate();

        }
        private void saveLocationButton_Click(object sender, EventArgs e)
        {
            Settings.Default.clientLocation = this.Location;
            Settings.Default.Save();
        }
    }
} 