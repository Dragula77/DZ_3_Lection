System.Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;

for (; i <= x; i++)
{
    System.Console.Write(Math.Pow(i, 3) + " ");
}
