using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1

{
    public class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Sport { get; set; }

        public string Nazionalità { get; set; }



        public Atleta() { }

        public Atleta(string nome, string cognome, string sport, string nazionalità)
        {
            Nome = nome;
            Cognome = cognome;
            Sport = sport;
            Nazionalità = nazionalità;


        }


        public string GetFullAtleta()
        {
            return Nome + " " + Cognome + " " + Sport + " " + Nazionalità;
        }

        public void GetFullAtletaProc()
        {
            Console.WriteLine(GetFullAtleta());
        }
    }

    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Materia { get; set; }
        public string Università { get; set; }


        public Studente() { }

        public Studente (string nome, string cognome, string materia, string università)
        {
            Nome = nome;
            Cognome = cognome;
            Materia = materia;
            Università = università;
        }
        public string GetFullStudente()
        {
            return Nome + " " + Cognome + " " + Materia + " " + Università;
        }

    }

} 
