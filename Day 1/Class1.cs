using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Class1
    {

        static void Main(string[] args)

        {
            Atleta atleta = new Atleta();
            atleta.Nome = "Cristiano";
            atleta.Cognome = "Ronaldo";
            atleta.Sport = "Calcio";
            atleta.Nazionalità = "Portoghese";

            atleta.GetFullAtletaProc();
           


            Studente studente = new Studente();
            studente.Nome = "Robert";
            studente.Cognome = "Oppenheimer";
            studente.Materia = "Fisica";
            studente.Università = "Berkeley";


            Console.WriteLine(studente.GetFullStudente());
            Console.ReadLine();



        }

       
}


}
