Console.WriteLine("Введите длину массиву");
int N = Convert.ToInt32(Console.ReadLine());
int[] Cube = new int[N];
for (int index = 0; index < N; index++)
{
    Cube[index] = Convert.ToInt32(Math.Pow((index + 1),3));
    Console.WriteLine(Cube[index]);
}