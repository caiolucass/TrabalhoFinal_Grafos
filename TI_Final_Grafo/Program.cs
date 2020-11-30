using System;
using System.IO;

/**
  * @autor: Caio Lucas F. dos Santos
  *@autor: Wernen Rodrigues Maciel
  */
namespace TI_Final_Grafos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] leitor = File.ReadAllLines("Dados.txt"); // não precisa digitar o caminho do arquivo
            int opcao = 1;
            Grafo grafo = new Grafo();

            //ira ler todas as linhas
            foreach (string arq in leitor)
            {
                string[] split = arq.Split(';');
                Professor professor;
                Disciplina disciplina;
                Horario horario;
                Vertice vertice;

                vertice = new Vertice();
                disciplina = new Disciplina(split[0]);
                professor = new Professor(split[1]);
                horario = new Horario(Convert.ToInt32(split[2]));

                grafo.add_Professor(professor, disciplina);
                grafo.add_Horario(horario, disciplina);
                //grafo.procurar_Vertice(vertice);
                grafo.add_Aresta(professor, disciplina, horario);
                //grafo.add_Disciplina(disciplina);
                grafo.imprimir_MatrizDissimilaridade();
            }
            do
            {
                menu();
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Vertice vertice;
                vertice = new Vertice();
                switch (opcao)
                {
                    case 1:
                        grafo.procurar_Vertice(vertice);
                        Console.ReadKey();
                        break;
                }
            }
            while (opcao != 0);       
        }

        //Menu de opções
        static void menu()
        {      
                Console.WriteLine("Caio Lucas F. dos Santos \nWernen Rodrigues Maciel");
                Console.WriteLine("Menu");
                Console.WriteLine(" 0 - Sair.");
            //Console.WriteLine(" 1 - Procurar vértice.");
        }
    }
}