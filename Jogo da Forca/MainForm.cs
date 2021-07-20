using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_da_Forca
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		int contErros = 0;
		Random rnd = new Random();
		
		void Button1Click(object sender, EventArgs e)
		{
			//Botão Esconder
			textBox1.Visible = false;
			string aux = "";
			
			foreach (char letra in textBox1.Text)
			{
				aux += "?";
			}
			
			label1.Text = aux;
			
			button1.Visible = false;
			button2.Visible = false;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			char letraChutada = (sender as Button).Text[0];
			string palavra = textBox1.Text;
			int cont = 0;
			string aux = "";
			int i = 0;
			
			foreach (char letra in palavra)
			{
				if ( letraChutada == letra)
                {
                    cont++;
                    aux += letraChutada;
                }
                else
                {
                	aux += label1.Text[i];
                }i++;
			}
			
			if (cont != 0)
			{//Acertou
				MessageBox.Show("A letra aparece na palavra "+ cont +" vezes!");
				label1.Text = aux;
				 (sender as Button).Enabled = false;
                 (sender as Button).BackColor = Color.Green;
			}
			else
			{//Errou
				MessageBox.Show("A letra não aparece na palavra");
				contErros++;
				pictureBox1.Load("Forca" + contErros + ".jpg");
				(sender as Button).Enabled = false;
                (sender as Button).BackColor = Color.Red;
			}
			
			if(contErros == 7)
			{
				panel1.Enabled = false;
				MessageBox.Show("Que pena, você perdeu! :(");
			}
			
			if(aux == palavra)
			{
				panel1.Enabled = false;
				MessageBox.Show("Parabéns, você ganhou! :)");
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			richTextBox1.Visible = false;
			try //Tentar
			{
				//Tenta abrir o arquivo
				richTextBox1.LoadFile("animais.txt", RichTextBoxStreamType.PlainText);
			}
			catch //Caso haja algum erro
			{
				
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//Pegar uma palavra ao acaso
			int linha = rnd.Next(0,richTextBox1.Lines.Length-1);
			label1.Text = richTextBox1.Lines[linha];
			textBox1.Text = label1.Text;
			textBox1.Visible = false;
			string aux = "";
			
			foreach (char letra in textBox1.Text)
			{
				aux += "?";
			}
			
			label1.Text = aux;
			
			button2.Visible = false;
			button1.Visible = false;
		}
		
		void Button29Click(object sender, EventArgs e)
		{//Botão Reiniciar
			Button[] botoes = {button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28};
			foreach (Button botao in botoes)
			{
				botao.BackColor = Color.LightGray;
				botao.Enabled = true;
			}
			pictureBox1.Load("Forca0.jpg");
			contErros = 0;
			textBox1.Visible = true;
			button1.Visible = true;
			button2.Visible = true;
			textBox1.Text = "";
			panel1.Enabled = true;
		}
	}
}