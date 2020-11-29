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
        private int vertice; //vertice
        private int grau_Vertice; //grau do vertice

        //Construtor
        public Vertice() { }

        //Contrutor
        public Vertice(int vertice, int grau_Vertice)
        {
            this.vertice = vertice;
            this.grau_Vertice = grau_Vertice;
        }
        //Construtor de vertice
        public Vertice(int vertice)
        {
            this.vertice = vertice;
        }

        //Retorna se os objetos são iguais
        public override bool Equals(object o)
        {
            //Verifica se os objetos possuem o mesmo tipo e valor
            if ((o as Vertice).vertice == this.vertice &&
               (o as Vertice).grau_Vertice == this.grau_Vertice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Seção de Getters e Setters
        public int get_GrauVertice()
        {
            return grau_Vertice;
        }
        public void set_GrauVertice(int grau_Vertice)
        {
            this.grau_Vertice = grau_Vertice;
        }
        public int get_Vertice()
        {
            return vertice;
        }
        public void set_Vertice(int vertice)
        {
            this.vertice = vertice;
        }
    }
}