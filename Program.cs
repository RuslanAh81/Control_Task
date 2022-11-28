 // Инициализация массива строк
      Console.WriteLine("Введите количество элементов массива");
      int size =Convert.ToInt32(Console.ReadLine());
 
      //int size =4;
      string[] AS= new string[size];
      int MaxLength = 3;
      Console.WriteLine("Введите элементы массива :");
      
      for (int i = 0; i <AS.Length; i++)
      {
         Console.WriteLine("AS[{0}]=",i);
        string? a=Console.ReadLine();
        AS [i] = a !;      
      }

    Console.WriteLine("Ваш массив :");   
    Console.Write("[");                             //Вывод массива

        for (int i=0; i<AS.Length; i++)
      {
        Console.Write(" "+ AS[i]+" ");
        if(i < AS.Length -1) Console.Write(",");
      }
      
    Console.WriteLine("]");

    string[] GetShortAS2(string[]array)                        // Создаем новый массив
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

    void ShowArray(string[]array)                              // Метод вывода массива
    {
    Console.WriteLine("Новый массив :");
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(" "+ array[i]+" ");
        if(i < array.Length -1) Console.Write(",");
    }
    Console.Write("]");
}

string [] GetShortAs2= GetShortAS2(AS);
ShowArray(GetShortAs2);



