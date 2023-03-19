using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TP_7_Julian_B_Ortega
{
    class DBFetcher
    {
        public static List<Empleado> GetAllEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ToString()))
            {
                connection.Open();

                /* 
                 Sé que lo enseñó de otra forma en la clase, pero no encuentro la parte en donde explica
                 como hacer los Stored Procedures para conseguir todos, uno, crear uno nuevo, etc. 

                 Así que lo hago de la forma simple:
                */

                SqlCommand command = new SqlCommand("SELECT * FROM Empleados;", connection);
                command.CommandType = CommandType.Text;

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    empleados.Add(ObtenerEmpleado(reader));
                }

            }

            return empleados;
        }

        public static bool CreateEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ToString()))
                {
                    connection.Open();

                    /* 
                     Sé que lo enseñó de otra forma en la clase, pero no encuentro la parte en donde explica
                     como hacer los Stored Procedures para conseguir todos, uno, crear uno nuevo, etc. 

                     Así que lo hago de la forma simple:
                    */

                    List<string> data = new List<string>()
                    {
                        empleado.Nombre,
                        empleado.DNI.ToString(),
                        empleado.Edad.ToString(),
                        Convert.ToInt32(empleado.Casado).ToString(),
                        empleado.Salario.ToString()
                    };

                    string dataString = "('" + empleado.Nombre + "', " + empleado.DNI + ", " + empleado.Edad + ", "
                        + Convert.ToInt32(empleado.Casado) + ", " + empleado.Salario + ")";
                    string sqlInsert = "INSERT INTO Empleados(NombreCompleto, DNI, Edad, Casado, Salario) VALUES " + dataString;

                    SqlCommand command = new SqlCommand(sqlInsert, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
        }

        private static Empleado ObtenerEmpleado(SqlDataReader reader)
        {
            string nombre = Convert.ToString(reader["NombreCompleto"]);
            int dni = Convert.ToInt32(reader["DNI"]);
            int edad = Convert.ToInt32(reader["Edad"]);
            bool casado = Convert.ToBoolean(reader["Casado"]);
            float salario = Convert.ToSingle(reader["Salario"]);

            return new Empleado(nombre, dni, edad, casado, salario);
        }
    }
}
