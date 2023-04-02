//Вид 1 не принимает, не возвращает
/*
void Method1() //Cздали метод
{
    Console.WriteLine("Автор Имя");
}
Method1(); //Вызываем метод
*/
//Вид 2 принимает, не возвращает
//Если метод принимает 1 аргумент
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");
//Если метод принимает больше 1 аргумента, например текст и числа

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}//  аргумент  значение
//Method21(msg: "Текст", count: 4);//Сколько раз мы хотим увидеть сообщение
//Если аргументу(иминованнному) присвоить значение, то их можно менять местами
Method21(count: 4, msg: "Текст");
*/

//Вид 3 не принимают, возвращают
//Тут обязательно нужно указывать тип данных, которые хотим вернуть
/*
int Method3()
{
    return DateTime.Now.Year;//В методах с возвращением обязательн команда Return
}//DateTime.Now.Year - это помошник, выводящий сегодняшний год
int year = Method3();//Вкладываем в переменную результат от верхней работы 
//с помощью созданного метода
Console.WriteLine(year);
*/

//Вид 4 принимают, возвращают
//1 способ
/*
string Method4(int count, string text)
{
    int i = 0;//Создаем цикл
    string result = String.Empty;//Результат заполнили пустой строкой при помощи String.Empty
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//Чтобы вызвать метод, надо привязать его к переменной
string res = Method4(10, "Сделал");
Console.WriteLine(res);
*/

//2 способ через for
/*
string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)//Берет в себя сразу инициализацию щетчика, проверка условия, инкримент
    {
        result = result + text;
    }

    return result;
}

string res = Method4(10, "Сделал");
Console.WriteLine(res);
*/

//Так же есть цикл в цикле
//Таблица умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//Маленькие буквы "к" замениь большими, а юольшие "С" заменить на маленькие,
//пробелы замениь на черточки
/*
string  text = "- Я думаю, - сказать князь, улыбаясь, - что, "
             + "ежели бы вас послали вместо нашего милого Винцегероде,"
             + "вы бы взяли приступом согласие прусского короля. "
             + "Вы так красноречивы. Вы двдите мне чаю?";
// string s = "qwerty"
//             012345
// s[3} // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";//Если старый символ совпал с новым, то пишем эту строку
        else result = result + $"{text[i]}";
    }
    return result;
}//                       не двойные кавычки
string newText = Replace(text, ' ', '|');//Вызываем метод через переменную и заменяем пробелы на черточки
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/

//Метод сартировки через массив

int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)//Создаем метот показывающий массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)//Создаем метод который сортирует массив
{
    for (int i = 0; i < array.Length - 1; i++)//Ищем минимальное число
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)//Ищем максимальное число
        {
            if (array[j] < array[min]) min = j;
        }
        int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;
    }
}
PrintArray(array);//Показываем исходный массив
SelectionSort(array);//Вызываем сортированный массив 
PrintArray(array);//Показываем сортированный массив