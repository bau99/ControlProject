// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void Array(string [] StringArray) // наполняем массив строками
{
  for (int i = 0; i < StringArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     StringArray[i] = Console.ReadLine();
  }
}
string [] Symbol(string [] StringArray)
// производим подсчета количества элементов в массиве, длина которых меньше либо равна 3 символа
{
  int n = 0;
  for (int i = 0; i < StringArray.Length; i++)
  {
    if(StringArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n]; // создаем новый массив размером, равным количеству подсчитанных элементов
  // заполняем новый массив элементами, длина которых меньше либо равна 3 символа
  int j = 0;
  for (int i = 0; i < StringArray.Length; i++)
  {
    if(StringArray[i].Length <=3)
    {
        rez[j] = StringArray[i];
        j++;
    }
  }
  return rez;
}
void PrintA(string [] StringArray)
{
    Console.Write("[");
    for (int i = 0; i < StringArray.Length; i++)
    {
    Console.Write(StringArray[i]+ ((i != StringArray.Length-1) ? ", " : " "));
    }
    Console.WriteLine("]");
}

// создаем массив
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] StringArray = new string [m];

Array(StringArray);
// выводим на печать исходный массив и новый массив
PrintA(StringArray);
PrintA(Symbol(StringArray));