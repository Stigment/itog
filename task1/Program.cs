string[] ar1 = new string[5] {"end", "del", "hello", "world", "res"};
string[] ar2 = new string[ar1.Length];
void SecondArray(string[] ar1, string[] ar2)
{
    int count = 0;
    for (int i = 0; i < ar1.Length; i++)
    {
    if(ar1[i].Length <= 3)
        {
        ar2[count] = ar1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(ar1, ar2);
PrintArray(ar2);