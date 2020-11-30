using System;
using System.Collections.Generic;
using System.Text;

/**
  * @autor: Caio Lucas F. dos Santos
  * @autor: Wernen Rodrigues Maciel
  */
namespace TI_Final_Grafos
{
    public class Disciplina
    {
        private string disciplinas; //disciplinas dos professores

        public Disciplina()
        {
            
        }

        //Construtor de Disciplinas
        public Disciplina(string disciplinas)
        {
            this.disciplinas = disciplinas;
        }

        public string Disciplinas { get { return disciplinas; } }

        public override int GetHashCode()
        {
            return this.disciplinas.GetHashCode();
        }
        //Retorna se os objetos são iguais
        public override bool Equals(object o)
        {
            return this.disciplinas == (o as Disciplina).disciplinas;
        }


    }
}

