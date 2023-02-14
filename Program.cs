int[,] create_array(int row, int column)
{
int[,] array = new int[row,column];
Random random = new Random();
for(int i=0;i<row;i++)
{
    for(int j=0;j<column;j++)
    {
        
        array[i,j] = random.Next(1,10);
    }
}
return array;
}

void print_array(int[,] array)
{
for(int i=0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}

int[,] row_exchange(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            if(i == 0)
            {
                int row_temp = array[i,j];
                array[i,j] = array[array.GetLength(0) - 1,j];
                array[array.GetLength(0) - 1,j] = row_temp;
            }
            
        }
    }
    return array;
}


Console.WriteLine("Введите число строк двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = create_array(m,n);
Console.WriteLine("Исходный массив:");
print_array(array);

int[,] array_exchange = row_exchange(array);
Console.WriteLine("Измененный массив:");
print_array(array_exchange);