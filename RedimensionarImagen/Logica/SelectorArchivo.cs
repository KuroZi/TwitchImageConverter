using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RedimensionarImagen.Logica
{
    public class SelectorArchivo
    {
        private List<String> listaArchivos = new List<String>();

        // Selecciona todas las imágenes que se convertirán
        public void Seleccionar()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Archivo de Imagen |*.png;*.jpg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listaArchivos.AddRange(ofd.FileNames);
            }
        }

        // Retorna la ruta de las imágenes a convertir
        public List<String> RetornarLista()
        {
            return listaArchivos;
        }

        // Limpia la lista
        public void LimpiarLista()
        {
            listaArchivos.Clear();
        }

        // Comprueba si hay rutas en la lista
        public bool EstaVacio()
        {
            if (listaArchivos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
