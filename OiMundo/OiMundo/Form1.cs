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
        
        
        public Form1()
        {
            InitializeComponent();
            mediadosfilhos = (idadeWillyam + idadeWenio + idadeKywter)/3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mensagem);
            MessageBox.Show(" Willyam tem " + idadeWillyam+ " anos,\n Wenio tem " + idadeWenio + " anos, \n Kywter tem " +idadeKywter + " anos.");
            MessageBox.Show("A média dos filhos do Wênder é " + mediadosfilhos + " anos.");
            MessageBox.Show("Olá Mundo");
        }
    }
}