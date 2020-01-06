using System;

namespace Exercicios
{
    
    class Program
    {
        public static int[] Numeros = new int[20] {2,1,3,4,6,5,7,8,9,10,12,11,13,15,14,16,17,20,19,18};
        public static int[] NumerosPares = new int[]{};
        static void Main(string[] args)
        {
            //int[] vetor = {2,1,3,4,6,5,7,8,9,10,12,11,13,15,14,16,17,20,19,18};
            
            OrdenaCrescente(Numeros);            
            imprimeArray(Numeros);
            OrdenaDecrescente(Numeros);
            imprimeArray(Numeros);
            SomentePares(Numeros);            
            
        }

        static Array GeraArray(int qtd){
            int[] array = new int[qtd];
            return array;
        }

        static void OrdenaCrescente(int[] array){
            for(int i = 1; i < array.Length; i++ )
                for(int j = 0; j < array.Length-1; j++)
                    if(array[j] > array[j+1])
                        Troca(array,j);           
        }

        static void OrdenaDecrescente(int[] array){
            for(int i = 1; i < array.Length; i++ )
                for(int j = 0; j < array.Length-1; j++)
                    if(array[j] < array[j+1])
                        Troca(array,j);                    
                
        }
        static void Troca(int[] array, int primeiro){
            int temporaria;
            temporaria = array[primeiro];
            array[primeiro] = array[primeiro + 1];
            array[primeiro + 1] = temporaria;
        }

        static void SomentePares(int[] array){
            int index = 0;
            for(int i = 0; i < array.Length; i++){                
                if(EhPar(array[i])){
                    NumerosPares[index] = array[i];
                    Console.WriteLine(NumerosPares[index]);
                    index++;
                }
            }
            //imprimeArray(NumerosPares);
            
        }

        static bool EhPar(int valor){

            return valor%2 == 0;

        }

        static void SomenteImpares(int[] array){
            
        }

        static void imprimeArray(int[] array){
            for(int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
                
            Console.WriteLine("########");
        }

    }
}
