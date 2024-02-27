
using System.Security.Cryptography.X509Certificates;

public class RepositorioFuncionarios(List<Funcionario> repositorio) : IRepository
{
    List<Funcionario> _repositorio = repositorio;

    public void Inserir(Funcionario funcionario)
    {
        _repositorio.Add(funcionario);
    }

    public List<Funcionario> ListarTodosOsFuncionarios()
    {
        return _repositorio;
    }

    public void Remover(int id)
    {
        foreach (var item in _repositorio)
        {
            if (item.Id == id)
            {
                _repositorio.Remove(item);
                return;
            }
        }
    }

    internal void Remover(Analista analista)
    {
        throw new NotImplementedException();
    }
}