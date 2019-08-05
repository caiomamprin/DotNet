using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace AppClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        async Task Log(string mensagem)
        {
            txtResult.Text = mensagem;
        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int r = ExecutarWebService();
                txtResult.Text = r.ToString();
            }
            catch (Exception E)
            {
                await Log(E.Message);
            }
            finally
            {
                // sempre
            }
        }

        private int ExecutarWebService()
        {
            var calc = new Proxy.CalcWebService();
            return calc.Somar(ToInt32(txtX.Text), ToInt32(txtY.Text));
        }
    }
}
