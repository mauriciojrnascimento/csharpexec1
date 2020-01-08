using System;

namespace Exercicios
{
    
    class Program
    {
        public static int[] Numeros = new int[] {2,1,3,4,6,5,7,8,9,10,12,11,13,15,14,16,17,20,19,18};
        public static int[] NumerosPrimo = 
            new int[] {
                        2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 
                        103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 
                        211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 
                        331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449};

        public static int[] ArrayNumeros = new int[20];
        static void Main(string[] args)
        {   
            
            OrdenaCrescente(Numeros);            
            imprimeArray(Numeros);
            OrdenaDecrescente(Numeros);
            imprimeArray(Numeros);
            SomentePares(Numeros); 
            SomenteImpares(Numeros);
            SomentePrimos(Numeros);
            
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
                    ArrayNumeros[index] = array[i];        
                    AtualizaTamanhoArray(ref ArrayNumeros, ArrayNumeros.Length + 1);
                    Console.WriteLine(ArrayNumeros[index]);
                    index++;
                }                
            }
        }

        static void AtualizaTamanhoArray(ref int[] array, int tamanho){
            Array.Resize(ref array, tamanho + 1);            
        }

        static bool EhPar(int valor){

            return valor%2 == 0;

        }

        static void SomenteImpares(int[] array){
            int index = 0;
            for(int i = 0; i < array.Length; i++){                
                if(!EhPar(array[i])){
                    ArrayNumeros[index] = array[i];        
                    Array.Resize(ref ArrayNumeros, ArrayNumeros.Length + 1);
                    Console.WriteLine(ArrayNumeros[index]);
                    index++;                    
                }
            } 
        }

        static void SomentePrimos(int[] array){
            int index = 0;
            for(int i = 0; i < array.Length; i++){                
                if(ValidaNumeroPrimo(array[i])){
                    ArrayNumeros[index] = array[i];        
                    Array.Resize(ref ArrayNumeros, ArrayNumeros.Length + 1);
                    Console.WriteLine(ArrayNumeros[index]);
                    index++;                    
                }
            } 
        }

        static bool ValidaNumeroPrimo(int numero){
            if(numero != 1)
                for(int i = 2; i <= numero; i++){
                    if(numero % i > 0) 
                        return true;
                    else 
                        return false;   
                }                             
            return false;
        }

        static void imprimeArray(int[] array){
            for(int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
                
            Console.WriteLine("########");
        }

    }
}
