using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EBISPlatform.Functions;
using EBISPlatform.Local;
using MySqlX.XDevAPI.Relational;
using System.Xml.Linq;

namespace EBISPlatform.Functions
{
    public class SQL
    {
        private static MySqlConnection _connection;
        public string SendAccountSQL(User user)
        {
            EstablishConnection();

            if (IsExisting("Paskyros", "El_Pastas", user.Email, false,"",""))
                return $"Email '{user.Email}' is already being used!";
            else if (IsExisting("Paskyros", "Vartotojo_Prisijungimas", user.UserName, false,"",""))
                return $"Username '{user.UserName}' is already being used!";
            else
            {
                var cmd = new MySqlCommand($"INSERT INTO Paskyros (Vardas, Pavarde, Vartotojo_Prisijungimas, " +
                    $"El_Pastas, Slaptazodis) values ('{user.Name}', '{user.LastName}', '{user.UserName}', " +
                    $"'{user.Email}', '{user.Password}')", _connection);
                cmd.ExecuteNonQuery();
            }

            _connection.Close();
            return string.Empty;
        }
        public bool IsLoginValid(string username, string password)
        {
            EstablishConnection();

            if (IsExisting("Paskyros", "Vartotojo_Prisijungimas", username, true, "Slaptazodis", password) || IsExisting("Paskyros", "El_Pastas", username, true, "Slaptazodis", password))
            {
                _connection.Close();
                return true;
            }
            _connection.Close();
            return false;
        }
        public bool IsExisting(string table, string where, string element, bool and, string where2, string element2)
        {
            MySqlCommand cmd = new MySqlCommand();
            if(and)
                cmd = new MySqlCommand($"select count(*) from {table} where {where} = '{element}' AND {where2} = '{element2}'", _connection);
            else
                cmd = new MySqlCommand($"select count(*) from {table} where {where} = '{element}'",_connection);
            object obj = cmd.ExecuteScalar();

            if (Convert.ToInt32(obj) == 0)
                return false;
            return true;
        }
        public void EstablishConnection()
        {
            try
            {
                _connection = new MySqlConnection();
                _connection.ConnectionString = ConfigJson.jsonConfig.MySqlConnection;
                _connection.Open();
            }
            catch(MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
