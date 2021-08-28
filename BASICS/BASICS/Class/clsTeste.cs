using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQUA_DATA.Class
{
    public class clsTeste
    {
        //Instancia a classe de conexão
        clsConexao oClsConexao = new clsConexao();  
        //Cria mensagem pública
        public string sMensagem = "";

        //Método de inserir
        public void Insert(string valor)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_insert_teste");
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Parametros
                oSqlCmd.Parameters.AddWithValue("@valor", SqlDbType.VarChar).Value = valor;

                //Conectar com banco
                oSqlCmd.Connection = oClsConexao.Conectar();
                //Executar Comando
                oSqlCmd.ExecuteNonQuery();
                //Desconectar
                oClsConexao.Desconectar();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro ao se conectar com o bando de dados ";
            }
        }

        //Método LoadGrid
        public void LoadGrid(DataGridView grdTeste, string valor)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_select_grid_teste");
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Parametros
                oSqlCmd.Parameters.AddWithValue("@valor", SqlDbType.VarChar).Value = valor;

                //Conectar com banco
                oSqlCmd.Connection = oClsConexao.Conectar();
                //Executar Comando
                DataTable oDataTable = new DataTable();
                oDataTable.Load(oSqlCmd.ExecuteReader());
                grdTeste.DataSource = oDataTable;
                //Desconectar
                oClsConexao.Desconectar();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro ao se conectar com o bando de dados ";
            }
        }

        //Método LoadField
        public void LoadField(string coluna, string parametro, TextBox txtRetorno)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_select_dados_teste");
                SqlDataReader oSqlDataReader;
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Parametros
                oSqlCmd.Parameters.AddWithValue("@coluna", SqlDbType.VarChar).Value = coluna;
                oSqlCmd.Parameters.AddWithValue("@parametro", SqlDbType.VarChar).Value = parametro;


                //Conectar com banco
                oSqlCmd.Connection = oClsConexao.Conectar();
                //Executar Comando
                oSqlDataReader = oSqlCmd.ExecuteReader();
                while (oSqlDataReader.Read())
                {
                    txtRetorno.Text = oSqlDataReader.GetValue(oSqlDataReader.GetOrdinal("Dado")).ToString();

                }


                //Desconectar
                oClsConexao.Desconectar();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro ao se conectar com o bando de dados ";
            }
        }

        //Método LoadCombo
        public void LoadCombo(ComboBox oCombo)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_select_combo_teste");
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Conectar com banco
                oSqlCmd.Connection = oClsConexao.Conectar();
                //Executar Comando
                DataTable oDataTable = new DataTable();
                oDataTable.Load(oSqlCmd.ExecuteReader());
                oCombo.ValueMember = "codigo";
                oCombo.DisplayMember = "valor";
                oCombo.DataSource = oDataTable;
                //Desconectar
                oClsConexao.Desconectar();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro ao se conectar com o bando de dados ";
            }
        }
    }
}
