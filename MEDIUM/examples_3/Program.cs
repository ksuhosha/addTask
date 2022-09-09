Random rnd = new Random();
int length = 20;
int[] array = new int[length];
int[] FillArray(int N)
{
    int[] array = new int[N];

    for (int i = 0; i < N; i++)
    {
        array[i] = rnd.Next(0, 500);
    }
    return array;
}
array = FillArray(length);
System.Console.WriteLine(string.Join(", ", array));
int lengthWave = 1;
int countWave = 0;
for (int i = 1; i < length; i++)
{
    if (i == length - 1)
    {
        if (array[i - 1] < array[i] && lengthWave + 1 >= 2) countWave++;
       else if (array[i - 1] > array[i] && lengthWave >= 2) countWave++;
    }
    else if (array[i - 1] < array[i]) lengthWave++;
    else if (array[i - 1] > array[i] && lengthWave >= 2)
    {
        lengthWave = 1;
        countWave++;
    }
    else lengthWave = 1;
}
System.Console.WriteLine($"Волн в массиве {countWave} ");








/* Под подъемом в массиве будем понимать его подпоследовательность из
двух и более элементов, которая не убывает. Подъем заканчивается, если
встретился элемент, меньший предыдущего или достигнут конец массива.
Например, arr = [1 2 6 2 0], его подъем – [1 2 6]. Подъемы [1 2], [2 6] внутри
этой подпоследовательности [1 2 6] не учитываем.
Другой пример, arr = [1 2 6 2 0 5 9 12 47 47 2], его подъемы – [1 2 6], [0 5
9 12 47 47].
Сгенерировать массив из N случайных натуральных чисел. Определить,
сколько в нем подъемов. */