using AsyncProgrammingApp.Services;
using System.Threading.Tasks;

namespace AsyncProgrammingApp
{
    public partial class Form1 : Form
    {
        private PrinterService _printerService;
        public Form1()
        {

            InitializeComponent();
            _printerService = new PrinterService();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello clicked");
        }

        private void btnPrintSync_Click(object sender, EventArgs e)
        {
            _printerService.Print(8);

            MessageBox.Show("end of click(blocking)");
        }

        private void btnThread_Click(object sender, EventArgs e)
        {

            _printerService.PrintViaThread();
            MessageBox.Show("end of click (non blocking)");

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a form Load event)");
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            _printerService.PrintViaTask();
            MessageBox.Show("end of click(non blocking)");
        }

        private async void btnAwaitable_Click(object sender, EventArgs e)
        {
            await _printerService.PrintViaTaskWithAwaitable();
            MessageBox.Show("will be called after task is complted(after 10 seconds)");

        }

        private async void btnAwaitableResult_Click(object sender, EventArgs e)
        {

            string result = await _printerService.PrintViaTaskWithAwaitableAndResult();

            MessageBox.Show("after 10 second :" + result);

        }

        private async void btnApiCall_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://ks-testapi-keonig.azurewebsites.net/api/v1/Employee/all");
            MessageBox.Show(result);

        }
    }
}

