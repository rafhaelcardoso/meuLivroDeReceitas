using Dapper;
using MySqlConnector;

namespace MeuLivroDeReceitas.Infrastructure.Migrations;

public class Database
{
    public static void CriarDb(string conexaoDb, string nomeDb)
    {
        using var con = new MySqlConnection(conexaoDb);

        var parametros = new DynamicParameters();
        parametros.Add("nome", nomeDb);

        var reg = con.Query("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @nome", parametros);

        if (!reg.Any())
        {
            con.Execute($"CREATE DATABASE {nomeDb}");
        }
    }
}
