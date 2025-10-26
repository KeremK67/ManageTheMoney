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

        // Neon.tech veri tabanı sunucusu
        private const string _connectionString = "Host=ep-crimson-boat-agf5c418-pooler.c-2.eu-central-1.aws.neon.tech;Username=neondb_owner;Password=npg_ACRMSb4a2Eel;Database=DBManageTheMoney;SslMode=Require;";

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
            string query = "SELECT Id FROM Users WHERE Username = @username";
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            query = "SELECT Id FROM Users WHERE Password = @password";
                            using (NpgsqlCommand passwordCommand = new NpgsqlCommand(query, connection))
                            {
                                passwordCommand.Parameters.AddWithValue("@password", password);
                                using (NpgsqlDataReader passwordReader = passwordCommand.ExecuteReader())
                                {
                                    if (!passwordReader.Read())
                                    {
                                        MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false; // Giriş başarısız
                                    }
                                }
                            }
                            return true; // Giriş başarılı
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; // Giriş başarısız
                        }
                    }
                }
            }
        }
    }
}
