using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace RedimensionarImagen.Modelos
{
    public class CambiarTamaño
    {
        private List<String> listaImagenes = new List<String>();

        // Establecemos la lista con la ruta de las imágenes
        public void SetListaImagenes(List<String> listaImagenes)
        {
            this.listaImagenes = listaImagenes;
        }

        // Llamamos al método que convertirá las imágenes
        public void Redimensionar(String rutaFinal, int tipo)
        {
            foreach (String rutaInicial in listaImagenes)
            {
                SetTamaño(rutaInicial, rutaFinal, tipo);
            }
        }

        // Método encargado de convertir la imagen
        private void SetTamaño(String rutaInicial, String rutaFinal, int tipoTamaño)
        {
            List<int> tipo = new Tamaño().GetDimensiones(tipoTamaño);

            foreach (int tamaño in tipo)
            {
                Rectangle destRect = new Rectangle(0, 0, tamaño, tamaño);

                Image imagenOriginal = Image.FromFile(rutaInicial);

                Bitmap imagenFinal = new Bitmap(tamaño, tamaño);

                imagenFinal.SetResolution(imagenOriginal.HorizontalResolution, imagenOriginal.VerticalResolution);

                using (var graphics = Graphics.FromImage(imagenFinal))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(imagenOriginal, destRect, 0, 0, imagenOriginal.Width, imagenOriginal.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

                imagenFinal.Save(rutaFinal + "\\" + Path.GetFileName(rutaInicial) + "-" + tamaño + "x" + tamaño + ".png", ImageFormat.Png);
            }
        }


    }
}
