Console.Clear();

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Input {i + 1} element: " );
    array[i] = Console.ReadLine();
}

string[] newArray = new string[array.Length];

void CutArray(string[] array, string[] newArray)
{
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
}

CutArray(array, newArray);
Console.WriteLine("==========");
Console.WriteLine("Print sourse array:");
ShowArray(array);
Console.WriteLine("==========");
Console.WriteLine("Print cut array:");
ShowArray(newArray);






