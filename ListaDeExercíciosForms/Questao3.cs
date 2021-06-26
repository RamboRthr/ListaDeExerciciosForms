using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaDeExercíciosForms
{
    public partial class Questao3 : Form
    {
        public Questao3()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double alturaBarril = double.Parse(txtAltura.Text.ToString());
            double raioBarril = double.Parse(txtRaio.Text.ToString());
            double volumeBarril = Math.Round(alturaBarril * (Math.Pow(raioBarril, 2) * Math.PI));
            
            txtResultado.Text = $"O volume do barril é de {volumeBarril} litros.";


        }
    }
}
