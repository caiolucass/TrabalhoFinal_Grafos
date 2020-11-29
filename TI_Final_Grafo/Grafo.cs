using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
  * @autor: Caio Lucas F. dos Santos
  *@autor: Wernen Rodrigues Maciel
  */
namespace TI_Final_Grafos
{
    class Grafo
    {
        public List<Professor> professor = new List<Professor>(); //iniciar lista de professores
        public List<Horario> horario = new List<Horario>(); //iniciar lista de horario
        public List<Aresta> arestas = new List<Aresta>(); //inicar lista de arestas
        public List<Disciplina> disciplina = new List<Disciplina>(); //inicar lista de disciplina
        public List<Vertice> list_vertices = new List<Vertice>(); //inicar lista vertices
        private int[,] matriz_dissimilaridade =  new int[10,10]; //matriz dissimilariade
        public int numero_Vertice; //numero de vertices do grafo


        //Construtor
        public Grafo()
        {
        }

        //Método para adicionar aresta
        public void add_Aresta(Professor professorp, Disciplina disciplinad, Horario horarioh)
        {
            Aresta aresta = new Aresta(professorp, disciplinad, horarioh);
            arestas.Add(aresta);
        }

        //Método para adicionar vértice de professor
        public void add_Professor(Professor professorp)
        {
            var prof_aux = new Professor(professorp.get_Nome(),professorp.get_Disciplina() );

            //verificar se disciplina contem disciplina registrada
            if (professor.Contains(prof_aux))
            {
                professor.OrderBy(p => professorp.get_Nome()).ToList();
            }
            else professor.Add(prof_aux);   
        }    

        //Método para adicionar vértice de horario do professor
        public void add_Horario(Horario horarioh, Disciplina disciplinad)
        {
            var horario_aux = new Horario(horarioh.get_Horario(), disciplinad);

            //verificar se horario contem horario registrado
            if (horario.Contains(horario_aux))
            {            
                horario.OrderBy(h => horarioh.get_Horario()).ToList();
            }
            else horario.Add(horario_aux);
        }

        //Método  para retonar se o vértice é adjacente
        public bool isAdjacente(Vertice v1, Vertice v2)
        {
            //percorre a matriz 
            for (int i = 1; i < numero_Vertice; i++)
            {
                for (int x = 1; x < numero_Vertice; x++)
                {
                    if (matriz_dissimilaridade[v1.get_Vertice(), v2.get_Vertice()] == 1)
                    {
                        Console.WriteLine("Os vértices são adjacentes: " + v1.get_Vertice(), v2.get_Vertice());
                        return true;
                    }
                }
            }
            return false;
        }
    
        //Método para obter o grau do vértice
        public int get_Grau(Vertice v)
        {
            int grau_vertice = 0;

            for (int i = 1; i < this.numero_Vertice; i++)
            {
                if (matriz_dissimilaridade[v.get_Vertice(), i] == 1)
                {
                    grau_vertice++;
                }
            }
            return grau_vertice;
        }

        //Método para ver se não tem professores dando aula no mesmo horario
        public void verificar_Horario() 
        {
            Aresta aresta = new Aresta();
            foreach (var h in arestas.ToList())
            {
                if (arestas.Where(a => a.get_Horario() == h.get_Horario()).Count() > 2)
                {
                    arestas.Remove(h);
                }
            }
            arestas = arestas.OrderBy(h => h.get_Horario()).ToList();
        }

        
        //Método para procurar um vértice no grafo
        public Vertice procurar_Vertice(Vertice v)
        {
            for (int i = 0; i < list_vertices.Count(); i++)
            {
                if (list_vertices[i].get_Vertice() == v.get_Vertice())
                {
                    Console.WriteLine(list_vertices[i]);
                    return list_vertices[i];
                }
            }
            return null;
        }

        //Método para imprimir a matriz de dissimilaridade
        public void imprimir_MatrizDissimilaridade()
        {
            //percorre a lista de professores e disciplinas
            Console.WriteLine("\n=====Informações dos Professores======");
            foreach (Professor p in professor)
            {
                Console.WriteLine("Professor: " + p.get_Nome() + "\t" + "Disciplina: "
                                  +  p.get_Disciplina());
            }

             //percorre a lista de de horarios
            Console.WriteLine("\n=====Informações dos Horarios======");
            foreach (Horario h in horario)
            {
                Console.WriteLine("Horario: " + h.get_Horario() + "\t" + "Disciplina: "
                                 + h.get_Disciplina());
            }

            //percorre a lista de arestas
            Console.WriteLine("\n=====Informação geral=======");
            foreach (Aresta a in arestas)
            {
                Console.WriteLine("Professor:" + a.get_Professor() + "Disciplinas:" +
                    a.get_Disciplina() + "Horario:" + a.get_Horario());
            }
        }

        //Sessão de Getters e Setters
        public int get_NumeroVertice()
        {
            return numero_Vertice;
        }
        public void set_NumeroVertice(int numero_Vertice)
        {
            this.numero_Vertice = numero_Vertice;
        }    
    }
}
