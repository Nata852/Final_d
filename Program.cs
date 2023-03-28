Console.WriteLine("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] arr1 = new string[m];
void array(string[]stringArray)
{
for (int j = 0; j < m; j++);
}
{
    Console.Write("Введите элемент массива: ");
    string Array = Console.ReadLine();
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", arr1));
Console.Write("]");

int count = 0;
int Symbols = 3;

for (int j = 0; j < arr1.Length; j++)
{
    if (arr1[j].Length <= Symbols)
    {
        count++;
    }
}
Console.WriteLine();
Console.Write("Полученный массив: [");
string[] arr2 = new string[count];
int g = 0;
for (int j =0; j < arr1.Length; j++)
{
    if(arr1[j].Length <= Symbols)
    {
        arr2[g]=arr1[j];
        Console.Write(arr2[g] + ",");
        g++;
    }
}
Console.Write("]");
