using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> ListarSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            ListarSerie[id] = objeto;
        }

        public void Exlui(int id)
        {
            ListarSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            ListarSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListarSerie;
        }

        public int ProximoId()
        {
            return ListarSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListarSerie[id];
        }
    }
}
