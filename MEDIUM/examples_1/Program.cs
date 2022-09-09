int N = 0;
List<int> array = new List<int>();
int sum = 0;
Random random = new Random();
//int num = rnd;
while (sum != 26)
{
    sum = 0;
    int rnd = random.Next(1, 1000);
    array.Add(rnd);

    while (rnd != 0)
    {
        sum += rnd % 10;
        rnd /= 10;
    }

    if (N != 0)
    {
        int i = N;
        while (array[i] < array[i - 1])
        {
            int tmp = array[i];
            array[i] = array[i - 1];
            array[i - 1] = tmp;
            i--;
            if (i==0) break;
        }
    }
    N++;

}
System.Console.WriteLine(array);
System.Console.WriteLine(string.Join(", ", array)+ " Stop");

/* Задача 1
Реализовать алгоритм, который выводит на экран возрастающую
последовательность случайных чисел от 1 до 1000. Как только сумма цифр
очередного числа в последовательности достигнет 26, остановить генерацию,
вывести на экран сообщение «Stop».
Примеры
5 9 50 69 255 899 Stop
50 633 655 700 854 999 Stop */