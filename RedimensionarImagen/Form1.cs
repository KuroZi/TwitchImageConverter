using RedimensionarImagen.Logica;
using RedimensionarImagen.Modelos;
using System;
using System.Windows.Forms;

namespace RedimensionarImagen
{
    public partial class Form1 : Form
    {
        private SelectorArchivo sa = new SelectorArchivo();
        private SelectorCarpeta sc = new SelectorCarpeta();
        private CambiarTamaño ct = new CambiarTamaño();

        public Form1()
        {
            InitializeComponent();
            cBoxTamaños.DataSource = new Tamaño().GetNombres();
        }

        private void btnImagenInicial_Click(object sender, EventArgs e)
        {
            sa.Seleccionar();
            listBox.Items.AddRange(sa.RetornarLista().ToArray());
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            sa.LimpiarLista();
            listBox.Items.Clear();
        }

        private void btnRutaFinal_Click(object sender, EventArgs e)
        {
            sc.Seleccionar();
            txtRutaFinal.Text = sc.RetornaCarpeta();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (sa.EstaVacio())
            {
                MessageBox.Show("Necesitas elegir las imágenes que quieras convertir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (sc.EstaVacio())
                {
                    MessageBox.Show("Necesitas elegir dónde se alojarán las imágenes convertidas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ct.SetListaImagenes(sa.RetornarLista());
                    ct.Redimensionar(sc.RetornaCarpeta(), cBoxTamaños.SelectedIndex);
                }
            }
        }
    }
}
