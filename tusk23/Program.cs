// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

void B(int[] B)
{
  int counter = 0;
  int length = B.Length;
  while (counter <  length)
  {
    B[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[A+1];
B(arry);
PrintArry(arry);