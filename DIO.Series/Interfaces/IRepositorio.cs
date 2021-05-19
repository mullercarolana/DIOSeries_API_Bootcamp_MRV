using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<R>
    {
        List<R> Lista();
        R RetornaPorId(int id);
        void Insere(R entidade);
        void Exclui(int id);
        void Atualiza(int id, R entidade);
        int ProximoId();
    }
}
