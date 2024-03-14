using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormYes : Form
    {
        public FormYes(string messageStr)
        {
            InitializeComponent();

            lblMessage2.Text = messageStr;
        }

        private void btnSerialOK_Click(object sender, System.EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}