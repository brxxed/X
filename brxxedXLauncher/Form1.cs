using System.Diagnostics;

namespace brxxedXLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            WorkerStart();
        }

        private void WorkerStart()
        {
            loadLabel.Text = "starting brxxed X";
            Thread.Sleep(1000);

            Process.Start("binaries/64/dev/brxxedXClient-64.exe");
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
