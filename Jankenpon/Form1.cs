using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jankenpon
{
    public partial class Form1 : Form
    {
        enum jogada { Pedra, Papel, Tesoura };
        enum resultado { Jogador, CPU, Empate };
        jogada jogador = new jogada();
        jogada cpu = new jogada();
        Random rdm = new Random();
        resultado ganhador = new resultado();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            jogador = jogada.Pedra;
            EscolhaJogador();
            EscolhaCPU();
            VerificarGanhador();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogador = jogada.Papel;
            EscolhaJogador();
            EscolhaCPU();
            VerificarGanhador();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            jogador = jogada.Tesoura;
            EscolhaJogador();
            EscolhaCPU();
            VerificarGanhador();
        }

        void EscolhaJogador()
        {
            switch (jogador)
            {
                case jogada.Pedra:
                    pbEscolhaJogador.BackgroundImage = Image.FromFile("F:/Pedra.png");
                    break;
                case jogada.Papel:
                    pbEscolhaJogador.BackgroundImage = Image.FromFile("F:/Papel.png");
                    break;
                case jogada.Tesoura:
                    pbEscolhaJogador.BackgroundImage = Image.FromFile("F:/Tesoura.png");
                    break;
            }
        }

        void EscolhaCPU()
        {
            int escolha = rdm.Next(1, 4);
            if (escolha == 1)
            {
                cpu = jogada.Pedra;
                pbCPU.BackgroundImage = Image.FromFile("F:/Pedra.png");
            }
            else if (escolha == 2)
            {
                cpu = jogada.Papel;
                pbCPU.BackgroundImage = Image.FromFile("F:/Papel.png");
            }
            else if (escolha == 3)
            {
                cpu = jogada.Tesoura;
                pbCPU.BackgroundImage = Image.FromFile("F:/Tesoura.Png");
            }
        }

        void VerificarGanhador()
        {
            switch(jogador)
            {
                case jogada.Pedra:
                    if (cpu == jogada.Pedra)
                        ganhador = resultado.Empate;
                    else if (cpu == jogada.Papel)
                        ganhador = resultado.CPU;
                    else if (cpu == jogada.Tesoura)
                        ganhador = resultado.Jogador;
                    break;

                case jogada.Papel:
                    if (cpu == jogada.Pedra)
                        ganhador = resultado.Jogador;
                    else if (cpu == jogada.Papel)
                        ganhador = resultado.Empate;
                    else if (cpu == jogada.Tesoura)
                        ganhador = resultado.CPU;
                    break;

                case jogada.Tesoura:
                    if (cpu == jogada.Pedra)
                        ganhador = resultado.CPU;
                    else if (cpu == jogada.Papel)
                        ganhador = resultado.Jogador;
                    else if (cpu == jogada.Tesoura)
                        ganhador = resultado.Empate;
                    break;
            }
            if (ganhador == resultado.Jogador)
            {
                gbPlacar.BackColor = Color.DarkOliveGreen;
                lblPlacarJogador.Text = (int.Parse(lblPlacarJogador.Text) + 1).ToString();
            }
            else if (ganhador == resultado.CPU)
            {
                gbPlacar.BackColor = Color.IndianRed;
                lblPlacarCPU.Text = (int.Parse(lblPlacarCPU.Text) + 1).ToString();
            }
            else
            {
                gbPlacar.BackColor = Color.Transparent;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblPlacarJogador.Text = "0";
            lblPlacarCPU.Text  = "0";
        }
    }
}