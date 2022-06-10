// задача 3
// заданы 2 массива. массив data и массив info.
// в массиве info хранятся двоичные представления нескольких чисел (без разделителя)
// в массиве data хранится информация о количестве бит, которые занимают числа из массива info.
// напишите программу, которая составит массив десятичных представлении чисел массива data
// с учетом информации из массива info
//Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
//третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
//Пример:
//входные данные:
//data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
//info = {2, 3, 3, 1 }
//выходные данные:
//1, 7, 0, 1

int[] dataA = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] infoA = {2, 3, 3, 1 };

int[] ResultArrayF (int[] data, int[] info)
{
    int [] resultArray = new int [info.Length];
    int dataIndex = 0;
    for (int infoIndex = 0; infoIndex < info.Length; infoIndex++)
    {
        int result = 0;
        int count = 0;
        for (int i = info[infoIndex]-1; i >= 0; i--)
        {
            result = result + data[dataIndex + i] * (int)Math.Pow(2, count);
            //Для перевода двоичного числа в десятичное необходимо это число представить в 
            //виде суммы произведений степеней основания двоичной системы счисления на соответствующие 
            //цифры в разрядах двоичного числа.
            count++;
        }
        dataIndex = dataIndex + info[infoIndex];
        resultArray[infoIndex] = result;
    }
    return resultArray;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(ResultArrayF(dataA, infoA));