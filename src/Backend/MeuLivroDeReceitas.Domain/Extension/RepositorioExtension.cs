using Microsoft.Extensions.Configuration;

namespace MeuLivroDeReceitas.Domain.Extension;

public static class RepositorioExtension
{
    public static string GetConexao(this IConfiguration configurationManager)
    {
        var con = configurationManager.GetConnectionString("Conexao");
        return con;
    }

    public static string GetDatabase(this IConfiguration configurationManager)
    {
        var db = configurationManager.GetConnectionString("NomeDatabase");
        return db;
    }
}
