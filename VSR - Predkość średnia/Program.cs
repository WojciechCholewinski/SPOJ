int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string[] bc = Console.ReadLine().Split();
    double b = double.Parse(bc[0]);
    double c = double.Parse(bc[1]);
    Console.WriteLine((2 * b * c) / (b + c));
}