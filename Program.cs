void PrintArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        Console.Write("\"");
        Console.Write(inputArray[i]);
        Console.Write("\"");

        if (i < inputArray.GetLength(0) - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

string[] arr = {"go", "09876", ":o)", "45"};
int size = arr.Length;
int i = 0;
int j = 0;
string[] res = {};
while (i < size)
{
    if (arr[i].Length <= 3)
    {
        j++;
        Array.Resize (ref res, j);
        res [j - 1] = arr[i];
    }
    i++;
}
PrintArray(res);