System.Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine());
int length = 0;
int tmp = num;
List<int> listSimplNum = new();
List<int> listUnderNum = new();
while (tmp != 0)
{
    tmp /= 10;
    length++;
}
bool CheckSimplNum(int num)
{
    if(num < 2) return false;
    else if (num < 4) return true;
    else if (num % 2 == 0) return false;
    else
    {
        int length = (int)Math.Sqrt(num) + 1;
        for (int i = 3; i <= length; i += 2)
        {
            if (num % i == 0) return false;
        }
    }
    return true;
}
for (int i = 0; i < length - 1; i++)
{

    for (int j = 0; j < length - i; j++)
    {
        tmp = num;
        int div1 = (int)Math.Pow(10, length - j);
        int div2 = (int)Math.Pow(10, length - (j + 1) - i);
        tmp = tmp % div1 / div2;
        if (!listUnderNum.Contains(tmp))
        {
            listUnderNum.Add(tmp);
        }

    }
}
for (int i = 0; i < listUnderNum.Count; i++)
{
    if (CheckSimplNum(listUnderNum[i])) listSimplNum.Add(listUnderNum[i]);
}
Console.WriteLine("список подчисел");
Console.WriteLine(string.Join("\n", listUnderNum));
Console.WriteLine("список простых чисел");
Console.WriteLine(string.Join(", ", listSimplNum));