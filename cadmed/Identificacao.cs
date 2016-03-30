using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace cadmed
{
    class Identificacao : sisDatabase
    {
        public int PacienteId;
        public int cpf;
        public string nome;
        public string rg;
        public DataSetDateTime nascimento;
        public string estado_civil;
        public string sexo;
        public string naturalidade;
        public string profissao;
        public int cep;
        public string logradouro;
        public string complemento;
        public string bairro;
        public string uf;
        public string cidade;
        public int telefone1;
        public int telefone2;
        public string observacao;
        public string email;

        #region "Método de Execução de SQL"
       /* public bool insertPaciente()
        {
            Identificacao identificacao = null;

            string sql = "INSERT INTO identificacao (PacienteId,cpf,nome,rg,nascimento,estado_civil,sexo,naturalidade,profissao," +
                    "cep,logradouro,complemento,numero,bairro,uf,cidade,telefone1,telefone2,observacao,email)" +
                    "VALUES (@PacienteId,@cpf,@nome,@rg,@nascimento,@estado_civil,@sexo,@naturalidade,@profissao," +
                    "@cep,@logradouro,@complemento,@numero,@bairro,@uf,@cidade,@telefone1,@telefone2,@observacao,@email)";
           
            if (this.OpenConnection())
            {
                //MySqlCommand cmd = new MySqlCommand(sql, this.GetConnection());

                //MySqlDataReader dataReader = cmd.ExecuteReader();

               /* if (dataReader.Read())
                {
                    identificacao = new Identificacao();
                    //identificacao.PacienteId = int.MaxValue("{0}", dataReader["PacienteId"]);
                }*/
           /* }
        }*/

       // public bool updatePaciente() { }

        //public bool deletePaciente() { }
        #endregion

        #region "Método que ListaGrid - Faz Pesquisa"
       // public bool getPaciente() { }

        /* public bool getCep(int numCep) {
             getCep getCep = null;
             sql = "SELECT * from cep WHERE Cep="+numCep;
             if (this.OpenConnection())
             {
                 try
                 {
                 }
                 catch (MySqlException mysl_error)
                 {
                     throw mysl_error;
                 }
                 finally
                 {
                     this.CloseConnection();
                 }
             }
         }*/
        #endregion
    }
}
