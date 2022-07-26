// Работа с массивами. Перебор массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // Метод , который выводит в консоль заданный нами массив
{
  int count = array.Length;

  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i; // вводим переменную minPosition и присваиваем ей значение i

    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition]) minPosition = j;
    }

    int temp = array[i]; // вводим переменную temp и присваиваем ей значение в текущем индексе массива
    array[i] = array[minPosition]; // текущему значению в текущем индексе массива присваиваем значение лежащее в индексе minPosition
    array[minPosition] = temp; // текущему значению в индексе minPosition присваиваем значение лежащее в temp
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);