using System.Data.SqlClient;
namespace Agenda

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, object sqlConnection)
        {
            string nome = txtNovoContato.Text;
            txtContatoSalvo.Text = nome;

            string strConnection = @"Data Source=.\\sqlexpress;Initial Catalog=Agenda; Integred Security=True;";

            SqlConnection con = new SqlConnection(strConnection);
            con.Open();

            string sql = String.Format("insert into Contato (Id,Nome) values ('{0}', '{1}');", Guid.NewGuid().ToString(), nome);

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
