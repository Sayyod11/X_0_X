using System;

class Program
{
    static void Main()
    {
        //Обьявляем массив, задаем значение
        char[,] numbers = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        //Создает сетку 3:3
        int rows = numbers.GetUpperBound(0) + 1;    
        int columns = numbers.Length / rows; 
        int value = 0;
  
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{numbers[i, j]} \t");
            }
            Console.WriteLine();

        }  
        //Создание основной базы переходов и выигрыша на основе проверки на истинность
        bool a1 = false;
        bool a2 = false;
        bool a3 = false;
        bool a4 = false;
        bool a5 = false;
        bool a6 = false;
        bool a7 = false;
        bool a8 = false;
        bool a9 = false;
        bool res = true;    
        bool aa1 = false;
        bool aa2 = false;
        bool aa3 = false;
        bool aa4 = false;
        bool aa5 = false;
        bool aa6 = false;
        bool aa7 = false;
        bool aa8 = false;
        bool aa9 = false;
        

            //Начало скрипта 
            Console.WriteLine("Нажмите (X) для начала игры");
            char num = char.Parse(Console.ReadLine());
            Label1:
            //Проверяем, нажал ли он на x
            if (num == 'X' || num == 'x')
            {
                //Блок кодов, за основу которой я взял первое условие перехода (на истинносте)
                if (res == true)
                {
                    Console.WriteLine("Ходит игрок 1 (X)");
                    int choise = int.Parse(Console.ReadLine());
                    //Тут уже ReadLine темка 
                    if (choise == 1)
                    {
                        if (numbers[0, 0] == 'X' || numbers[0, 0] == 'O')
                        {    
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        a1 = true;
                        numbers[0, 0] = 'X';
                        value++;
                        res = false;
                    }
                    if (choise == 2)
                    {
                        if (numbers[0, 1] == 'X' || numbers[0, 1] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        
                        numbers[0, 1] = 'X';
                        value++;
                        a2 = true;
                        res = false;
                    }
                    if (choise == 3)
                    {
                        if (numbers[0, 2] == 'X' || numbers[0, 2] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        a3 = true;
                        numbers[0, 2] = 'X';
                        value++;
                        res = false;
                    }
                    if (choise == 4)
                    {
                        if (numbers[1, 0] == 'X' || numbers[1, 0] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                            
                        }
                        a4 = true;
                        numbers[1, 0] = 'X';
                        value++;
                        res = false;
                    }
                    if (choise == 5)
                    {
                        if (numbers[1, 1] == 'X' || numbers[1, 1] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        a5 = true;
                        numbers[1, 1] = 'X';
                        value++;
                        res = false;
                    }
                    if (choise == 6)
                    {
                        if  (numbers[1, 2] == 'X' || numbers[1, 2] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        a6 = true;
                        numbers[1, 2] = 'X';
                        value++;
                        res = false;
                    }
                    if (choise == 7)
                    {
                        if (numbers[2, 0] == 'X' || numbers[2, 0] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        a7 = true;
                        numbers[2, 0] = 'X';
                        value++;
                        res = false;
                    }
                    if (choise == 8)
                    {
                        if (numbers[2, 1] == 'X' || numbers[2, 1] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        a8 = true;
                        numbers[2, 1] = 'X';
                        value++;
                        res = false;
                    }
                    if (choise == 9)
                    {
                        if (numbers[2, 2] == 'X' || numbers[2, 2] == 'O')
                        {
                            Console.WriteLine("Ячейка занята");
                            goto Label1;
                        }
                        a9 = true;
                        numbers[2, 2] = 'X';
                        value++;
                        res = false;
                    }
                    /*if (choise != numbers.Length)
                    {
                        Console.WriteLine("Неверный ввод");
                        goto Label1;
                    }*/
                    //Чтобы игроки могли понять ориентацию
                    Console.WriteLine("Вот ход икса");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write($"{numbers[i, j]} \t");
                        }
                        Console.WriteLine();
    
                    }
                    //Условие на победу
                    if (a1 == true && a2 == true && a3 || a4 == true && a5 == true && a6 == true || a7 == true && a8 == true && a9 == true || a1 == true && a4 == true && a7 == true || a2 == true && a5 == true && a8 == true || a3 == true && a6 == true && a9 == true || a1 == true && a5 == true && a9 == true || a3 == true && a5 == true && a7 == true)
                    {
                        Console.WriteLine("Игрок 1 победил");
                        return;
                    }
                }
                //Тот же самый видо измененный код для второго игрока
                if (res == false)
                {
                    Label:
                    Console.WriteLine("Ходит игрок 2 (O)");
                    int choise1 = int.Parse(Console.ReadLine());
                    if (choise1 == 1)
                    {
                        
                        if (numbers[0, 0] == 'O' || numbers[0, 0] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[0, 0] = 'O';
                        value++;
                        aa1 = true;
                        res = true;
                        
                    }
                    if (choise1 == 2)
                    {
                        
                        if (numbers[0, 1] == 'O' || numbers[0, 1] == 'X')
                        {
                            Console.WriteLine( "Эта ячейка уже занята");
                            goto Label;
                            
                        }
                        numbers[0, 1] = 'O';
                        value++;
                        aa2 = true;
                        res = true;
                    }
                    if (choise1 == 3)
                    {
                        
                        if (numbers[0, 2] == 'O' || numbers[0, 2] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[0, 2] = 'O';
                        value++;
                        aa3 = true;
                        res = true;
                    }
                    if (choise1 == 4)
                    {
                        
                        if (numbers[1, 0] == 'O' || numbers[1, 0] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[1, 0] = 'O';
                        value++;
                        aa4 = true;
                        res = true;
                    }
                    if (choise1 == 5)
                    {
                        
                        if (numbers[1, 1] == 'O' || numbers[1, 1] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[1, 1] = 'O';
                        value++;
                        aa5 = true;
                        res = true;
                    }
                    if (choise1 == 6)
                    {
                        if (numbers[1, 2] == 'O' || numbers[1, 2] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[1, 2] = 'O';
                        value++;
                        aa6 = true;
                        res = true;
                    }
                    if (choise1 == 7)
                    {
                        
                        if (numbers[2, 0] == 'O' || numbers[2, 0] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[2, 0] = 'O';
                        value++;
                        aa7 = true;
                        res = true;
                    }
                    if (choise1 == 8)
                    {
                        
                        if (numbers[2, 1] == 'O' || numbers[2, 1] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[2, 1] = 'O';
                        value++;
                        aa8 = true;
                        res = true;
                    }
                    if (choise1 == 9)
                    {
                        
                        if (numbers[2, 2] == 'O' || numbers[2, 2] == 'X')
                        {
                            Console.WriteLine("Эта ячейка уже занята");
                            goto Label;
                        }
                        numbers[2, 2] = 'O';
                        value++;
                        aa9 = true;
                        res = true;
                    }

                    if (aa1 == true && aa2 == true && aa3 || aa4 == true && aa5 == true && aa6 == true || aa7 == true && aa8 == true && aa9 == true || aa1 == true && aa4 == true && aa7 == true || aa2 == true && aa5 == true && aa8 == true || aa3 == true && aa6 == true && aa9 == true || aa1 == true && aa5 == true && aa9 == true || aa3 == true && aa5 == true && aa7 == true)
                    {
                        Console.WriteLine("Игрок 2 победил");
                        return;
                    }
                    /*if (choise1 != numbers.Length)
                    {
                        Console.WriteLine( "Неверный ввод");
                        goto Label;
                    }*/
                    
                    Console.WriteLine("Вот ход  нолика");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write($"{numbers[i, j]} \t");
                        }
                        Console.WriteLine();

                    }
                }
            goto Label1;
                        

            
            
        }
        
            
    }
}
