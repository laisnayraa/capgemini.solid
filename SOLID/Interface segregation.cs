interface ICadastroCliente
{
    void ValidarDados();
    void PersistirBanco();
    void MandarEmail();
}

class Cliente : ICadastroCliente
{
    public void ValidarDados() { }
    public void PersistirBanco() { }
    public void MandarEmail() { }
}