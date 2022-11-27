 // Инициализация массива строк

 
      int size =4;
      string[] AS= new string[size];
      int MaxLength = 3;
      Console.WriteLine("Input Mass");
      
      for (int i = 0; i <AS.Length; i++)
      {
         Console.WriteLine("AS[{0}]=",i);
        string? a=Console.ReadLine();
        AS [i] = a !;
      
      }
        Console.WriteLine("vash massiv");
        for (int i=0; i<AS.Length; i++)
      {
        Console.WriteLine("AS[{0}]= {1}", i,AS[i]);
      }

string[] GetShortAS2(string[]array)    // делаем новый массив
     {
        int count = 0;
        int length= array.Length;
        string []  result = new string[length];

        for (int i = 0; i < length; i++)
        {
            if (array[i].Length<= MaxLength)
            {
                result[count]=array[i];
                count ++;
            }
        }
        string []newArray= new string[count];
        {
            for(int i=0,j=0; i<array.Length; i++)
            {
                if(array[i].Length<=3)
                {
                    newArray[j]=array[i];
                    j++;
                }
            }
        }
        return newArray;
     }

void ShowArray(string[]array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(" "+ array[i]+" ");
    }
    Console.Write("]");
}

string [] GetShortAs2= GetShortAS2(AS);
ShowArray(GetShortAs2);


/*
string[] array1 = new string[4] {"hello", "2", "world", "))"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
*/
