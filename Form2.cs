using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_P2
{
    public partial class Form2 : Form
    {
            // Lista para armazenar os professores cadastrados em memória
            private List<Professor> listaProfessores = new List<Professor>();
            public Form2()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
        }

        private void textBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi o Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de "beep" padrão do Windows
                e.SuppressKeyPress = true;

                // Tenta converter o texto digitado num número inteiro
                if (int.TryParse(textBox1.Text, out int opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            // Pede o nome do professor interativamente
                            string nomeProf = Microsoft.VisualBasic.Interaction.InputBox("Insira o nome do professor:", "Registar Professor", "");

                            if (!string.IsNullOrWhiteSpace(nomeProf))
                            {
                                // Pede o registo do professor interativamente
                                string registroProf = Microsoft.VisualBasic.Interaction.InputBox("Insira o registo do professor:", "Registar Professor", "");

                                if (!string.IsNullOrWhiteSpace(registroProf))
                                {
                                    Professor novoProfessor = new Professor();
                                    novoProfessor.Nome = nomeProf;
                                    novoProfessor.Registro = registroProf;
                                    listaProfessores.Add(novoProfessor);

                                    MessageBox.Show("Professor registado com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Registo inválido. Registo cancelado.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nome inválido. Registo cancelado.");
                            }
                            break;

                        case 2:
                            // Exibir Lista de Professores
                            if (listaProfessores.Count == 0)
                            {
                                MessageBox.Show("Não há professores cadastrados.");
                            }
                            else
                            {
                                string mensagem = "Lista de Professores:\n";
                                foreach (var prof in listaProfessores)
                                {
                                    mensagem += $"- {prof.Nome} (Registro: {prof.Registro})\n";
                                }
                                MessageBox.Show(mensagem);
                            }
                            break;

                        case 3:
                            MessageBox.Show("Funcionalidade de Alterar Cadastro em desenvolvimento.");
                            break;

                        case 4:
                            MessageBox.Show("Funcionalidade de Remover Cadastro em desenvolvimento.");
                            break;

                        case 5:
                            // Voltar para a Seção de Alunos (Form1)
                            Form1 telaAlunos = new Form1();
                            telaAlunos.Show();
                            this.Close(); // Fecha o formulário de professores atual
                            break;

                        case 6:
                            // Sair do Programa
                            Application.Exit();
                            break;

                        default:
                            MessageBox.Show("Opção inválida! Escolha um número de 1 a 6.");
                            break;
                    }

                    // Limpa a caixa de texto para a próxima escolha
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, digite apenas números válidos.");
                }
            }
        }
    }
}