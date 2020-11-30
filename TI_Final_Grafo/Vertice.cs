using System;
using System.Collections.Generic;
using System.Text;

/**
  * @autor: Caio Lucas F. dos Santos
  *@autor: Wernen Rodrigues Maciel
  */
namespace TI_Final_Grafos
{
    public class Vertice
    {
        private int vertices; //vertice
        private int grau_Vertice; //grau do vertice

        public int Vertices { get => vertices; set => vertices = value; }
        public int Grau_Vertice { get => grau_Vertice; set => grau_Vertice = value; }

        //Construtor
        public Vertice() { }

        //Contrutor
        public Vertice(int vertice, int grau_Vertice)
        {
            this.Vertices = vertice;
            this.Grau_Vertice = grau_Vertice;
        }
        //Construtor de vertice
        public Vertice(int vertice)
        {
            this.Vertices = vertice;
        }

        //Retorna se os objetos são iguais
        public override bool Equals(object o)
        {
            //Verifica se os objetos possuem o mesmo tipo e valor
            if ((o as Vertice).Vertices == this.Vertices &&
               (o as Vertice).Grau_Vertice == this.Grau_Vertice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}