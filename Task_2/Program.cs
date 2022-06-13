/* В двумерном массиве целых чисел удалить строку и столбец,
на пересечении которых расположен наименьший элемент */

void PrintMatrix(int[,]matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
}

int[,]FillMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,]matrix=new int[rows,columns];
    var Random=new Random();
    for (int i=0;i<rows;i++)
        for (int j=0;j<columns;j++)
            matrix[i,j]=new Random().Next(minValue,maxValue);
    return matrix;
}

int[]FindMinMatr(int[,]matr)
{
int[]find=new int[2];  
int min=matr[0,0];
for (int i=0;i<matr.GetLength(0);i++)
{
    for (int j=0;j<matr.GetLength(1);j++)
    {
        if (matr[i,j]<min)
        {
            min=matr[i,j];
            find[0]=i;
            find[1]=j;
        }
    }  
}
return find;
}

int[,]CutMatrix(int[,]matr, int indRow, int indCol)
{
int[,]matrReduc=new int[matr.GetLength(0)-1,matr.GetLength(1)];
for (int i=0;i<matr.GetLength(0)-1;i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
        {
            if (indRow>i)
            {
                matrReduc[i,j]=matr[i,j];
            }
            else
            {
                matrReduc[i,j]=matr[i+1,j];
            }
        }
    }
int[,]matrDim=new int[matrReduc.GetLength(0),matrReduc.GetLength(1)-1];
for (int i=0;i<matrReduc.GetLength(0);i++)
    {
        for (int j=0;j<matrReduc.GetLength(1)-1;j++)
        {
            if (indCol>j)
            {
                matrDim[i,j]=matrReduc[i,j];
            }
            else
            {
                matrDim[i,j]=matrReduc[i,j+1];
            }
            Console.Write($"{matrDim[i,j]} ");
        }
        Console.WriteLine();
    }
return matrDim;
}

Console.Clear();
Console.Write("Enter amount of matrix rows: ");
int rows=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter amount of matrix columns: ");
int columns=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter left side of matrix elements: ");
int start=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter right side of matrix elements: ");
int finish=int.Parse(Console.ReadLine()??"0");
int[,] matrix=FillMatrix(rows,columns,start,finish);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
FindMinMatr(matrix);
Console.WriteLine($"Index of the least element: [{FindMinMatr(matrix)[0]},{FindMinMatr(matrix)[1]}]");
Console.WriteLine();
CutMatrix(matr: matrix, indRow: FindMinMatr(matrix)[0], indCol: FindMinMatr(matrix)[1]);
Console.WriteLine();

