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
    class sisDatabase
    {
        private const string _strConect = @"Data Source=BRUNO\SQLBRUNO;Initial Catalog=cadmed;Persist Security Info=True;User ID=cadmed;Password=cadmed2013";
        private string sql = "";
        SqlConnection objConect = null;

        public bool OpenConnection()
        {
            objConect = new SqlConnection(_strConect);
            try
            {
                objConect.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool CloseConnection()
        {
            if (objConect.State != ConnectionState.Closed)
            {
                objConect.Close();
                return true;
            }
            else
            {
                objConect.Dispose();
                return false;
            }
        }
        public bool insertPaciente(ArrayList p_arrInsert)
        {
            sql = "INSERT INTO identificacao ([PacienteId],[cpf],[nome],[rg],[nascimento],[estado_civil],[sexo],[naturalidade],[profissao]," +
                   "[cep],[logradouro],[complemento],[numero],[bairro],[uf],[cidade],[telefone1],[telefone2],[observacao],[email])" +
                   "VALUES (@PacienteId,@cpf,@nome,@rg,@nascimento,@estado_civil,@sexo,@naturalidade,@profissao," +
                   "@cep,@logradouro,@complemento,@numero,@bairro,@uf,@cidade,@telefone1,@telefone2,@observacao,@email)";
            SqlCommand objComm = null;

            if (this.OpenConnection())
            {
                try
                {
                    objComm = new SqlCommand(sql, objConect);
                    objComm.Parameters.Add(new SqlParameter("@PacienteId", p_arrInsert[0]));
                    objComm.Parameters.Add(new SqlParameter("@cpf", p_arrInsert[1]));
                    objComm.Parameters.Add(new SqlParameter("@nome", p_arrInsert[2]));
                    objComm.Parameters.Add(new SqlParameter("@rg", p_arrInsert[3]));
                    objComm.Parameters.Add(new SqlParameter("@nascimento", p_arrInsert[4]));
                    objComm.Parameters.Add(new SqlParameter("@estado_civil", p_arrInsert[5]));
                    objComm.Parameters.Add(new SqlParameter("@sexo", p_arrInsert[6]));
                    objComm.Parameters.Add(new SqlParameter("@naturalidade", p_arrInsert[7]));
                    objComm.Parameters.Add(new SqlParameter("@profissao", p_arrInsert[8]));
                    objComm.Parameters.Add(new SqlParameter("@cep", p_arrInsert[9]));
                    objComm.Parameters.Add(new SqlParameter("@logradouro", p_arrInsert[10]));
                    objComm.Parameters.Add(new SqlParameter("@complemento", p_arrInsert[11]));
                    objComm.Parameters.Add(new SqlParameter("@numero", p_arrInsert[12]));
                    objComm.Parameters.Add(new SqlParameter("@bairro", p_arrInsert[13]));
                    objComm.Parameters.Add(new SqlParameter("@uf", p_arrInsert[14]));
                    objComm.Parameters.Add(new SqlParameter("@cidade", p_arrInsert[15]));
                    objComm.Parameters.Add(new SqlParameter("@telefone1", p_arrInsert[16]));
                    objComm.Parameters.Add(new SqlParameter("@telefone2", p_arrInsert[17]));
                    objComm.Parameters.Add(new SqlParameter("@observacao", p_arrInsert[18]));
                    objComm.Parameters.Add(new SqlParameter("@email", p_arrInsert[19]));

                    objComm.ExecuteNonQuery();

                    return true;

                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
            else
            {
                return false;
            }
        }

        public bool updatePaciente(ArrayList p_arrUpdate)
        {
            sql = "update identificacao set [PacienteId],[cpf],[nome],[rg],[nascimento],[estado_civil],sexo,naturalidade,profissao," +
                   "cep,logradouro,complemento,numero,bairro,uf,cidade,telefone1,telefone2,observacao,email)" +
                   "VALUES (@PacienteId,@cpf,@nome,@rg,@nascimento,@estado_civil,@sexo,@naturalidade,@profissao," +
                   "@cep,@logradouro,@complemento,@numero,@bairro,@uf,@cidade,@telefone1,@telefone2,@observacao,@email)";
            SqlCommand objComm = null;

            if (this.OpenConnection())
            {
                try
                {
                    objComm = new SqlCommand(sql, objConect);
                    objComm.Parameters.Add(new SqlParameter("@PacienteId", p_arrUpdate[0]));
                    objComm.Parameters.Add(new SqlParameter("@cpf", p_arrUpdate[1]));
                    objComm.Parameters.Add(new SqlParameter("@nome", p_arrUpdate[2]));
                    objComm.Parameters.Add(new SqlParameter("@rg", p_arrUpdate[3]));
                    objComm.Parameters.Add(new SqlParameter("@nascimento", p_arrUpdate[4]));
                    objComm.Parameters.Add(new SqlParameter("@estado_civil", p_arrUpdate[5]));
                    objComm.Parameters.Add(new SqlParameter("@sexo", p_arrUpdate[6]));
                    objComm.Parameters.Add(new SqlParameter("@naturalidade", p_arrUpdate[7]));
                    objComm.Parameters.Add(new SqlParameter("@profissao", p_arrUpdate[8]));
                    objComm.Parameters.Add(new SqlParameter("@cep", p_arrUpdate[9]));
                    objComm.Parameters.Add(new SqlParameter("@logradouro", p_arrUpdate[10]));
                    objComm.Parameters.Add(new SqlParameter("@complemento", p_arrUpdate[11]));
                    objComm.Parameters.Add(new SqlParameter("@numero", p_arrUpdate[12]));
                    objComm.Parameters.Add(new SqlParameter("@bairro", p_arrUpdate[13]));
                    objComm.Parameters.Add(new SqlParameter("@uf", p_arrUpdate[14]));
                    objComm.Parameters.Add(new SqlParameter("@cidade", p_arrUpdate[15]));
                    objComm.Parameters.Add(new SqlParameter("@telefone1", p_arrUpdate[16]));
                    objComm.Parameters.Add(new SqlParameter("@telefone2", p_arrUpdate[17]));
                    objComm.Parameters.Add(new SqlParameter("@observacao", p_arrUpdate[18]));
                    objComm.Parameters.Add(new SqlParameter("@email", p_arrUpdate[19]));

                    objComm.ExecuteNonQuery();

                    return true;

                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
            else
            {
                return false;
            }
        }
    }
}