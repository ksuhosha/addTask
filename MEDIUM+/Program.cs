System.Console.WriteLine("введите число:");
int num = Int32.Parse(Console.ReadLine());
int length = 0;
int tmp = num;
while (tmp != 0)
{
    tmp /= 10;
    length++;
}

for (int i = 0; i < length-1; i++)
{

    for (int j = 0; j < length - i; j++)
    {
        tmp = num;
        int div1 = (int)Math.Pow(10, length - (j));
        int div2 = (int)Math.Pow(10, length - (j + 1) - i);
        tmp = tmp % div1 / div2;
        System.Console.WriteLine(tmp);
    }
}