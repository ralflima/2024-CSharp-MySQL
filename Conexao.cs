// Importar o MySql.Data.MySqlClient
using MySql.Data.MySqlClient;

public class Conexao
{
    // String de conexão utilizada para estabelecer a comunicação com o banco de dados MySQL
    private readonly string _stringDeConexao;

    // Define suas credenciais e parâmetros de conexão aqui
    private const string _servidor = "localhost";
    private const string _base = "base";
    private const string _usuario = "root";
    private const string _senha = "12345678";

    // Método construtor
    public Conexao()
    {
        _stringDeConexao = $"Server={_servidor};Database={_base};User ID={_usuario};Password={_senha};";
    }

    // Método para retornar a string de conexão
    public string ObterStringDeConexao()
    {
        return _stringDeConexao;
    }

    // Método para testar a conexão
    public void TestarConexao()
    {
        // Tentativa para efetuar a conexão com o banco MySQL
        try
        {
            using (var connection = new MySqlConnection(_stringDeConexao))
            {
                connection.Open();
                Console.WriteLine("Conexão efetuada com sucesso!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Falha ao conectar: " + ex.Message);
        }
    }
}
