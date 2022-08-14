// Задача 6семинар - необязательная: Напишите программу, на вход которой подаётся размерность матрицы 
// и потом прямоугольная матрица в виде последовательности строк. .
// Программа должна вывести матрицу того же размера, у которой каждый элемент в позиции i, j равен сумме элементов 
// первой матрицы на позициях (i-1, j), (i+1, j), (i, j-1), (i, j+1). У крайних символов соседний элемент находится 
// с противоположной стороны матрицы.
// В случае одной строки/столбца элемент сам себе является соседом по соответствующему направлению.
// Sample Input 1:
// 3

// 9 5 3
// 0 7 -1
// -5 2 9

// Sample Output 1:
// 3 21 22
// 10 6 19
// 20 16 -1

// Sample Input 2:
// 1

// 1
// Sample Output 2:
// 4


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }
}

void FillNewMatrix(int[,] newArray, int[,] array)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            int up;
            int left;
            int down;
            int right;

            if (i == 0) up = array[array.GetLength(0) - 1, j];
            else up = array[i - 1, j];

            if (j == 0) left = array[i, array.GetLength(1) - 1];
            else left = array[i, j - 1];

            if (i == newArray.GetLength(0) - 1) down = array[0, j];
            else down = array[i + 1, j];

            if (j == newArray.GetLength(1) - 1) right = array[i, 0];
            else right = array[i, j + 1];

            newArray[i, j] = up + left + down + right;
        }
    }
}

Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] mass = size.Split(",");
int[,] massive = new int[Convert.ToInt32(mass[0]), Convert.ToInt32(mass[1])];

FillMatrix(massive);
PrintMatrix(massive);

int[,] newMass = new int[massive.GetLength(0), massive.GetLength(1)];

Console.WriteLine();
FillNewMatrix(newMass, massive);
PrintMatrix(newMass);