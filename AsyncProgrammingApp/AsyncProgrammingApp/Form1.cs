using AsyncProgrammingApp.Services;

namespace AsyncProgrammingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello clicked");
        }

        private void btnPrintSync_Click(object sender, EventArgs e)
        {
            PrinterService service = new PrinterService();
            service.Print(8);

            MessageBox.Show("end of click(blocking)");
        }

        private void btnThread_Click(object sender, EventArgs e)
        {

            PrinterService service = new PrinterService();
            service.PrintViaThread();
            MessageBox.Show("end of click (non blocking)");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a form Load event)");
        }
    }
}
