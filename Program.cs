// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задание 1
// Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.
//  Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz.
//   Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3 и 5
//    нужно вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число.
// Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.


// Console.WriteLine("enter the number: ");
// string numberStr = Console.ReadLine();

// int number = int.Parse(numberStr);

// if(number % 3 == 0) {
//     Console.WriteLine("Fizz \n");
// }

// if(number % 5 == 0) {
//     Console.WriteLine("Buzz \n");
// }

// if(number % 3 == 0 && number % 5 == 0) {
//    Console.WriteLine("Fizz \n");
//     Console.WriteLine("Buzz \n");
// }
 

//  if(number % 3 != 0 && number % 5 != 0) {
//    Console.WriteLine(number + "\n");
// }

// if(number < 0 || number > 100){
//     Console.WriteLine("error \n");
   
// }
 



// Задание 2
// Пользователь вводит с клавиатуры два числа. Первое число — это значение, 
// второе число процент, который необходимо посчитать. Например, мы ввели 
// с клавиатуры 90 и 10. Требуется вывести на экран 10 процентов от 90. Результат: 9.


// Console.WriteLine("enter first number: ");
// string num1 = Console.ReadLine();

// Console.WriteLine("enter second number: ");
// string num2 = Console.ReadLine();

// int number1 = int.Parse(num1);  
// int number2 = int.Parse(num2);

// double result = (number1 * number2) / 100;
// Console.WriteLine("result: " + result);




// Задание 3
// Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число, 
// содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.


// Console.WriteLine("enter first number: ");
// string num1 = Console.ReadLine();

// Console.WriteLine("enter second number: ");
// string num2 = Console.ReadLine();

// Console.WriteLine("enter third number: ");
// string num3 = Console.ReadLine();

// Console.WriteLine("enter fourth number: ");
// string num4 = Console.ReadLine();

// string result = num1 + num2 + num3 + num4;
// int res = int.Parse(result);
// Console.WriteLine(res);



// Задание 4
// Пользователь вводит шестизначное число. После чего пользователь 
// вводит номера разрядов для обмена цифр. Например, если пользователь ввёл
//  один и шесть — это значит, что надо обменять местами первую и шестую цифры.
// Число 723895 должно превратиться в 523897.
// Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.


// Console.WriteLine("enter a six digit number: ");
// string number = Console.ReadLine();

// int num = int.Parse(number);




// if(num >= 100000 && num <= 999999){
// int first = num / 100000;
// int last = num % 10;

// int withoutLast = num / 10;
// int withoutFirst = withoutLast % 10000;
// int result = last * 100000 + withoutFirst * 10 + first;

// Console.WriteLine(result);

// }
// else{
//     Console.Write("error");
// }



// Задание 5
// Пользователь вводит с клавиатуры дату. Приложение должно отобразить 
// название сезона и дня недели. Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.

// Console.WriteLine("enter a day: ");
// string dayStr = Console.ReadLine();

// int day = int.Parse(dayStr);

// Console.WriteLine("enter a month: ");
// string monthStr = Console.ReadLine();

// Console.WriteLine("enter a year: ");
// string yearStr = Console.ReadLine();


// string text = "";

// if (monthStr == "1")
// {
//     text = "January";
// }
// else if (monthStr == "2")
// {
//     text = "February";
// }
// else if (monthStr == "3")
// {
//     text = "March";
// }
// else if (monthStr == "4")
// {
//     text = "April";
// }
// else if (monthStr == "5")
// {
//     text = "May";
// }
// else if (monthStr == "6")
// {
//     text = "June";
// }
// else if (monthStr == "7")
// {
//     text = "July";
// }
// else if (monthStr == "8")
// {
//     text = "August";
// }
// else if (monthStr == "9")
// {
//     text = "September";
// }
// else if (monthStr == "10")
// {
//     text = "October";
// }
// else if (monthStr == "11")
// {
//     text = "November";
// }
// else if (monthStr == "12")
// {
//     text = "December";
// }
// else
// {
//     text = "incorrect month"; 
// }

// string dayText = "";

// if (day >= 1 && day <= 31)
// {
//    switch (day % 7)
//     {
//         case 1:
//             dayText = "Monday";
//             break;
//         case 2:
//             dayText = "Tuesday";
//             break;
//         case 3:
//             dayText = "Wednesday";
//             break;
//         case 4:
//             dayText = "Thursday";
//             break;
//         case 5:
//             dayText = "Friday";
//             break;
//         case 6:
//             dayText = "Saturday";
//             break;
//         case 0:
//             dayText = "Sunday";
//             break;
//     }
// }


// Console.Write(text + " " + dayText + "\n");





// Задание 6
// Пользователь вводит с клавиатуры показания температуры.
//  В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот.

// Console.WriteLine("make your choice 1 - To Gradus, 2 - To Fahrenheit: ");
// string answer = Console.ReadLine();
// int answ = int.Parse(answer);


// Console.WriteLine("enter the temperature: ");
// string temperature = Console.ReadLine();
// double temp = double.Parse(answer);

// if (answ == 1){
// double result = ((temp - 32) * 5) / 9;
//   Console.WriteLine(result + "°C \n");
// }


// if(answ == 2){
//     double result = (temp * 9) / 5 + 32;
//     Console.WriteLine(result + "°F \n");
// }




// Задание 7
// Пользователь вводит с клавиатуры два числа. Нужно показать все четные числа
//  в указанном диапазоне. Если границы диапазона указаны неправильно требуется произвести нормализацию границ. 
//  Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.


Console.WriteLine("enter a number: ");
string numStr = Console.ReadLine();

Console.WriteLine("enter a number: ");
string numStr2 = Console.ReadLine();

int num1 = int.Parse(numStr);
int num2 = int.Parse(numStr2);

if(num1 <  num2){
    
    for(int i = num1; i < num2; i++) {
        if(i % 2 == 0){
        Console.Write(i + " ");
        }
    }
}
else if(num1 > num2){
      int temp = num1;
    num1 = num2;
    num2 = temp;

 for(int i = num1; i < num2; i++) {
        if(i % 2 == 0){
        Console.Write(i + " ");
        }
    }
}
else if(num1 == num2){
    Console.Write("error" + "\n");
}