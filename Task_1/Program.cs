// Найти произведение двух матриц
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

int[,]MatrMult(int[,]matrA, int[,]matrB)
{ 
    int[,]matrC=new int[matrA.GetLength(0),matrB.GetLength(1)];
    for (int i=0;i<matrA.GetLength(0);i++)
    {
        for (int j=0;j<matrB.GetLength(1);j++)
        {
            matrC[i,j]=0;
            for (int k=0;k<matrA.GetLength(1);k++)
            {
            matrC[i,j]+=matrA[i,k]*matrB[k,j];
            }
        }     
    }
    return matrC;
}

Console.Clear();
Console.Write("Enter amount of rows for matrix A: ");
int rowsA=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter amount of columns for matrix A: ");
int columnsA = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter left side for elements of matrix A: ");
int startA=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter right side for elements of matrix A: ");
int finishA = int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
int[,]matrA = FillMatrix(rowsA,columnsA,startA,finishA);
PrintMatrix(matrA);
Console.WriteLine();
Console.Write("Enter amount of rows for matrix B: ");
int rowsB=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter amount of columns for matrix B: ");
int columnsB=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter left side for elements of matrix B: ");
int startB=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter right side for elements of matrix B: ");
int finishB=int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
int[,]matrB=FillMatrix(rowsB,columnsB,startB,finishB);
PrintMatrix(matrB);
Console.WriteLine();
if (columnsA!=rowsB)
    Console.WriteLine("Matrix multiplication is not possible: the number of columns in matrix A is not equal to the number of rows in matrix B");
else
{
    int[,]product=MatrMult(matrA,matrB);
    Console.WriteLine("Matrix product:");
    Console.WriteLine();
    PrintMatrix(product);
}
Console.WriteLine();
