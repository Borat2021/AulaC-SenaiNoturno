using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace OiMundo
{
    public partial class Form1 : Form
    {
        //Declarando a variável
        string mensagem = "BEM VINDO AO BANCO SENAI!";
        int idadeWillyam = 24;
        int idadeWenio = 19;
        int idadeKywter = 16;
        double mediadosfilhos;
        int numeroConta = 1;
        double saldo = 0.00;
        double valorDoSaque = 10.00;
        double valorRestante;
        int a = 1, b = -5, c = 6;
        double delta=3.5, a1=1.5, a2=2.3;


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(mensagem);


        }
        

        private void button1_Click(object sender, EventArgs e)
        {
          mediadosfilhos = (idadeWillyam + idadeWenio + idadeKywter) / 3;
            if (saldo >= valorDoSaque)
            {
                valorRestante = saldo - valorDoSaque;
                MessageBox.Show("Saque Realizado Com Sucesso");
                MessageBox.Show("O seu saldo era de " +saldo+ " Reais. \n Foi retido o valor de " +valorDoSaque + " Reais. \n Você ficou com o saldo agora de " +valorRestante+ " Reais." );
            }            
            else
            {
                MessageBox.Show("Saldo Insuficiente, seu saldo é de "+ saldo+ " Reais");
            }

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a); 
            MessageBox.Show("As idades dos filhos do Wênder é:\n "+" Willyam tem " + idadeWillyam+ " anos,\n Wenio tem " + idadeWenio + " anos, \n Kywter tem " +idadeKywter + " anos.");
            MessageBox.Show("A média dos filhos do Wênder é " + mediadosfilhos + " anos.");            
            MessageBox.Show("a1 = " + a1);
            MessageBox.Show("a2 = " + a2);
            MessageBox.Show("Final");
        }
    }
}