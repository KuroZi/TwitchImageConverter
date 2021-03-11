using System;
using System.Collections.Generic;
using System.Linq;

namespace RedimensionarImagen.Modelos
{
    public class Tamaño
    {
        private readonly Dictionary<String, List<int>> tamaños = new Dictionary<String, List<int>>()
        {
            { "Emblema de Fidelidad", new List<int>() { 72, 36, 18} },
            { "Emoticono para Sub/Bits", new List<int>() { 112, 56, 28 } },
            { "Punto del Canal", new List<int>() { 112, 56, 28 } }
        };

        public List<String> GetNombres()
        {
            return tamaños.Keys.ToList();
        }

        public List<int> GetDimensiones(int tipo)
        {
            return tamaños.Values.ToList()[tipo];
        }
    }
}
