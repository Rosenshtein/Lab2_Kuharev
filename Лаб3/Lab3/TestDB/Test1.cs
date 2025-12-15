using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace TestDB
{
    [TestClass]
    public sealed class Test1
    {
            
        private const string Cs = "Server=localhost;Port=3306;Database=arrays_db_test;Uid=root;Pwd=123456789;Connection Timeout=120;DefaultCommandTimeout=120;";
        private const int TestUserId = 1;

        public TestContext TestContext { get; set; } = null!;

        // -------- helpers --------

        private static int[] GenerateRandomArray(Random rng, int minLen = 5, int maxLen = 50, int minVal = -1000, int maxVal = 1000)
        {
            int len = rng.Next(minLen, maxLen + 1);
            var a = new int[len];
            for (int i = 0; i < len; i++) a[i] = rng.Next(minVal, maxVal + 1);
            return a;
        }

        // Подставь сюда свой алгоритм из ЛР2
        private static int[] SortLab2(int[] a)
        {
            return CombSort.Sort(a);
        }

        private static void ClearTestDb(MySqlConnection conn)
        {
            using (var cmd = new MySqlCommand("DELETE FROM array_items;", conn)) cmd.ExecuteNonQuery();
            using (var cmd = new MySqlCommand("DELETE FROM arrays;", conn)) cmd.ExecuteNonQuery();
        }

        private static int InsertArray(MySqlConnection conn, MySqlTransaction tx, int userId, string role, int? sourceId, int length)
        {
            using var cmd = new MySqlCommand(@"
            INSERT INTO arrays(user_id, array_role, source_array_id, length)
            VALUES (@uid, @role, @src, @len);", conn, tx);

            cmd.Parameters.AddWithValue("@uid", userId);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@src", (object?)sourceId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@len", length);

            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        private static void InsertItems(MySqlConnection conn, MySqlTransaction tx, int arrayId, int[] values)
        {
            using var cmd = new MySqlCommand(@"
            INSERT INTO array_items(array_id, `position`, value)
            VALUES (@aid, @pos, @val);", conn, tx);

            cmd.Parameters.Add("@aid", MySqlDbType.Int32).Value = arrayId;
            var pPos = cmd.Parameters.Add("@pos", MySqlDbType.Int32);
            var pVal = cmd.Parameters.Add("@val", MySqlDbType.Int32);

            for (int i = 0; i < values.Length; i++)
            {
                pPos.Value = i;
                pVal.Value = values[i];
                cmd.ExecuteNonQuery();
            }
        }

        private static int[] GetRandomOriginalIds(MySqlConnection conn, int count = 100)
        {
            var ids = new List<int>(count);
            using var cmd = new MySqlCommand(@"
            SELECT array_id
            FROM arrays
            WHERE array_role = 'original'
            ORDER BY RAND()
            LIMIT @cnt;", conn);
            cmd.Parameters.AddWithValue("@cnt", count);

            using var r = cmd.ExecuteReader();
            while (r.Read()) ids.Add(r.GetInt32(0));
            return ids.ToArray();
        }

        private static int[] LoadArrayById(MySqlConnection conn, int arrayId)
        {
            var list = new List<int>();
            using var cmd = new MySqlCommand(@"
            SELECT value
            FROM array_items
            WHERE array_id = @id
            ORDER BY `position`;", conn);
            cmd.Parameters.AddWithValue("@id", arrayId);

            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(r.GetInt32(0));
            return list.ToArray();
        }

        // -------- tests --------

        [DataTestMethod]
        [DataRow(100)]
        [DataRow(1000)]
        [DataRow(10000)]
        public void Test_3_1_Insert(int n)
        {
            using var conn = new MySqlConnection(Cs);
            conn.Open();
            ClearTestDb(conn);

            bool success = true;
            var sw = Stopwatch.StartNew();

            try
            {
                var rng = new Random(12345);
                using var tx = conn.BeginTransaction();

                for (int i = 0; i < n; i++)
                {
                    var original = GenerateRandomArray(rng);
                    int arrayId = InsertArray(conn, tx, TestUserId, "original", null, original.Length);
                    InsertItems(conn, tx, arrayId, original);
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                success = false;
                TestContext.WriteLine(ex.ToString());
            }

            sw.Stop();
            TestContext.WriteLine($"[3.1 Insert {n}] success={success}, timeMs={sw.ElapsedMilliseconds}");

            Assert.IsTrue(success);
        }

        [DataTestMethod]
        [DataRow(100)]
        [DataRow(1000)]
        [DataRow(10000)]
        public void Test_3_2_LoadAndSort_100Random(int dbSize)
        {
            using var conn = new MySqlConnection(Cs);
            conn.Open();
            ClearTestDb(conn);

            // Наполняем базу до нужного размера
            FillDb(conn, dbSize);

            // Запуск 3 раза
            for (int run = 1; run <= 3; run++)
            {
                bool success = true;
                var swTotal = Stopwatch.StartNew();
                long sortMsSum = 0;

                try
                {
                    var ids = GetRandomOriginalIds(conn, 100);

                    var swSort = new Stopwatch();
                    foreach (var id in ids)
                    {
                        var arr = LoadArrayById(conn, id);

                        swSort.Restart();
                        _ = SortLab2(arr);
                        swSort.Stop();

                        sortMsSum += swSort.ElapsedMilliseconds;
                    }
                }
                catch (Exception ex)
                {
                    success = false;
                    TestContext.WriteLine(ex.ToString());
                }

                swTotal.Stop();
                double avgSort = sortMsSum / 100.0;

                TestContext.WriteLine($"[3.2 DB={dbSize} run={run}] success={success}, totalMs={swTotal.ElapsedMilliseconds}, avgSortMs={avgSort:F3}");
                Assert.IsTrue(success);
            }
        }

        [DataTestMethod]
        [DataRow(100)]
        [DataRow(1000)]
        [DataRow(10000)]
        public void Test_3_3_ClearDb(int dbSize)
        {
            try
            {
                using var conn = new MySqlConnection(Cs);
                conn.Open();
                ClearTestDb(conn);

                FillDb(conn, dbSize);

                for (int run = 1; run <= 3; run++)
                {
                    bool success = true;
                    var sw = Stopwatch.StartNew();

                    try
                    {
                        ClearTestDb(conn);
                    }
                    catch (Exception ex)
                    {
                        success = false;
                        TestContext.WriteLine(ex.ToString());
                    }

                    sw.Stop();
                    TestContext.WriteLine($"[3.3 Clear DB={dbSize} run={run}] success={success}, timeMs={sw.ElapsedMilliseconds}");
                    Assert.IsTrue(success);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString()); // <-- тест упадёт и покажет точную причину
            }
        }

        private void FillDb(MySqlConnection conn, int n)
        {
            var rng = new Random(777);
            using var tx = conn.BeginTransaction();

            for (int i = 0; i < n; i++)
            {
                var original = GenerateRandomArray(rng);
                var sorted = SortLab2(original);

                int origId = InsertArray(conn, tx, TestUserId, "original", null, original.Length);
                InsertItems(conn, tx, origId, original);

                int sortId = InsertArray(conn, tx, TestUserId, "sorted", origId, sorted.Length);
                InsertItems(conn, tx, sortId, sorted);
            }

            tx.Commit();
        }
    }
}
