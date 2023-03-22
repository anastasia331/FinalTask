Console.WriteLine("Сколько нужно ввести элементов? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int leng = 3;
int pos = 0;
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length <= leng)
    {
 arrayStrings[pos] = element;
 pos++;
    }
}

Console.Write("[ ");

void PrintArray(string[] array )
{
    for    (int i=0;   i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   
}
PrintArray(arrayStrings);
 Console.WriteLine("]");


