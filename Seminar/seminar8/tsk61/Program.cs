// Vivesti pervie N strok treugolnika Paskalya. 
// Sdekat' vivod v vide ravnobedrennogo treugolnika
    
int[,] GeneratePascalTriangle(int N)
    {
        int[,] triangle = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            triangle[i, 0] = 1;
            triangle[i, i] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
            }
        }
        return triangle;
    }

void PrintPascalTriangle(int[,] triangle)
    {
        int N = triangle.GetLength(0);

        // Pronađi maksimalnu vrijednost u posljednjem retku kako bismo pravilno formatirali ispis.
        int maxVal = triangle[N - 1, N / 2];

        for (int i = 0; i < N; i++)
        {
            int numSpaces = (N - i - 1) * (maxVal.ToString().Length + 1) / 2;
            Console.Write(new string(' ', numSpaces));

            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{triangle[i, j]} ");
            }
            Console.WriteLine();
        }
    }

int GetInfo(string msg)
    {
        Console.Write(msg);
        int inputNum = Convert.ToInt32(Console.ReadLine());
        return inputNum;
    }

int N = GetInfo("Vvedite kolichestvo strok Paskalya: ");
int[,] pascalTriangle = GeneratePascalTriangle(N);
PrintPascalTriangle(pascalTriangle);