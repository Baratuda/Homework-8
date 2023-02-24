//Из двумерного массива целых чисел удалить строку и столбец,
//на пересечении которых расположен первый найденный наименьший элемент.
 double[,] arrayFillerHelpMethod(double[,] twoDecimalArray){
            Random randomNumber = new Random();
            for(int i = 0; i<twoDecimalArray.GetLength(0); i++)
               for(int j = 0; j<twoDecimalArray.GetLength(1); j++)
                  twoDecimalArray[i,j] = 20.0*randomNumber.Next()/2147483648-10;
            return twoDecimalArray;
        }
        
        double[,] arrayFiller() { 
            Console.Write("Please enter the array size (count arrays, length array): ");
            var arrayLength = Console.ReadLine().Split(",");
            int countArrays = int.Parse(arrayLength[0]);
            int lengthArrays = int.Parse(arrayLength[1]);
            double[,] twoDecimalArray = arrayFillerHelpMethod(new double[countArrays, lengthArrays]);
            return twoDecimalArray;
        }
        double[] findMinimalNumber(double[,] twoDecimalArray){
            double[] minimalNumbersCoardinats = new double[2];
            double minNumber = twoDecimalArray[0,0];
            for(int i = 0; i<twoDecimalArray.GetLength(0); i++)
               for(int j = 0; j<twoDecimalArray.GetLength(1); j++)
               if(minNumber>twoDecimalArray[i,j]){
                   minNumber=twoDecimalArray[i,j];
                   minimalNumbersCoardinats[0] = i;
                   minimalNumbersCoardinats[1] = j;
               }
            return minimalNumbersCoardinats;
        }
        
        void columnAndRowCuter(double[,] twoDecimalArray,double[,] twoDecimalArray2){
             double[] minNumbersCoordinats = findMinimalNumber(twoDecimalArray);
             int i2=0;
             int j2=0;
             for(int i = 0; i<twoDecimalArray.GetLength(0); i++){
                  if(i!=minNumbersCoordinats[0]){
                    for(int j = 0; j<twoDecimalArray.GetLength(1); j++){ 
                      if(j!=minNumbersCoordinats[1])
                            twoDecimalArray2[i-i2, j-j2] = twoDecimalArray[i,j]; 
                      else j2++;
                    }
                  }else i2++;
                  j2=0;
               }
            }
            
        Console.Clear();
        double[,] twoDecimalArray = arrayFiller();
        double[,] twoDecimalArray2 = new double[twoDecimalArray.GetLength(0)-1,twoDecimalArray.GetLength(1)-1];
        columnAndRowCuter(twoDecimalArray, twoDecimalArray2);   
        Console.WriteLine("Our array with stripped row and column.");    
        for(int i = 0; i<twoDecimalArray2.GetLength(0); i++){
           Console.Write("\n");
           for(int j = 0; j<twoDecimalArray2.GetLength(1); j++)
               Console.Write(String.Format("{0,5:f1}",twoDecimalArray2[i,j] ));    
           }

