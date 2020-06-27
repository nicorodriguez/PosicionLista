using System;
using System.Collections.Generic;
using System.Text;

namespace PosicionLista
{
    public static class WordExtensions
    {
        public static int EncontrarPosicionEnLista(this List<string> lista, string buscar)
        {
            int i = 0;
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i] == buscar) { break; }
            }
            return i - lista.Count;
        }
    }
}
