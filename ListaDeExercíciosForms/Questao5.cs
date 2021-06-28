using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaDeExercíciosForms
{
    public partial class Questao5 : Form
    {
        public Questao5()
        {
            InitializeComponent();
        }
        int contadorX = 0, contadorY = 0;



        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (contadorX == 0)
            {
                int[] vetorX = new int[5];
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" && contadorX < 5)
            {
                listBox1.Items.Add(maskedTextBox1.Text);
            }
            
            
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            int[] vetorY = new int[5];
        }


    }
}
