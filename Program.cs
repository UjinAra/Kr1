// из массива строк выбрать массив стро с длинной не более 3 сим

using static System.Console;
using System.Collections.Generic;
Clear(); 

string  ReadFromConsole (string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return Convert.ToString(ReadLine());
}

string strMass = ReadFromConsole ("Введите массив чисел или символов через запятую");

string[] dataStr = strMass.Split(',')
                           .ToArray();                    

int j=0;
string[] dataStrRes= new string [dataStr.Length];
int i;
for (i=0; i < dataStr.Length; i++)
{
    if (dataStr[i].Length<=3)
    {
        dataStrRes[j] = dataStr[i];
        j++;
    }
}
j=i-j;
Array.Resize(ref dataStrRes, i-j);
WriteLine ("Массив выражений не более 3-х символов: ");
for (i = 0; i < dataStrRes.Length; i++)
    {
    Write($"{dataStrRes[i]}, ");
    }  
WriteLine();


