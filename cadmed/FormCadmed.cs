using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace cadmed
{
    public partial class form_cadmed : Form
    {
        
        public form_cadmed()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sisDatabase testConnect = new sisDatabase();         
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lbDateTime.Text = "Data: "+dataHora.ToShortDateString()+" - Hora: "+dataHora.ToLongTimeString();

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void Localizar_Click(object sender, EventArgs e)
        {

        }

        private void Excluir_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TestDb();
        }

        private void Novo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja sair do sistema!", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void TestDb()
        {
            sisDatabase obj = new sisDatabase();
            ArrayList arr = new ArrayList();

            //PacienteId,cpf,nome,rg,nascimento,estado_civil,sexo,naturalidade,profissao
            //cep,logradouro,complemento,numero,bairro,uf,cidade,telefone1,telefone2,observacao,email

            try
            {
                arr.Add("PacienteId");
                arr.Add(12345678909);
                arr.Add("Bruno");
                arr.Add(123);
                arr.Add(06031984);
                arr.Add("solteiro");
                arr.Add("M");
                arr.Add("Belo Horizonte");
                arr.Add("Developer");
                arr.Add(01001000);
                arr.Add("Rua");
                arr.Add("Casa");
                arr.Add(20);
                arr.Add("Bairro");
                arr.Add("mg");
                arr.Add("Belo Horizonte");
                arr.Add(12345678);
                arr.Add(12345678909);
                arr.Add("teste cadmed");
                arr.Add("bvaugusto@gmail.com");


                if (obj.insertPaciente(arr))
                {
                    MessageBox.Show("Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar paciente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error + "Erro Ocorrido");
            }

        }
    }
}
