using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icp.Datos
{
    public class Postgres
    {
        public NpgsqlDataReader LeeReader(string sentencia)
        {
            Conexion.ConnectionString = CadenaConexion.ConnectionString;

            Command.Connection = Conexion;
            Command.CommandText = sentencia;

            try
            {
                if (Conexion.State != ConnectionState.Open)
                    Conexion.Open();

                return Command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en: {sentencia} {ex.Message}");
            }
        }

        NpgsqlConnection mConexion;
        public NpgsqlConnection Conexion
        {
            get {
                if (mConexion == null)
                    mConexion = new NpgsqlConnection();
                return mConexion;
            }
        }

        NpgsqlCommand mCommand;
        private NpgsqlCommand Command
        {
            get
            {
                if (mCommand == null)
                    mCommand = new NpgsqlCommand();
                return mCommand;
            }
        }

        NpgsqlConnectionStringBuilder mCadenaConexion;
        public NpgsqlConnectionStringBuilder CadenaConexion
        {
            get
            {
                if (mCadenaConexion == null)
                {
                    mCadenaConexion = new NpgsqlConnectionStringBuilder();
                }

                return mCadenaConexion;
            }
        }

    }
}
