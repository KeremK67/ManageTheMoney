using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ManageTheMoney.Classes
{
    internal class Database
    {
        /*
         * BU CLASS DATABASE İŞLEMLERİ İÇİN OLUŞTURULDU.
         * SONRADAN KÜTÜPHANEYE ÇEVRİLECEK.
         */

        //!Transaction öğren!
        //!Hashleme öğren!
        //!Orm öğren!

        // Neon.tech veri tabanı sunucusu
        private const string _connectionString = "Host=ep-crimson-boat-agf5c418-pooler.c-2.eu-central-1.aws.neon.tech;Username=neondb_owner;Password=npg_ACRMSb4a2Eel;Database=DBManageTheMoney;SslMode=Require;TrustServerCertificate=true;";

        // GET CONNECTION - BAĞLANTIYI ÇEK
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        // GET USER ID BY USERNAME - KULLANICI ADINA GÖRE KULLANICI ID'SİNİ AL
        //!BUNUN YERİNE DAHA GÜVENLİ BİR YÖNTEM BUL!
        #region
        public static int GetUserIdByUsername(string username)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Id FROM Users WHERE Username = @username";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", username);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Kullanıcı bulunamazsa -1 döndür
                }
            }
        }
        #endregion

        // LOGIN SYSTEM - GİRİŞ SİSTEMİ
        // !ŞİFRELERİ HASHLE!
        // !HATA YÖNETİMİ EKLE!
        #region
        public static bool Login(string username, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT Id FROM UserAuth WHERE Username = @username AND Password = @password";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    var result = command.ExecuteScalar();
                    return result != null;
                }
            }
        }
        #endregion

        // REGISTER SYSTEM - KAYIT SİSTEMİ
        // !VERİ DENETİMİ EKLE!
        #region
        public static bool Register(string name, string surname, string username, string password, DateTime dateOfBirth, string email = null, string phoneNumber = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                int authRowsAffected, userId;

                // Users tablosu için kayıt
                string usersQuery = "INSERT INTO Users (Name, Surname, Username, DateOfBirth, Email, PhoneNumber) VALUES (@name, @surname, @username, @DateOfBirth, @email, @phoneNumber) RETURNING Id;"; // Id döndürüyoruz
                using (var usersCommand = new NpgsqlCommand(usersQuery, connection))
                {
                    usersCommand.Parameters.AddWithValue("name", name);
                    usersCommand.Parameters.AddWithValue("surname", surname);
                    usersCommand.Parameters.AddWithValue("username", username);
                    usersCommand.Parameters.AddWithValue("DateOfBirth", dateOfBirth);
                    usersCommand.Parameters.AddWithValue("email", email ?? (object)DBNull.Value); // Değer null ise DBNull.Value ile SQL'e bildir
                    usersCommand.Parameters.AddWithValue("phoneNumber", phoneNumber ?? (object)DBNull.Value);
                    userId = (int)usersCommand.ExecuteScalar(); // Eklenen kullanıcının Id'sini al
                }

                // UserAuth tablosu için kayıt
                string authQuery = "INSERT INTO UserAuth (UserId, Username, Password, Email, PhoneNumber) VALUES (@UserId, @username, @password, @email, @phoneNumber)";
                using (var authCommand = new NpgsqlCommand(authQuery, connection))
                {
                    authCommand.Parameters.AddWithValue("UserId", userId);
                    authCommand.Parameters.AddWithValue("username", username);
                    authCommand.Parameters.AddWithValue("password", password);
                    authCommand.Parameters.AddWithValue("email", email ?? (object)DBNull.Value);
                    authCommand.Parameters.AddWithValue("phoneNumber", phoneNumber ?? (object)DBNull.Value);
                    authRowsAffected = authCommand.ExecuteNonQuery();
                }

                // Her iki ekleme işlemi de başarılı olduysa true döndür
                return authRowsAffected > 0;
            }
        }
        #endregion

        // LOAD TABLE DATAGRIDVIEW - TABLOYU DATAGRIDVIEW'E YÜKLE
        #region
        public static DataTable LoadTable(string tableName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName} WHERE UserId = {Properties.Settings.Default.LoggedUserId} ORDER BY Id DESC";
                using (var adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        #endregion

        // GET TABLE - TABLOYU AL -- KULLANILMIYOR!!
        #region
        public static DataTable GetTable(string tableName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName} WHERE UserId = {Properties.Settings.Default.LoggedUserId}";
                using (var adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        #endregion

        // GET INCOMES AND EXPENSES - GELİRLERİ VE GİDERLERİ AL
        #region
        public static (decimal incomes, decimal espenses) GetIncomesAndExpenses()
        {
            // Değerler
            decimal totalIncomes;
            decimal totalExpenses;

            using (var connection = GetConnection())
            {
                connection.Open();

                // Incomes
                string queryIncomes = $"SELECT SUM(Amount) FROM Scenarios WHERE UserId = {Properties.Settings.Default.LoggedUserId} AND (SELECT Category FROM ScenarioTypes WHERE Id = Scenarios.TypeId) = 'Incomes'";
                using (var commandIncomes = new NpgsqlCommand(queryIncomes, connection))
                {
                    totalIncomes = commandIncomes.ExecuteScalar() is DBNull ? 0 : Convert.ToDecimal(commandIncomes.ExecuteScalar());
                }

                // Expenses
                string queryExpenses = $"SELECT SUM(Amount) FROM Scenarios WHERE UserId = {Properties.Settings.Default.LoggedUserId} AND (SELECT Category FROM ScenarioTypes WHERE Id = Scenarios.TypeId) = 'Expenses'";
                using (var commandExpenses = new NpgsqlCommand(queryExpenses, connection))
                {
                    totalExpenses = commandExpenses.ExecuteScalar() is DBNull ? 0 : Convert.ToDecimal(commandExpenses.ExecuteScalar());
                }

                return (totalIncomes, totalExpenses);
            }
        }
        #endregion
    }
}
