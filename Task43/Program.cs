// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите k1, b1, k2, b2 через запятую");
string values = Console.ReadLine();
string[] array = values.Split(',');
double[] arr = new double[] { Convert.ToInt32(array[0]), Convert.ToInt32(array[1]),
                             Convert.ToInt32(array[2]), Convert.ToInt32(array[3]) };
double x;
double y;

if (arr[0] == arr[2]) Console.WriteLine("Прямые параллельны и точки пересечения не имеют");
else
{
    x = (arr[3] - arr[1]) / (arr[0] - arr[2]);
    y = arr[2] * x + arr[3];
    Console.WriteLine($"Прямые пересекаются в точке с координатами x = {Math.Round(x, 2)}; y = {Math.Round(y, 2)}");
}

