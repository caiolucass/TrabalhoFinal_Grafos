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

        //Construtor do nome do professor
        public Professor(string nome_Professor)
        {
            this.nome_Professor = nome_Professor;
        }

        //Construtor do nome do professor
        public Professor(string nome_Professor, Disciplina nome_disciplina)
        {
            this.nome_Professor = nome_Professor;
            this.nome_disciplina = nome_disciplina;
        }
       
        //Retorna se os objetos são iguais
        public override bool Equals(object o)
        {
           return this.nome_Professor == (o as Professor).nome_Professor &&
           this.nome_disciplina == (o as Professor).nome_disciplina;
        }

        //Seção de Getters e Setters
        public string get_Nome()
        {
            return nome_Professor;
        }
        public void set_Nome(string nome_Professor)
        {
            this.nome_Professor = nome_Professor;
        }

        public  Disciplina get_Disciplina()
        {        
            return nome_disciplina;
        }
        public void set_Disciplina(Disciplina nome_disciplina)
        {
            this.nome_disciplina = nome_disciplina;
        }
    }
}