using System;
using System.Collections.Generic;
using System.Text;

/**
  * @autor: Caio Lucas F. dos Santos
  *@autor: Wernen Rodrigues Maciel
  */
namespace TI_Final_Grafos
{
   public class Horario
    {
        private int horario; // horario das disciplinas
        private Disciplina disciplina; //disciplinas disponíveis

        //Construtor de horario
        public Horario(int horario)
        {
            this.horario = horario;
        }

        //Construtor da classe Horario
        public Horario(int horario, Disciplina disciplina)
        {
            this.horario = horario;
            this.disciplina = disciplina;
        }

        //Retorna se os objetos são iguais
        public override bool Equals(object o)
        {
            return this.horario == (o as Horario).horario
            && this.disciplina == (o as Horario).disciplina;
        }

        //Seção de Getters e Setter
        public int get_Horario()
        {
            return horario;
        }
        public void set_Horario(int horario)
        {
            this.horario = horario;
        }

        public Disciplina get_Disciplina()
        {
            return disciplina;
        }
        public void set_Disciplina(Disciplina disciplina)
        {
            this.disciplina = disciplina;
        }
    }
}