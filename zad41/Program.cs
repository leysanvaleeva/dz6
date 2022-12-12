// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество цифр, которые будут использованы в этой программе."); 
int size = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите целыe числа, через 'enter'."); 
int[] array = new int [size]; 
for (int i=0; i<size; i++) 
array[i]=Convert.ToInt32(Console.ReadLine()); 
PrintArray(array); 
Count (array);
 
void PrintArray(int[] array) 
{ 
    foreach (int el in array)   
        Console.Write($"{el} "); 
        Console.WriteLine(); 
}

void Count (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count+=1;
    }
    System.Console.WriteLine($"Пользователь ввел {count} чисел больше 0.");
}