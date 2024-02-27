public interface IRepository
{
    void Inserir(Funcionario funcionario);
    void Remover(int id);
    List<Funcionario> ListarTodosOsFuncionarios();
}