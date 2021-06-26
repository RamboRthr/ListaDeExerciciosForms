using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaDeExercíciosForms
{
    public partial class Questão_2 : Form
    {
        public Questão_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double autonomiaCarro = double.Parse(txtAutonomia.Text.ToString());
            double tempo = double.Parse(txtTempo.Text.ToString());
            double velMedia = double.Parse(txtVelMedia.Text.ToString());
            double distancia = velMedia * tempo;
            double qtdLitros = distancia / autonomiaCarro;

            txtResultado.Text = $"Em {tempo} horas, à velocidade de {velMedia} km/h, " +
                                $"você percorreu {distancia} quilômetrose " + 
                                $"gastou {Math.Round(qtdLitros, 2)} litros de gasolina.";

        }
    }
}
