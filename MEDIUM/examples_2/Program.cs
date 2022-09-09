Random random = new Random();
int[] fiveSimpleNum = new int[5];
int RandNum()
{
    int num = random.Next(1, 1000);
    if ((num * num) % 10 != 1) // его квадрат не оканчивается на 1
    {
        int sum = 0;
        int tmp = num;
        while (tmp != 0) //сумма цифр числа
        {
            sum += tmp % 10;
            tmp = tmp / 10;
        }
        if (sum >= 10 && sum <= 20) //сумма его цифр лежит в диапазоне от 10 до 20
        {
            if (num % 2 == 0) return RandNum();
            int count = 0;
            for (int i = 1; i < (Math.Sqrt(num)+1) ; i += 2) // проверка на простое
            {
                if (num % i == 0) count++;
                if (count == 2) return RandNum();
            }
            return num;
        }
        else return RandNum();
    }
    else return RandNum();

}

for (int i = 0; i < 5; i++)
{
    fiveSimpleNum[i] = RandNum();
}
System.Console.WriteLine(string.Join(", ", fiveSimpleNum));

/* Михаил интересуется созданием простых чисел. Его интересуют
простые числа с некоторыми характеристиками:
• число сгенерировано случайным образом;
• его квадрат не оканчивается на 1;
• сумма его цифр лежит в диапазоне от 10 до 20
Сгенерировать пять простых чисел, удовлетворяющих пожеланиям
Михаила, и вывести их на экран.
Пример
97 397 83 317 383 */