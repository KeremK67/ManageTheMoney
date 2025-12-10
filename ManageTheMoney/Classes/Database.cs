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

        // LOAD JOIN TABLE DATAGRIDVIEW - BİRLEŞTİRİLMİŞ TABLOYU DATAGRIDVIEW'E YÜKLE -- CHATGPT KODUDUR BEN YAZMADIM
        #region
        public static DataTable LoadJoinedTable(
        string mainTable,
        (string joinTable, string mainColumn, string joinColumn)[] joins,
        string[] columns = null,
        string where = "",
        string orderBy = "")
        {
            using var con = GetConnection();
            con.Open();

            // Kolon seçilmezse SELECT *
            string columnSelection = (columns == null || columns.Length == 0)
                ? "*"
                : string.Join(", ", columns);

            // JOIN'leri oluştur
            string joinSql = "";
            foreach (var j in joins)
                joinSql += $" JOIN {j.joinTable} ON {mainTable}.{j.mainColumn} = {j.joinTable}.{j.joinColumn}";

            // WHERE ekle
            string whereSql = string.IsNullOrWhiteSpace(where) ? "" : $" WHERE {where}";

            // ORDER BY ekle
            string orderSql = string.IsNullOrWhiteSpace(orderBy) ? "" : $" ORDER BY {orderBy}";

            string query = $"SELECT {columnSelection} FROM {mainTable}{joinSql}{whereSql}{orderSql}";

            using var cmd = new NpgsqlCommand(query, con);
            using var da = new NpgsqlDataAdapter(cmd);

            DataTable dt = new();
            da.Fill(dt);
            return dt;
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
        public static (decimal incomes, decimal expenses) GetIncomesAndExpenses(int year = 0, int month = 0, int day = 0)
        {
            decimal totalIncomes = 0, totalExpenses = 0;

            using (var connection = GetConnection())
            {
                connection.Open();

                string queryIncomes;
                string queryExpenses;

                using var commandIncomes = new NpgsqlCommand();
                using var commandExpenses = new NpgsqlCommand();

                commandIncomes.Connection = connection;
                commandExpenses.Connection = connection;

                if (year != 0 && month == 0 && day == 0)
                {
                    DateTime startDate = new DateTime(year, 1, 1);
                    DateTime endDate = startDate.AddYears(1);

                    queryIncomes = @"SELECT SUM(Amount) 
                             FROM Scenarios s
                             JOIN ScenarioTypes t ON s.TypeId = t.Id
                             WHERE s.UserId = @uid AND t.Category = 'Incomes'
                             AND s.ExpectedDate >= @start AND s.ExpectedDate < @end";

                    queryExpenses = queryIncomes.Replace("Incomes", "Expenses");

                    commandIncomes.CommandText = queryIncomes;
                    commandExpenses.CommandText = queryExpenses;

                    commandIncomes.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);
                    commandExpenses.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);

                    commandIncomes.Parameters.AddWithValue("start", startDate);
                    commandExpenses.Parameters.AddWithValue("start", startDate);

                    commandIncomes.Parameters.AddWithValue("end", endDate);
                    commandExpenses.Parameters.AddWithValue("end", endDate);
                }
                else if (year != 0 && month != 0 && day == 0)
                {
                    DateTime startDate = new DateTime(year, month, 1);
                    DateTime endDate = startDate.AddMonths(1);

                    queryIncomes = @"SELECT SUM(Amount) 
                             FROM Scenarios s
                             JOIN ScenarioTypes t ON s.TypeId = t.Id
                             WHERE s.UserId = @uid AND t.Category = 'Incomes'
                             AND s.ExpectedDate >= @start AND s.ExpectedDate < @end";

                    queryExpenses = queryIncomes.Replace("Incomes", "Expenses");

                    commandIncomes.CommandText = queryIncomes;
                    commandExpenses.CommandText = queryExpenses;

                    commandIncomes.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);
                    commandExpenses.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);

                    commandIncomes.Parameters.AddWithValue("start", startDate);
                    commandExpenses.Parameters.AddWithValue("start", startDate);

                    commandIncomes.Parameters.AddWithValue("end", endDate);
                    commandExpenses.Parameters.AddWithValue("end", endDate);
                }
                else if (year != 0 && month != 0 && day != 0)
                {
                    DateTime specificDate = new DateTime(year, month, day);

                    queryIncomes = @"SELECT SUM(Amount) 
                             FROM Scenarios s
                             JOIN ScenarioTypes t ON s.TypeId = t.Id
                             WHERE s.UserId = @uid AND t.Category = 'Incomes'
                             AND s.ExpectedDate = @date";

                    queryExpenses = queryIncomes.Replace("Incomes", "Expenses");

                    commandIncomes.CommandText = queryIncomes;
                    commandExpenses.CommandText = queryExpenses;

                    commandIncomes.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);
                    commandExpenses.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);

                    commandIncomes.Parameters.AddWithValue("date", specificDate);
                    commandExpenses.Parameters.AddWithValue("date", specificDate);
                }
                else
                {
                    queryIncomes = @"SELECT SUM(Amount) 
                             FROM Scenarios s
                             JOIN ScenarioTypes t ON s.TypeId = t.Id
                             WHERE s.UserId = @uid AND t.Category = 'Incomes'";

                    queryExpenses = queryIncomes.Replace("Incomes", "Expenses");

                    commandIncomes.CommandText = queryIncomes;
                    commandExpenses.CommandText = queryExpenses;

                    commandIncomes.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);
                    commandExpenses.Parameters.AddWithValue("uid", Properties.Settings.Default.LoggedUserId);
                }

                var result1 = commandIncomes.ExecuteScalar();
                totalIncomes = result1 == DBNull.Value ? 0 : Convert.ToDecimal(result1);

                var result2 = commandExpenses.ExecuteScalar();
                totalExpenses = result2 == DBNull.Value ? 0 : Convert.ToDecimal(result2);

                return (totalIncomes, totalExpenses);
            }
        }
        #endregion

        // senaryo ekle
        #region
        public static bool AddScenario(int accountId, string title, string description, int typeId, decimal amount, int probability, bool recurring, bool isRealized, bool isNecessary, DateTime? expectedDate = null, DateTime? expectedDateEnd = null, DateTime? realizedAt = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"INSERT INTO Scenarios (UserId, AccountId, Title, Description, TypeId, Amount, ExpectedDate, ExpectedDateEnd, Probability, Recurring, IsRealized, IsNecessary, RealizedAt) 
                                 VALUES (@UserId, @AccountId, @Title, @Description, @TypeId, @Amount, @ExpectedDate, @ExpectedDateEnd, @Probability, @Recurring, @IsRealized, @IsNecessary, @RealizedAt)";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("UserId", Properties.Settings.Default.LoggedUserId);
                    command.Parameters.AddWithValue("AccountId", accountId);
                    command.Parameters.AddWithValue("Title", title);
                    command.Parameters.AddWithValue("Description", description);
                    command.Parameters.AddWithValue("TypeId", typeId);
                    command.Parameters.AddWithValue("Amount", amount);
                    command.Parameters.AddWithValue("ExpectedDate", expectedDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("ExpectedDateEnd", expectedDateEnd ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("Probability", probability);
                    command.Parameters.AddWithValue("Recurring", recurring);
                    command.Parameters.AddWithValue("IsRealized", isRealized);
                    command.Parameters.AddWithValue("IsNecessary", isNecessary);
                    command.Parameters.AddWithValue("RealizedAt", realizedAt ?? (object)DBNull.Value);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        #endregion

        // hesapları getir
        #region
        public static string[] GetAccounts()
        {
            List<string> accounts = new List<string>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Name FROM Accounts WHERE UserId = @UserId";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("UserId", Properties.Settings.Default.LoggedUserId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return accounts.ToArray();
        }
        #endregion

        // gelir gider kategorisini getir
        #region
        public static string[] GetScenarioTypesByCategory(bool incomes)
        {
            string category = incomes ? "Incomes" : "Expenses";

            List<string> types = new List<string>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Name FROM ScenarioTypes WHERE Category = @Category";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("UserId", Properties.Settings.Default.LoggedUserId);
                    command.Parameters.AddWithValue("Category", category);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            types.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return types.ToArray();
        }
        #endregion

        // accountId al
        #region
        public static int GetAccountIdByName(string accountName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Id FROM Accounts WHERE Name = @Name AND UserId = @UserId";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Name", accountName);
                    command.Parameters.AddWithValue("UserId", Properties.Settings.Default.LoggedUserId);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
        #endregion

        // typeId al
        #region
        public static int GetTypeIdByName(string typeName, string category)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Id FROM ScenarioTypes WHERE Name = @Name AND Category = @Category";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Name", typeName);
                    command.Parameters.AddWithValue("Category", category);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
        #endregion

        // senaryo sil
        #region
        public static bool DeleteScenario(int scenarioId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Scenarios WHERE Id = @Id AND UserId = @UserId";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Id", scenarioId);
                    command.Parameters.AddWithValue("UserId", Properties.Settings.Default.LoggedUserId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        #endregion

    }
}
