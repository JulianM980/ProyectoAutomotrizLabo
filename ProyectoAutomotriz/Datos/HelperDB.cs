using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutomotriz.Datos
{
    internal class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn;
        private  HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.CadenaEzequiel);
        }
        public static HelperDB ObtenerInstancia() { 
            if(instancia == null) instancia = new HelperDB();
            return instancia;
        }
        public DataTable ConsultarSp(string nombreSP) {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP,cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarSp(string nombreSP, List<Parametro> lst) {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (Parametro p in lst) {
                cmd.Parameters.AddWithValue(p.Nombre,p.Valor);
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarSelect(string consulta)
        {
            DataTable table = new DataTable();
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            table.Load(comando.ExecuteReader());
            cnn.Close();
            return table;
        }
    }
}
