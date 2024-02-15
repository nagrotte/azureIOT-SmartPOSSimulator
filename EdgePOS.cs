using static SmartMeterSimulator.DeviceManager;
namespace SmartMeterSimulator
{
    public partial class EdgePOS : Form
    {
        public EdgePOS()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await RegisterDeviceAsync(textBox1.Text, textBox2.Text, "1000");
        }
    }
}