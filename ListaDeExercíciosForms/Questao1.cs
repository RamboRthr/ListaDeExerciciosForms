using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaDeExercíciosForms
{
    public partial class Questao1 : Form
    {
        public Questao1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomePeca.Text != "" && txtQtdMinima.Text != "" && txtQtdMaxima.Text!= "")
            {
                int qtdMinima = int.Parse(txtQtdMinima.Text.ToString());
                int qtdMaxima = int.Parse(txtQtdMaxima.Text.ToString());
                txtResultado.Text = $"Quantidade média da peça [{txtNomePeca.Text}]: {((qtdMinima + qtdMaxima) / 2).ToString()} unidades";
            }
        }
    }
}
