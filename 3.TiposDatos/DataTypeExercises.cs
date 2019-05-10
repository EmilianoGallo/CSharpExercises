using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
            Console.WriteLine("Ingrese un valor a sumar:");
            string firstValue = Console.ReadLine();

            Console.WriteLine("Ingrese otro valor a sumar:");
            string secondValue = Console.ReadLine();
            bool PudoParsear;
            bool PudoParsearSegundoValor;

            int First = 0;
            int Second = 0;
            PudoParsear=Int32.TryParse(firstValue,out First);
            PudoParsearSegundoValor =Int32.TryParse(secondValue,out Second);

            if (PudoParsear)
            {
                if (PudoParsearSegundoValor)
                {
                    Console.WriteLine("El resultado de la suma es: {0}", First + Second);     
                }
                else
                {
                    Console.WriteLine("No Pude parsear el segundo valor");     
                }
            }
            else
            {
                Console.WriteLine("No Pude parsear el primer valor");     
            }

            
        }
    }
}