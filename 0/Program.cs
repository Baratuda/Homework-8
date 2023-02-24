// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// данную задачу я решил следующим образом. Представление массива как квадрат и разделения этого квадрата на (arraySize/2) колец,
//  далее эти кольца заполняются последовательно числами (numberToBeFilledIn) от 0 кольца до (arraySize/2) кольца.
// Данный метод находит  кольцо следующим образом. Он находит первый элемент который еще не заполнен что является началом кольца и 
// выводит размер этого кольца.
// например: принимая на вход еще не заполненный массив длиной 5 элементов он возвращает arraySize=5,  далее если повторять выполнение 
//метода и передавать тот же массив то следующий arraySize = 5 - i2(i- номер столбца);

// Задача работает с величиной массива >4!!!!!!
Console.Clear();
int arraySize = 7;
int numberToBeFilledIn = 1;//Число которым заполняется массив.
int[,] ourTwoDecimalArray = new int[arraySize,arraySize];

// Данный метод находит  кольцо следующим образом. Он находит первый элемент который еще не заполнен что является началом кольца и 
// выводит размер этого кольца.
// например: принимая на вход еще не заполненный массив длиной 5 элементов он возвращает arraySize=5,  далее если повторять выполнение 
//метода и передавать тот же массив то следующий arraySize = 5 - i2(i- номер столбца);
int searcherZeroNumber(int[,] resultArray){
    int result = 0;
    for(int i=0; i<ourTwoDecimalArray.GetLength(0);i++){
        for(int j=0; j<ourTwoDecimalArray.GetLength(1);j++){
            if(resultArray[i,j] == 0){
                result = ourTwoDecimalArray.GetLength(0)-i*2;
                return result;
            } 
        }
    }
    return result;    
}
//Так как в квадрате 4 стороны то , чтобы сделать один круг нужны 4 раза выполнить заполнение.
//данный метод принимает на вход массив для заполнения, число с которого начинается заполнение массива, 
//координаты первого элемента r,r2 и возвращает число которым было законченно заполнение массива для следуйщего вызова этого метода.
int arrayPlaceholder(int[,] resultArray, int numberToBeFilledIn, int r, int r2){
    int searcherZeroNumber1 = searcherZeroNumber(resultArray);
    int iterator = 0;
    int x = 0;
    int y = 0;
    int firstMultiplier = 0;
    int secondMultiplier = 0;
    for(int a =1; a<=4; a++){
        x = r;
        y = r2;
        firstMultiplier = 1;
        secondMultiplier = 1;
        iterator = searcherZeroNumber1+x;
        if(searcherZeroNumber1==-1){//В последней итерации метод searcherZeroNumber возвращает -1.Данный оператор ветвление выход из цикла.
          resultArray[y,x] = numberToBeFilledIn;
          return numberToBeFilledIn;  
        } 
        if(a==2){
            y = y+1;
            x = iterator-1;
            firstMultiplier = 1;
            secondMultiplier = 1;
        }
        if(a==3){
            int f = iterator;
            iterator = 1-x;
            x = -f+2;
            y = f-1;
            firstMultiplier = -1;
            secondMultiplier = 1;
        }
        if(a==4){
            y = -iterator+2;
            iterator = 0-x;
            secondMultiplier = -1;
            firstMultiplier =  1;
        }
        while((a==1 || a==3?x:y)<iterator){
            resultArray[y*secondMultiplier,x*firstMultiplier] = numberToBeFilledIn;
            if(a==1 || a==3) x++;
            else y++;
            numberToBeFilledIn++;
        }
    }
    return numberToBeFilledIn;
}
        //Строки кода выполняющие вычисление количество кругов для заполнения и производит заполнение.
        for(int j = 0; j<(arraySize+arraySize%2)/2;j++){
            numberToBeFilledIn = arrayPlaceholder(ourTwoDecimalArray,numberToBeFilledIn,j,j);
        }

        for(int i=0; i<ourTwoDecimalArray.GetLength(0);i++){
         Console.Write("\n");
              for(int j=0; j<ourTwoDecimalArray.GetLength(1);j++){
                  Console.Write($"{ourTwoDecimalArray[i,j]}, ");
              }
        }
        


