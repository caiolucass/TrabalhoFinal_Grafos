using System;
using System.Collections.Generic;
using System.Text;

/**
  * @autor: Caio Lucas F. dos Santos
  * @autor: Wernen Rodrigues Maciel
  */

namespace TI_Final_Grafos
{
    public class Aresta
    {

        private Professor professor; // professor da disciplina
        private Horario horario; // horario das disciplina e do professor
        private Disciplina disciplina; //disciplina do professor

        public Professor Professor { get => professor; set => professor = value; }
        public Horario Horario { get => horario; set => horario = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }

        public Aresta() { }

        //Construtor da classe arestas
        public Aresta(Professor professor, Disciplina disciplina, Horario horario)
        {
            this.Professor = professor;
            this.Horario = horario;
            this.Disciplina = disciplina;
        }

    }
}
