/* Zadacha 54 
void Sortirovka(int n, int m)
{
  int[,] array = new int[n,m];
  Random rand = new Random();
  Console.WriteLine("Массив до сортировки");
  for (int i = 0; i<n; i++)
  {
    for (int j = 0; j<m; j++)
    {
        array[i,j] = rand.Next(100);
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
  }
   for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < m; j++)
    {
      for (int k = 0; k < m - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int sort = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = sort;
        }
      }
    }
  }
   Console.WriteLine("Массив после сортировки");
   for (int i = 0; i<n; i++)
  {
    for (int j = 0; j<m; j++)
    {
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
  }
}
Sortirovka(4,4);
*/
/* Zadacha 56 
 int MinStroka(int n, int m)
{
  int[,] array = new int[n,m];
  int[] summa = new int[n];
  Random rand = new Random();
  Console.WriteLine("Массив");
  for (int i = 0; i<n; i++)
  {
    for (int j = 0; j<m; j++)
    {
        array[i,j] = rand.Next(100);
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
  }
  for (int i = 0; i<n; i++)
  {
    for (int j = 0; j<m; j++)
    {
      summa[i] = summa[i]+ array[i,j];
    }
  }
  Console.WriteLine("Массив сумм строк");
 for (int i = 0; i<n; i++)
 {
  Console.Write(" " + summa[i]);
 }
 int min = 10000;
 int k = 0;
 for (int i = 0; i<n; i++)
 {
  if (summa[i]<min)
  {
    min = summa[i];
    k = i;
  }
 }
return k;
} 
int result = MinStroka(4,4);
Console.WriteLine("");
Console.WriteLine("Строка с наименьшей суммой элементов  = " + result);
*/
/* Zadacha 62 
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/