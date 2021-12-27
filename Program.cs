int[] myArray = new int[10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 12);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] Method(int[] myArray)
{
    int length = myArray.Length;
    int[] newArray = new int[] {};
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 8)
        {
            newArray[i] = myArray[i];
        }
    }
    return newArray;
}

int[] newArray = Method(myArray);

void PrintnewArray (int[] arr) 
{
    int count = arr.Length;
    for (int i = 0; i < count ; i++)
    {
        if(arr[i]!=0) Console.Write($"{arr[i]} ");
    }
}


FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
Method(myArray);
PrintnewArray(newArray);