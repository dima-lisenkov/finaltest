void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}
// string[] textArray = { "Russia", "Denmark", "Kazan" };

Console.WriteLine("Ввод ',':");
string[] textArray = Console.ReadLine().Split(',');
int limitLength = 3;
int count = 0;
for (int i = 0; i < textArray.Length; i++)
{
    if (textArray[i].Length <= limitLength) count++;
}
string[] textArrayResult = new string[count];
count = 0;
for (int i = 0; i < textArray.Length; i++)
{
    if (textArray[i].Length <= limitLength)
    {
        textArrayResult[count] = textArray[i];
        count++;
    }
}

PrintArray(textArray);
PrintArray(textArrayResult);