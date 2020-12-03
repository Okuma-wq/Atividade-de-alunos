using System;
using Atividade_de_alunos.Classes;

namespace Atividade_de_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Aluno aluno1 = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.Write("Digite o nome do curso: ");
            aluno1.curso = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o RG do aluno: ");
            aluno1.rg = Console.ReadLine();

            Console.Write("O aluno é bolsista? (S/N) ");
            string resposta = Console.ReadLine();

            if(resposta.ToLower() == "s" ){
                  aluno1.bolsista = true;
            }else if(resposta.ToLower() == "n"){
                    aluno1.bolsista = false;
            }

            Console.WriteLine("Insira a média do aluno: ");
            aluno1.mediaFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da mensalidade: ");
            aluno1.mensalidade = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.curso);
            Console.WriteLine(aluno1.idade);
            Console.WriteLine(aluno1.rg);
            Console.WriteLine(aluno1.bolsista);
            // Console.WriteLine(aluno1.mediaFinal);
            // Console.WriteLine(aluno1.mensalidade);

            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.verMensalidade(aluno1.bolsista, aluno1.mensalidade);
        }
    }
}
