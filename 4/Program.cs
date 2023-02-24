// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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
int[,] twoDecimalArray2 = arrayFiller();
for(int i = 0; i<twoDecimalArray.GetLength(0); i++){
    Console.Write("\n");
       for(int j = 0; j<twoDecimalArray.GetLength(1); j++)
       Console.Write($"{twoDecimalArray[i,j]*twoDecimalArray2[i,j]}, " );
}

