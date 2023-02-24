// Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


        int[,] arrayFillerHelpMethod(int[,] twoDecimalArray){
            Random randomNumber = new Random();
            for(int i = 0; i<twoDecimalArray.GetLength(0); i++)
               for(int j = 0; j<twoDecimalArray.GetLength(1); j++)
                  twoDecimalArray[i,j] = randomNumber.Next(-50,50);
            return twoDecimalArray;
        }
        
        int[,] arrayFiller() { 
            Console.Write("Please enter the array size (count arrays, length array): ");
            var arrayLength = Console.ReadLine().Split(",");
            int countArrays = int.Parse(arrayLength[0]);
            int lengthArrays = int.Parse(arrayLength[1]);
            int[,] twoDecimalArray = arrayFillerHelpMethod(new int[countArrays, lengthArrays]);
            return twoDecimalArray;
        }
        
        
        
        Console.Clear();
        int[,] twoDecimalArray = arrayFiller();
        for(int i = 0; i<twoDecimalArray.GetLength(0); i++){
           Console.Write("\n");
           for(int j = 0; j<twoDecimalArray.GetLength(1); j++){
               for(int k = twoDecimalArray.GetLength(1)-1; k>j; k--){
                  if(twoDecimalArray[i,k]<twoDecimalArray[i,j]){
                     int x = twoDecimalArray[i,j];
                     twoDecimalArray[i,j] = twoDecimalArray[i,k];
                     twoDecimalArray[i,k]=x;
                  }
               }
               Console.Write($"{twoDecimalArray[i,j]}, " );
           }
        }
