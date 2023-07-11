// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Объявление методов инициализация массивов
string[] A = new string[4];
string[] B = new string[4];

void FillArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        string str = System.String.Empty;
        Console.WriteLine("Введите строку");
        str = Console.ReadLine();
        A[i] = str;
    }
}
void PrintArray(string[] Array)
{
    string str = System.String.Empty;
    for (int i = 0; i < Array.Length; i++)
        str = string.Join(" ", Array);
    Console.WriteLine(str);
}
void Chek(string[] A, string[] B)
{
    int j = 0;
    for (int i = 0; i < A.Length; i++)
    {
        string str = A[i];
        if (str.Length <= 3)
        {
            B[j] = str;
            j++;
        }
    }
}
// Исполняемая часть программного кода
Console.Clear();
FillArray(A);
Console.Clear();
Console.WriteLine("*** Был введен массив строк ******");
PrintArray(A);
Chek(A, B);
Console.WriteLine("*** Из него строки с длинной менеe или равно 3 символам ******");
PrintArray(B);
