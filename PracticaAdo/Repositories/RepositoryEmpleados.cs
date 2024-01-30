using PracticaAdo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAdo.Repositories
{
    internal class RepositoryEmpleados
    {

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public RepositoryEmpleados() 
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=""NET CORE"";Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public List<string> GetEmpleados()
        {
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = "SP_CLIENTES";
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<string> clientes = new List<string>();
            while (this.reader.Read())
            {
                clientes.Add(this.reader["Empresa"].ToString());
            }
            this.connection.Close();
            this.reader.Close();
            return clientes;
        }

        public DatosPedidos GetPedidos(string codigopedido)
        {   
            SqlParameter pamCodigoPedido = new SqlParameter("@codigopedido", codigopedido);
            this.command.Parameters.Add(pamCodigoPedido);
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = "SP_PEDIDOS";
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            DatosPedidos resumen = new DatosPedidos();
            while (this.reader.Read())
            {
                string codigoPedido = this.reader["CodigoPedido"].ToString();
                resumen.Pedidos.Add(codigoPedido);
            }
            this.reader.Close();
            this.connection.Close();
            this.command.Parameters.Clear();
            return resumen;
        }
    }
}
