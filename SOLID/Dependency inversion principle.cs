using System;
using System.Data.SqlClient;

public class Usuario
{
    internal bool IsValid()
    {
        throw new NotImplementedException();
    }
}
public interface IUsuarioRepository
{
    bool Adicionar(Usuario usuario);
}

public class UsuarioRepository : IUsuarioRepository
{
    public object Id { get; private set; }
    public object Nome { get; private set; }
    public object Email { get; private set; }
    public object CPF { get; private set; }

    public bool Adicionar(Usuario usuario)
    {
        try
        {
            using (var connection = new SqlConnection())
            {
                var command = new SqlCommand();

                connection.ConnectionString = "Local";
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $"INSERT INTO USUARIO (ID, NOME, EMAIL, CPF) VALUES (@id, @nome, @email, @cpf)";

                command.Parameters.AddWithValue("id", Id);
                command.Parameters.AddWithValue("nome", Nome);
                command.Parameters.AddWithValue("email", Email);
                command.Parameters.AddWithValue("cpf", CPF);

                connection.Open();
                command.ExecuteNonQuery();
            }

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

public interface IService<T> where T : class
{
    bool Inserir(T entity);
}

public class UsuarioService : IService<Usuario>
{
    private IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public bool Inserir(Usuario usuario)
    {
        if (usuario.IsValid())
            return false;

        _usuarioRepository.Adicionar(usuario);
        return true;
    }
}