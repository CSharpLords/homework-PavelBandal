﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты - супергерой. Твоя задача - вызволить принцессу/принца из плена Всемирной Сети, куда она/он попала, по неосторожности ткнув в рекламный баннер. В самом начале ты только-только получил известие о неприятности, и стоишь перед выбором:Поиграть в доту - 1, или узнать на каком сайте она застряла - 2");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("О да! Ты про Доты! О нет... Принцесса у Марио!");
                Console.ReadLine();
            }
            else if (a == 2)
            {
                Console.WriteLine("Принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob. Варианты поведения:1-Послушаться совета в адресе сайта и поиграть в Доту,2-Перейти на сайт,3-Обновить антивирус, а потом перейти на сайт.");
                int b = int.Parse(Console.ReadLine());
                if (b == 2)
                {
                    Console.WriteLine("Заразился тем же вирусом, что и принцесса,ты гений!");
                    Console.ReadLine();
                }
                else if (b == 1)
                {
                    Console.WriteLine("Другой хакер спас принцессу.Но ты хорош в Доте!");
                    Console.ReadLine();
                }
                else if (b == 3)
                {
                    Console.WriteLine("Ты встречаешь противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2? Варианты поведения:1-А, ну ее, математика для нубов! Пойду в Доту поиграю!,2-Проверить исходный код Капча-Монстра,3-Ответить монстру: 6.");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        Console.WriteLine("Мда,ничему тебя жизнь не учит.");
                        Console.ReadLine();
                    }
                    else if (c == 3)
                    {
                        Console.WriteLine("Проигрыш - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2)");
                        Console.ReadLine();
                    }
                    else if (c == 2)
                    {
                        Console.WriteLine("Ты вскрываешь код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне! Варианты поведения:1-Круто, пойду попробую так в своей программе!,2-Ответить монстру: 6,3-Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра.");
                        int d = int.Parse(Console.ReadLine());
                        if (d == 1)
                        {
                            Console.WriteLine("Принцесса заблудилась во Всемирной Сети, пока ты ковырялся не там, где надо");
                            Console.ReadLine();
                        }
                        else if (d == 2)
                        {
                            Console.WriteLine("Зря, что ли, подвох находил??");
                            Console.ReadLine();
                        }
                        else if (d == 3)
                        {
                            Console.WriteLine("Капча-Монстр хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2 ) * 2? Варианты поведения:1-Ответить монстру: 8,2-Не царское это дело, лень считать, иду в Доту.");
                            int e = int.Parse(Console.ReadLine());
                            if (e == 2)
                            {
                                Console.WriteLine("Тебе дать номер общества анонимных игроманов?");
                                Console.ReadLine();
                            }
                            else if (e == 1)
                            {
                                Console.WriteLine("Капча-Монстр обиженно сопит: Как ты догадался? Я же спрятал скобки!, отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0. Файл-лекарство можно найти здесь: C:Antiviruscure.exe. Варианты действий:1-Отправить лекарство принцессе по почте и пойти в Доту 2-Записать лекарство на флешку и пойти к принцессе.");
                                int q = int.Parse(Console.ReadLine());
                                if (q == 1)
                                {
                                    Console.WriteLine("Тупость людская границ не знает.У принцессы комп сломан, гений!");
                                    Console.ReadLine();
                                }
                                else if (q == 2)
                                {
                                    Console.WriteLine("ПОБЕДААААААААААА!!!!!!");
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
    



