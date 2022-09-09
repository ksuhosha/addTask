// Создать коллекцию в виде динамического массива.

List<int> lst = new List<int>();

Console.WriteLine("Исходное количество элементов: " + lst.Count);

Console.WriteLine();

Console.WriteLine("Добавить 6 элементов");

// Добавить элементы в динамический массив.

lst.Add(123);

lst.Add(456);

lst.Add(78);

lst.Add(9);

lst.Add(1);

lst.Add(5);

Console.WriteLine("Количество элементов: " + lst.Count);

// Отобразить содержимое динамического массива,

// используя индексирование массива.

Console.Write("Текущее содержимое: ");

for (int i = 0; i < lst.Count; i++)

    Console.Write(lst[i] + " ");

Console.WriteLine("\n");
System.Console.WriteLine(lst[2]);