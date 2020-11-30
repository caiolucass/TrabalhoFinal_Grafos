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
        private int horarios; // horario das disciplinas
        private Disciplina disciplina; //disciplinas disponíveis

        public int Horarios { get => horarios; set => horarios = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }

        //Construtor de horario
        public Horario(int horario)
        {
            this.Horarios = horario;
        }

        //Construtor da classe Horario
        public Horario(int horario, Disciplina disciplina)
        {
            this.Horarios = horario;
            this.Disciplina = disciplina;
        }

        //Retorna se os objetos são iguais
        public override bool Equals(object o)
        {
            return this.Horarios == (o as Horario).Horarios
            && this.Disciplina == (o as Horario).Disciplina;
        }

      
    }
}