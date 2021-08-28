using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUA_DATA.Class
{
    public class clsConexao
    {

        SqlConnection sqlCon = new SqlConnection();

        //Construtor
        public clsConexao()
        {
            sqlCon.ConnectionString = @"Data Source=DESKTOP-VOP47UL\SQLEXPRESS;Initial Catalog=BASICS;User ID=sa;Password=21081999";
        }

        //Método Conectar
        public SqlConnection Conectar()
        {
            if(sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            return sqlCon;

        }

        public void Desconectar()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

    }
}
