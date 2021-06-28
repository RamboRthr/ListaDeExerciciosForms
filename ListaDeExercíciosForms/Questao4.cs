using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaDeExercíciosForms
{
    public partial class Questao4 : Form
    {

        public Questao4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text.ToString() != "0" )
            {
                listBox1.Items.Add(maskedTextBox2.Text);

            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = int.Parse(listBox1.SelectedItem.ToString());
            int fatorial = 1;
            for (int i = 1; i <= selectedItem; i++)
            {
                fatorial *= i;
            }

            txtResultado.Text = fatorial.ToString();
        
        
        
        }
    }
}
