//Итоговая контрольная работа
// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк,длина которых меньше либо равна 3-м символам. Первоначальный массив 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//["hello","2", "world",:-)"]->["2",":-)"]
//["1234","1567","-2","computer science"]->["-2"]
//["Russia","Denmark","Kazan"]->[]


// Вводим количество строк массива (количество индексов)
Console.Write("Введите количество элементов массива: ");
int elements = int.Parse(Console.ReadLine() ?? "0");

string[] array = new string[elements];
for (int i = 0; i < array.Length; i++)
{
    // Ввод случайных символов массива с клавиатуры (строки)
    Console.Write($"Введите элемент массива под индексом {i}: ");
    string res = (Console.ReadLine() ?? "0");
    array[i] = res;
}
// Показываем пользователю введенные строки массива
Console.WriteLine();
Console.Write("Заданный массив:[");
Console.Write(string.Join(",", array));
Console.Write("]");
// вводим переменную, в которую запишем количество строк, длина которых 3 символа и меньше
int count = 0;
int maxElements = 3;
// запуск цикла по заданным строкам массива
for (int i = 0; i < array.Length; i++)
{
    // Вычисляем количество строк, длинна которых меньше либо равна 3 символов
    if (array[i].Length <= maxElements)
    {
        count++;
    }
}
// выводим полученный массив 
Console.WriteLine();
Console.Write("Сформированный массив: [");

// Создаем массив результатов размером count
string[] arrEnd = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= maxElements)

    {
        arrEnd[j] = array[i];
        if (i<array.Length-1)
        {
         Console.Write( arrEnd[j]+",");
        }
        else
        Console.Write(arrEnd[j]);
         j++;
    }
}
Console.Write("]");


