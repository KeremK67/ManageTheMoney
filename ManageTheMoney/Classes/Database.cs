using System;
using System.Collections.Generic;
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
        //!Hasleme öğren!
        //!Orm öğren!

        // Neon.tech veri tabanı sunucusu
        private const string _connectionString = "Host=ep-crimson-boat-agf5c418-pooler.c-2.eu-central-1.aws.neon.tech;Username=neondb_owner;Password=npg_ACRMSb4a2Eel;Database=DBManageTheMoney;SslMode=Require;TrustServerCertificate=true;";

        // GET CONNECTION - BAĞLANTIYI ÇEK
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        // LOGIN SYSTEM - GİRİŞ SİSTEMİ
        // !ŞİFRELERİ HASHLE!
        // !HATA YÖNETİMİ EKLE!
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

        // REGISTER SYSTEM - KAYIT SİSTEMİ
        // !VERİ DENETİMİ EKLE!
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
    }
}
