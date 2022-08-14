// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, -567, 89, 223-> 3

int[] CreatingArrayFromString(string EnteringArray, char value)
{
    int count = 1;
    for (int iStr = 0; iStr < EnteringArray.Length; iStr++)
    {
        if (EnteringArray[iStr] == value)
        {
            count++;
        }
    }

    int[] arr = new int[count];
    int iArr = 0;
    string save = string.Empty;

    for (int iStr = 0; iStr < EnteringArray.Length; iStr++)
    {
        if (iStr != EnteringArray.Length - 1)
        {
            while (EnteringArray[iStr] != value)
            {
                save = save + $"{EnteringArray[iStr]}";
                iStr++;
                if (iStr == EnteringArray.Length) break;
            }
            arr[iArr] = int.Parse(save);
            iArr++;
            save = string.Empty;
        }
        else
        {
            save = save + $"{EnteringArray[iStr]}";
            arr[iArr] = int.Parse(save);
        }
    }
    return arr;
}

int CountPositive(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]>0) count ++;
        else continue;
    }
    return count;
}

Console.Write("Введите числа через запятую: ");
string entering = Console.ReadLine();
int[] mass = CreatingArrayFromString(entering, ',');
Console.WriteLine($"Количество чисел больше нуля = {CountPositive(mass)}");
