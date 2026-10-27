namespace Projeto_P2
{
    public partial class Form1 : Form
    {
        // Lista para guardar os alunos em memória
        private List<Aluno> listaAlunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
            // Liga o evento de tecla diretamente por código (ignora o painel de propriedades)
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
                            // Pede o nome do aluno interativamente
                            string nomeAluno = Microsoft.VisualBasic.Interaction.InputBox("Insira o nome do aluno:", "Registar Aluno", "");

                            if (!string.IsNullOrWhiteSpace(nomeAluno))
                            {
                                // Pede a matrícula do aluno interativamente
                                string matriculaAluno = Microsoft.VisualBasic.Interaction.InputBox("Insira a matrícula do aluno:", "Registar Aluno", "");

                                if (!string.IsNullOrWhiteSpace(matriculaAluno))
                                {
                                    Aluno novoAluno = new Aluno();
                                    novoAluno.Nome = nomeAluno;
                                    novoAluno.Matricula = matriculaAluno;
                                    listaAlunos.Add(novoAluno);

                                    MessageBox.Show("Aluno registado com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Matrícula inválida. Registo cancelado.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nome inválido. Registo cancelado.");
                            }
                            break;

                        case 2:
                            // Exibir Lista de Alunos
                            if (listaAlunos.Count == 0)
                            {
                                MessageBox.Show("Não há alunos cadastrados.");
                            }
                            else
                            {
                                string mensagem = "Lista de Alunos:\n";
                                foreach (var aluno in listaAlunos)
                                {
                                    mensagem += $"- {aluno.Nome} (Matrícula: {aluno.Matricula})\n";
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
                            // Ir para a Seção de Professores (Form2)
                            Form2 telaProfessores = new Form2();
                            telaProfessores.Show();
                            this.Hide(); // Oculta o formulário de alunos atual
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
 
