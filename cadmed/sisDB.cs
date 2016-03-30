using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace cadmed
{
    class sisDB
    {
       //Sql Server
       //private const string _strCon = @"Data Source=.\SQLBRUNO;Initial catalog=cadmed;Persist Security Info=True;User ID=root;Password=bv2013";
       //private string vsql = "";

       //Mysql
        private const string _strCon = @"Data Source = server=localhost;User Id=root;Persist Security Info=True;database=cadmed";


       SqlConnection objCon = null;
       

        public bool conectar(){
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
