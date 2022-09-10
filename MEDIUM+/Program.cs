System.Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine());
int length = 0;
int tmp = num;
List<int> listSimplNum = new();
List<int> listUnderNum = new();
while(tmp != 0)
{
    tmp /= 10;
    length++;
}

for(int i = 0; i < length - 1; i++)
{

    for(int j = 0; j < length - i; j++)
    {
        tmp = num;
        int div1 = (int)Math.Pow(10,length - j);
        int div2 = (int)Math.Pow(10,length - (j + 1) - i);
        tmp = tmp % div1 / div2;
        if(listUnderNum.Count == 0)
        {
            listUnderNum.Add(tmp);
        }
        for(int k = 0; k < listUnderNum.Count; k++)
        {
            if(listUnderNum[k] == tmp)
            {
                break;
            }
            else if(k == listUnderNum.Count - 1)
            {
                listUnderNum.Add(tmp);
            }
        }
    }
}

for(int i = 0; i < listUnderNum.Count; i++)
{
    if(listUnderNum[i] is 2 or 1 or 3)
    {
        listSimplNum.Add(listUnderNum[i]);
    }
    else if(listUnderNum[i] % 2 != 0)
    {
        length = (int)Math.Round(Math.Sqrt(listUnderNum[i]) + 1,0);
        int count = 0;
        for(int j = 1; j <= length; j += 2)
        {
            if(listUnderNum[i] % j == 0)
            {
                count++;
            }
            if(count == 2)
            {
                break;
            }
            else if(j == length - 1 || j == length)
            {
                listSimplNum.Add(listUnderNum[i]);
            }
        }
    }
}
Console.WriteLine("список подчисел");
Console.WriteLine(string.Join("\n",listUnderNum));
Console.WriteLine("список натуральных чисел");
Console.WriteLine(string.Join(", ",listSimplNum));