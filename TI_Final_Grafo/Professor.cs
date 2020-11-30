using System;
using System.Collections.Generic;
using System.Text;

/**
  * @autor: Caio Lucas F. dos Santos
  * @autor: Wernen Rodrigues Maciel
  */
namespace TI_Final_Grafos
{
    public class Professor
    {
        private string nome_Professor; //nome do professor
        private Disciplina nome_disciplina; //nome da disciplinia

        public string Nome_Professor { get { return nome_Professor; } }
        public Disciplina Nome_disciplina { get  { return nome_disciplina; } }

        //Construtor do nome do professor
        public Professor(string nome_Professor)
        {
            this.nome_Professor = nome_Professor;
        }

        //Construtor do nome do professor
        public Professor(string nome_Professors, Disciplina nome_disciplinas)
        {
            this.nome_Professor = nome_Professors;
            this.nome_disciplina = nome_disciplinas;
        }

        public override int GetHashCode()
        {
            return this.nome_Professor.GetHashCode() + this.nome_disciplina.GetHashCode();
        }

        //Retorna se os objetos são iguais
        public override bool Equals(object o)
        {
            return this.nome_Professor == (o as Professor).nome_Professor &&
            this.nome_disciplina == (o as Professor).nome_disciplina;
        }

    }
}