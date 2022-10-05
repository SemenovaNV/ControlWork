// Задача: Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длины которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] arrayStart = { "hello", "2", "world", ":-)" };
Console.WriteLine($"[{String.Join(", ", arrayStart)}]");

string[] arrayFinish = FillTheFinishArray(arrayStart);
Console.WriteLine($"[{String.Join(", ", arrayFinish)}]");

string[] FillTheFinishArray(string[] arrStart)
{
    int count = 0;
    string[] arrFinish = new string[count];

    foreach(var item in arrStart)
    {
        if (item.Length <= 3)
        {            
            Array.Resize(ref arrFinish, arrFinish.Length + 1);
            arrFinish[count] = item;
            count++;
        }
    }
    return arrFinish;
}
