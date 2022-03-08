using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pegarCtrlVToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void acercarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "SIN TITULO.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using(var guardar_arc = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_arc.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void nuevoCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrilCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            a = archivo.ReadLine();
            richTextBox1.Text = a.ToString();



        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void desacerCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelanteCtrlYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
           richTextBox1.Paste();

        }

        private void copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

        }

        private void eliminarTodoCtrlAltXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formato1 = fontDialog1.ShowDialog();
            if (formato1 == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var color1 = colorDialog1.ShowDialog();
            if (color1 == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }

        }
    }
}
