using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO
{
    class Program
    {
        static void Main(string[] args) //método que executa o programa
        {
            Console.WriteLine("Digite o nome do aluno:"); //Exibe mensagem pedindo o nome do aluno
            string nome = Console.ReadLine(); //Lê o nome digitado e armazena a variável "nome"

            Console.WriteLine("Digite a primeira nota:"); //Exibe mensagem pedindo a primeira nota
            double nota1 = double.Parse(// lê a primeira nota como texto e converte em double ("ponto" como separador inicial)
                Console.ReadLine(),
                CultureInfo.InvariantCulture //comando para garantir o separador decimal 
            );

            Console.WriteLine("Digite a segunda nota:");//idem
            double nota2 = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture
            );

                //Próximo passo: construir a classe aluno
            Aluno aluno = new Aluno(nome, nota1, nota2);

           aluno.ExibirResultado();
        }
    }
}
