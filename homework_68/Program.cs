/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();
int Meaning(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int AkkermanFunk(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return AkkermanFunk(m - 1, 1);
  else return AkkermanFunk(m - 1, AkkermanFunk(m, n - 1));
}

int m = Meaning("Введите значение M: ");
int n = Meaning("Введите значение N: ");

Console.WriteLine($"A({m},{n}) = {AkkermanFunk(m, n)}");