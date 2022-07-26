// 1 вид методов, который ничего не возвращает и не принимает никаких аргументов, может просто например что-то выводить на экран
void Method1()
{
  Console.WriteLine("Пример сообщения");
}
// вызов метода
Method1();



// 2 вид методов, который ничего не возвращает, но может принимать аргументы
void Method2(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }

}
Method2(msg: "Текст вызванн методом msg четыре раза", count: 4);


// 3 вид методов, которые что-то возвращают, но ничего не принимают
int Method3()
{
  return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// 4 вид методов , которые что-то принимают и что-то возвращают
string Method4(int count, string text)
{
  int i = 0;
  string result = String.Empty; // string result = "";
  while (i < count)
  {
    result = result + text; // for(int i = 0; i < count; i++)
    i++;
  }
  return result;
}

string res = Method4(10, "Пример"); // string переменная res = Метод Method4(count = 10, string text = "Пример")
Console.WriteLine(res);

// Цикл for
// Таблица умножения
for (int i = 2; i <= 10; i++)
{
  for (int j = 2; j <= 10; j++)
  {
    Console.WriteLine($"{i} * {j} = {i * j}");
  }
  Console.WriteLine();
}