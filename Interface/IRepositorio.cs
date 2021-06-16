using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    interface iRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exlui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId(); 
    }
}
