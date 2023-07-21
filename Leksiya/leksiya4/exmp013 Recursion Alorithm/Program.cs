
string[,] table = new string[2, 5];
// Stroki po umolchaniyu inicializirovanniy inicializovannoy strokoy String.Empty
// snachala stroki potom stolbci // Birinchi qatorlar keladi keyin esa ustinlar
// table[0,0] table[0,1] table[0,2] ... table[0,5]
// table[1,0]
// table[2,0]

// table[1, 2]="someting";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintImage(int[,] img) // printit zadanniy massiv kak izob.
{
    for (int i = 0; i < img.GetLength(0); i++)
    {
        for (int j = 0; j < img.GetLength(1); j++)
        {
            // Console.Write($"{img[i, j]} ");
            if (img[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10]
        }    
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

void FillImg(int row, int col) // dvijenie s risofkoy
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImg(row-1, col);
        FillImg(row, col-1);
        FillImg(row+1, col);
        FillImg(row, col+1);
    }
}

PrintImage(pic); // bo'yalmagan
FillImg(13,13); // bo'yalgan
