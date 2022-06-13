/* Сформировать трехмерный массив из неповторяющихся двузначных чисел
Показать его построчно на экран, выводя индексы последующих элементов*/
int[,,]ArrOf2DigNumbers(int dim1,int dim2,int dim3)
{
int[,,]arr3D=new int[dim1,dim2,dim3];
int count=-99;
for (int i=0;i<arr3D.GetLength(0);i++)
    for (int j=0;j<arr3D.GetLength(1);j++)
        for (int k=0;k<arr3D.GetLength(2);k++)
            if (-100<count&&count<100&&count/10!=0)
                {
                    arr3D[i,j,k]=count;
                    Console.Write($"[{i},{j},{k}] {arr3D[i,j,k]}  ");
                    count++;
                }
            else
                {
                    count++;
                }                                                              
    return arr3D;
}      
Console.Clear();
Console.Write("Enter amount of array's 1th dimension: ");
int dim1=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter amount of array's 2th dimension: ");
int dim2=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter amount of array's 3th dimension: ");
int dim3=int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
if (dim1*dim2*dim3>180)
    {
        Console.Write("Your 3D-Array is too large: ");
        Console.WriteLine("amount of elements exceed amount of double-digit numbers!");
    }
else
    {
        ArrOf2DigNumbers(dim1,dim2,dim3);
    }
Console.WriteLine();
Console.WriteLine();