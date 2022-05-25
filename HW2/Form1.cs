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
    }
}