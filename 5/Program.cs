// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// массив размером 2 x 2 x 2
// int[,,]
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
int[,,] twoDecimalArray =new int[,,]{ { { 10, 20 }, { 40, 50 } }, { { 70, 80 }, { 10, 11 } } };
for(int i = 0; i<twoDecimalArray.GetLength(0); i++){
   for(int j = 0; j<twoDecimalArray.GetLength(1); j++){
      Console.Write("\n");
      for(int k = 0; k<twoDecimalArray.GetLength(2); k++){
         Console.Write($"{twoDecimalArray[i,j,k]}({i},{j},{k}) " );
      }
   }
}   
           
           
  