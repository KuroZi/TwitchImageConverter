using System;
using System.Windows.Forms;

namespace RedimensionarImagen.Logica
{
    public class SelectorCarpeta
    {
        private String rutaFinal = String.Empty;

        // Selecciona la carpeta en donde se guardarán las imágenes convertidas
        public void Seleccionar()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaFinal = fbd.SelectedPath;
            }
        }

        // Retorna la carpeta seleccionada
        public String RetornaCarpeta()
        {
            return rutaFinal;
        }

        // Comprueba si se seleccionó la ruta final donde se guardarán las imágenes
        public bool EstaVacio()
        {
            if (String.IsNullOrWhiteSpace(rutaFinal))
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
