string[] array1 = 
{
    "МИР",
    "Дружба",
    "Жвачка"
};

int size = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length < 4)
    {
        size++;
    }
}
string[] array2 = new string[size];
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length < 4)
    {
        array2[count] = array1[i];
        count++;
    }
}

Console.Write("[{0}]", string.Join(", ", array2));


