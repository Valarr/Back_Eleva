using System;
using Npgsql;
using ElevaTest.Infra;

NpgsqlConnection.GlobalTypeMapper.UseJsonNet();
namespace ElevaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateHelper.GeraSchema();
            Console.Read();

        }

        private static void InsertRecord()
        {
            using (NpgsqlConnection con = GetNpgsqlConnection())
            {
                string query = @"insert into public.escolas(nome_Escola,telefone,endereco)values('godofredo','987428922','Avenida estados unidos, numero 274, Jardim das nacoes taubate sp')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("inseriu");
                }
            }
        }
        private static void SelectRecordByID(int entrada, string[][] test)
        {
            using (NpgsqlConnection con = GetNpgsqlConnection())
            {
                string query = @"select * from public.escolas";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                NpgsqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    Console.Write("{0}\t{1}\t{2}\t{3} \n", data[0], data[1], data[2], data[3]);
                }
                NpgsqlConnection.GlobalTypeMapper.UseJsonNet(new[] { typeof(Array) });
                con.Close();
            }

        }

        private static void TestConnection()
        {
            using (NpgsqlConnection con = GetNpgsqlConnection())
            {
                Console.WriteLine(con.ConnectionString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("conecto");
                }
            }
        }

        private static NpgsqlConnection GetNpgsqlConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=123;database=postgres;");
        }
    }
}
