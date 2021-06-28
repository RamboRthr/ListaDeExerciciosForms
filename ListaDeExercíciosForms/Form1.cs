using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeExercíciosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Questao1 questao1 = new Questao1();
        Questão_2 questao2 = new Questão_2();
        Questao3 questao3 = new Questao3();
        Questao4 questao4 = new Questao4();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (selectQuestao.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma questão.");
            }
            else if (selectQuestao.SelectedItem.ToString() == "Questão 1")
            {
                questao1.Show();

            }
            else if (selectQuestao.SelectedItem.ToString() == "Questão 2")
            {
                questao2.Show();

            }
            else if (selectQuestao.SelectedItem.ToString() == "Questão 3")
            {
                questao3.Show();

            }
            else if (selectQuestao.SelectedItem.ToString() == "Questão 4")
            {
                questao4.Show();

            }

        }
    }
}
