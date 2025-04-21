
using System.Data.SqlClient;

namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNovoContato = new Label();
            lblContatoSalvo = new Label();
            txtNovoContato = new TextBox();
            txtContatoSalvo = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNovoContato
            // 
            lblNovoContato.AutoSize = true;
            lblNovoContato.Location = new Point(12, 9);
            lblNovoContato.Name = "lblNovoContato";
            lblNovoContato.Size = new Size(82, 15);
            lblNovoContato.TabIndex = 0;
            lblNovoContato.Text = "Novo Contato";
            lblNovoContato.Click += label1_Click;
            // 
            // lblContatoSalvo
            // 
            lblContatoSalvo.AutoSize = true;
            lblContatoSalvo.Location = new Point(12, 53);
            lblContatoSalvo.Name = "lblContatoSalvo";
            lblContatoSalvo.Size = new Size(81, 15);
            lblContatoSalvo.TabIndex = 1;
            lblContatoSalvo.Text = "Contato Salvo";
            lblContatoSalvo.Click += label2_Click;
            // 
            // txtNovoContato
            // 
            txtNovoContato.Location = new Point(12, 27);
            txtNovoContato.Name = "txtNovoContato";
            txtNovoContato.Size = new Size(428, 23);
            txtNovoContato.TabIndex = 2;
            // 
            // txtContatoSalvo
            // 
            txtContatoSalvo.Location = new Point(12, 71);
            txtContatoSalvo.Name = "txtContatoSalvo";
            txtContatoSalvo.Size = new Size(428, 23);
            txtContatoSalvo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(365, 110);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtContatoSalvo);
            Controls.Add(txtNovoContato);
            Controls.Add(lblContatoSalvo);
            Controls.Add(lblNovoContato);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNovoContato.Text;
            txtContatoSalvo.Text = nome;

            string strConnection = @"Data Source =.\sqlexpress;Initial Catalog=Agenda;Integrated Security=True;";

            SqlConnection con = new SqlConnection(strConnection);
            con.Open();

            string sql = String.Format("insert into Contato (Id,Nome) values ('{0}', '{1}');", Guid.NewGuid().ToString(), nome);

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        #endregion

        private Label lblNovoContato;
        private Label lblContatoSalvo;
        private TextBox txtNovoContato;
        private TextBox txtContatoSalvo;
        private Button btnSalvar;
    }
}
