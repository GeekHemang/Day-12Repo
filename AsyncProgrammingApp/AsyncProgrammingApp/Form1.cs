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
            service.Print();
        }
    }
}
