using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stm;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((stm = ofd.OpenFile()) != null)
                {
                    string str = ofd.FileName;
                    string ftxt = File.ReadAllText(str);
                    richTextBox1.Text = ftxt;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //guardar archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "archivo de texto(*.txt)|*.txt|archivo de C#(*.cs)|*.cs";
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName, richTextBox1.Text);
            MessageBox.Show("archivo de texto guardado exitozamente");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
