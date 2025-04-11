using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Thiago_Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "nomes.txt";

            // Se quiser chamar AdicionarNome como método estático:
            Class1.AdicionarNome(caminhoArquivo);

            // Criar a instância para chamar o método não estático
            Class1 minhaClasse = new Class1();
            minhaClasse.ListarNomes(caminhoArquivo);
        }
    }
{
    public class Class1
    {

        static void AdicionarNome(string caminhoArquivo)
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a data : ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            // Adiciona o nome no arquivo (modo append)
            File.AppendAllText(caminhoArquivo, nome + ";" + date.ToString("dd/MM/yyyy") + Environment.NewLine);

            Console.WriteLine("Nome e data salvos com sucesso!");
        }

        public void ListarNomes(string caminhoArquivo)
        {
            Console.WriteLine("\n--- Lista de nomes persistidos ---");

            if (File.Exists(caminhoArquivo))
            {
                string[] arquivo = File.ReadAllLines(caminhoArquivo);

                foreach (string nome in arquivo)
                {
                    Console.WriteLine("- " + nome);
                }
            }
            else
            {
                Console.WriteLine("Nenhum nome foi salvo ainda.");
            }
        }

    }
}
