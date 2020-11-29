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

        public Aresta() { }

        //Construtor da classe arestas
        public Aresta(Professor professor, Disciplina disciplina, Horario horario)
        {
            this.professor = professor;
            this.horario = horario;
            this.disciplina = disciplina;
        }

        //Seção de Getters e Setters
        public Professor get_Professor()
        {
            return professor;
        }
        public void set_Professor(Professor professor)
        {
            this.professor = professor;
        }

        public Horario get_Horario()
        {
            return horario;
        }
        public void set_Horario(Horario horario)
        {
            this.horario = horario;
        }

        public Disciplina  get_Disciplina()
        {
            return disciplina;
        }
        public void  set_Disciplina(Disciplina disciplina)
        {
            this.disciplina = disciplina;
        }
    }
}
