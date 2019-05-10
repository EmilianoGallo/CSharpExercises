using System;

namespace CSharpExercises{
    public class ConsoleExercises {
        public void AskAge(){
            
            // Console.WriteLine("¿Cuántos años tenes?: ");
            // string age = Console.ReadLine();
            // Console.WriteLine("Wow, no pareces de " + age + " años");
            // Console.ReadLine();
            PedirInformacion();
            
        }


        public void PedirInformacion(){
            Console.WriteLine("¿Cual es tu nombre?: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cual es tu Apellido?: ");
            string Apellido = Console.ReadLine();
            Console.WriteLine("¿Cual es tu Documento?: ");
            string Dni =Console.ReadLine();
            Console.WriteLine("Tu Nombre es:" + nombre + " " + Apellido + " tu dni es: " + Dni.ToString());
            Console.ReadLine();

        }



    }
}