// string[,] table = new string[2, 5];

// // String.Empty - инициализация для строк
// // table[0, 0]  table[0, 1]  table[0, 2]... table[0, 4]
// // table[1, 0]  table[1, 1]  table[1, 2]... table[1, 4]
// table[1, 2] = "Слово";
// // Строки, длина указывается из заданых параметров
// for (int rows = 0; rows < 2; rows++)
// {   // Столбцы, длина указывается из заданых параметров
//     for (int columns = 0; columns < 5; columns++) 
//     {   // Добавляем "-" с двух сторон, чтобы пустые строки сделать видимыми
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

//Пример с числами
/*
int[,] matrix = new int[3, 4];
PrintArray(matrix);//Покаазываем матрицу из нулей
FillArray(matrix);//Заполняем матрицу рандомными числами
Console.WriteLine("Заполненная матрица:");
PrintArray(matrix);//Показываем матрицу с числами 

void PrintArray(int[,] matr)
{
    //Можно в длину поместить переменную через новую команду
    //"Имя переменной".GetLength()       0 - это 3 из переменной matrix
    for (int i = 0; i < matr.GetLength(0); i++)
    {                                     // 1 - это 4 из переменной matrix
        for (int j = 0; j < matr.GetLength(1); j++)
        {//Выводим без Line, чтобы каждый символ не сносился 
         // на новую строчку, после фигурных скобок ставим пробел.
         // При завершении цикла столбиков, принудительно вызываем 
         // еще один Console.WriteLine();
            Console.Write($"{matr[i, j]} ");
        }
        // Принудительно вызываем переход на ноувую строку
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j] = new Random().Next(1, 10); 
        }
    } 
    
}
*/

//Пример с закрашиванием картинки
//с помощью рекурсии - когда метод вызывает сам себя.
//В данной задаче это будет в методе PrintImage.

/*
int[,] pic = new int[,];
PrintImage(pic);
//Задаем любое значение которое находится внутри картинки
FillImage(13, 13); 
PrintImage(pic);
// Чтобы PrinArray выводил только 1, без 0,
// вызываем другую функцию PrintImage
void PrintImage(int[,] image)
{
   
    for (int i = 0; i < image.GetLength(0); i++)
    {                                    
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.Write($" ");//Печатаем просто пробел
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
//Создаем функцию для закрашивания 
// Задаем начало, с какой строчки и столбика начать
void FillImage(int row, int col)
{
   if (pic[row, col] == 0)//Если пиксель равен 0(не закрашен)
   {
        pic [row, col] = 1;//То закрашиваем
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
   }
}
*/

//Задача с вычислением факториала через рекурсию

//int не вмещает большое количество цифр, поеэтому берем double,
//он справится
/*
double Factorial(int n)
{   // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    //В ином случае возвращаем:
    else return n* Factorial(n-1);//Текущие значение умножаем
    //на факториал предыдущего числа
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");// 1*2*3=6
}
*/

//Числа фибоначи

// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)
/*
double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
//Если длину указывать выше 40, то консоль начнет
//думать с каждым разом дольше
for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
*/