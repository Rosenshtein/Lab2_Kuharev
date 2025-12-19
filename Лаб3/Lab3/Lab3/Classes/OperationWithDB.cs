using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3.Classes
{
    public static class OperationWithDB
    {
        #region Переменные
        static public MySqlConnection myConnect;
        static public MySqlCommand myCommand = new MySqlCommand();
        static public MySqlDataAdapter adapter = new MySqlDataAdapter();
        static public DataTable dtArrays = new DataTable();
        static internal int id = -1;
        static internal int id_array = -1;
        static internal int id_array_sort = -1;
        #endregion

        #region Вспомогательные методы
        internal static void PrintErrorAutCatch()
        {
            MessageBox.Show("Ошибка при попытке авторизации!", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void PrintErrorAut()
        {
            MessageBox.Show("Проверьте правильность \n" +
            "введенного логина или пароля",
            "Не удалось войти в аккаунт!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal static void PrintErrorReg()
        {
            MessageBox.Show("Ошибка регистрации!", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void PrintErrorCon()
        {
            MessageBox.Show("Ошибка при подключении к БД!", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void PrintError()
        {
            MessageBox.Show("Ошибка загрузки!", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        #endregion

        #region Подключение к БД и авторизация
        internal static bool ConnectToDB()
        {
            string conString = "Server=localhost;" +
                    "Port=3306;Database=arrays_db;" +
                    "User ID=root;Password=123456789";

            myConnect = new MySqlConnection(conString);
            try
            {
                myConnect.Open();
                myCommand.Connection = myConnect;
                return true;
            }
            catch
            {
                CloseConnection(myConnect);
                PrintErrorCon();
                return false;
            }
        }


        internal static void CloseConnection(MySqlConnection? conn)
        {
            if (conn == null)
                return;

            if (conn.State != ConnectionState.Closed)
                conn.Close();
 
            conn.Dispose();     // освобождаем ресурсы
        }

        internal static bool Adapt(DataTable table)
        {
            try
            {
                table.Clear();
                adapter.Fill(table);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке таблицы!");
                return false;
            }
        }

        internal static bool AutorizationMethod(string login, string password)
        {

            try
            {
                string sql = @"SELECT user_id, password FROM users
                         WHERE login = @login
                         LIMIT 1;";

                myCommand.CommandText = sql;
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@login", login);
    


                using var result = myCommand.ExecuteReader();
                if (!result.Read())
                {
                    PrintErrorAut();
                    return false;
                }

                id = result.GetInt32("user_id");
                string hash = result.GetString("password");

                bool ok = BCrypt.Net.BCrypt.Verify(password, hash);
                if (!ok)
                    return false;

                return true;
            }
            catch
            {
                PrintErrorAutCatch();
                return false;
            }
        }

        internal static bool IsLoginFree(string login)
        {
            try
            {
                string sql = @"SELECT COUNT(*) FROM users WHERE login = @login";

                myCommand.CommandText = sql;
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@login", login);

                int count = Convert.ToInt32(myCommand.ExecuteScalar());

                // если 0 — логин свободен
                return count == 0;
            }
            catch
            {
                return false; // при ошибке считаем, что логин недоступен
            }
        }

        internal static bool Registration(string login, string password)
        {

            try
            {
                string sql = @"INSERT INTO 
                users (login,password)
                VALUES (@login, @hash)";

                string hash = BCrypt.Net.BCrypt.HashPassword(password);

                myCommand.CommandText = sql;
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@login", login);
                myCommand.Parameters.AddWithValue("@hash", hash);

                if (myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                PrintErrorReg();
                return false;
            }
        }



        internal static bool UserHasArrays()
        {
            string sql = @" 
                SELECT COUNT(*)
                FROM arrays
                WHERE user_id = @id;";

            myCommand.CommandText = sql;
            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@id", id);

            var count = Convert.ToInt32(myCommand.ExecuteScalar());

            if (count > 0)
                return true;
            else
                return false;
        }
        #endregion

        #region Работа с таблицами
        internal static DataTable LoadTable(DataTable table)
        {
            try
            {
                string sql = @"SELECT array_id,
                CASE array_role
                WHEN 'original' THEN 'Оригинальный'
                WHEN 'sorted'   THEN 'Отсортированный'
                END AS array_role
                FROM arrays
                WHERE user_id = @id;";

                myCommand.CommandText = sql;
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@id", id);

                adapter = new MySqlDataAdapter(myCommand);
                Adapt(table);
                return table;
            }
            catch
            {
                PrintError();
                return table;
            }
        }

        internal static string LoadArrayValuesAsText(int arrayId)
        {
            try
            {
                const string sql = @"
                SELECT value
                FROM array_items
                WHERE array_id = @arrayId
                ORDER BY position;";

                var stringB = new StringBuilder();

                myCommand.CommandText = sql;
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@arrayId", arrayId);

                using var reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (stringB.Length > 0) stringB.Append(' ');
                    stringB.Append(reader.GetInt32(0));
                }
                return stringB.ToString();

            }
            catch
            {
                PrintError();
                return "";
            }
        }

        internal static void SaveOriginalArray(int[] arr)
        {
            try
            {
                const string sql = @"INSERT INTO
                arrays (user_id, array_role, length)
                values (@id, ""original"", @length)";

                myCommand.CommandText = sql;
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@id", id);
                myCommand.Parameters.AddWithValue("@length", arr.Length);

                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "SELECT LAST_INSERT_ID();";
           
                id_array = Convert.ToInt32(myCommand.ExecuteScalar());


            }
            catch
            {
                PrintError();
            }
        }

        internal static void InsertArrayItems(int[] values)
        {
            try
            {
                const string sql = @"
                INSERT INTO array_items
                (array_id, `position`, value)
                VALUES (@aid, @pos, @val);";

                using var tx = myConnect.BeginTransaction();
                using var cmd = new MySqlCommand(sql, myConnect, tx);

                cmd.Parameters.Add("@aid", MySqlDbType.Int32).Value = id_array;
                var pPos = cmd.Parameters.Add("@pos", MySqlDbType.Int32);
                var pVal = cmd.Parameters.Add("@val", MySqlDbType.Int32);

                for (int i = 0; i < values.Length; i++)
                {
                    pPos.Value = i;
                    pVal.Value = values[i];
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                // лучше вывести реальную ошибку
                MessageBox.Show(ex.ToString());
                PrintError();
            }
        }


        internal static bool SaveSortedArray(int[] arrSort)
        {
            try
            {
                const string sql = @"INSERT INTO
                arrays (user_id, array_role, source_array_id, length)
                values (@id, ""sorted"",@id_array, @length)";

                myCommand.CommandText = sql;
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@id", id);
                myCommand.Parameters.AddWithValue("@length", arrSort.Length);
                myCommand.Parameters.AddWithValue("@id_array", id_array);

                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "SELECT LAST_INSERT_ID();";

                id_array_sort = Convert.ToInt32(myCommand.ExecuteScalar());
                if (id_array_sort > 0)
                    return true;
                else 
                    return false;

            }
            catch
            {
                PrintError();
                return false;
            }
        }

        internal static bool InsertArrayItemsSort(int[] values)
        {
            try
            {
                const string sql = @"
                INSERT INTO array_items
                (array_id, `position`, value)
                VALUES (@aid, @pos, @val);";

                using var tx = myConnect.BeginTransaction();
                using var cmd = new MySqlCommand(sql, myConnect, tx);

                cmd.Parameters.Add("@aid", MySqlDbType.Int32).Value = id_array_sort;
                var pPos = cmd.Parameters.Add("@pos", MySqlDbType.Int32);
                var pVal = cmd.Parameters.Add("@val", MySqlDbType.Int32);

                for (int i = 0; i < values.Length; i++)
                {
                    pPos.Value = i;
                    pVal.Value = values[i];
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                PrintError();
                return false;
            }
        }



        #endregion
    }
}
