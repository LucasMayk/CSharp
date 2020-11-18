using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgente.Extensoes
{
    public static class ListExtensoes
    {
        //Método Genérico <T>
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
