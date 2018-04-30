using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class Program
    {
        static bool cheatermod = false;
        static double HP = 70;
        static double DMG = 10;
        static bool haveHorse = true;
        static double money = 0;
        static bool haveSword = false;
        static bool haveArmour = false;
        static double robbersDMG = 80;
        static double robbersHP = 100;
        static double maxRobbersHP = 100;
        static double giantDMG = 100;
        static double giantHP = 200;
        static double maxGiantHP = 220;
        static void Main(string[] args)
        {
            Console.WriteLine("У героя нет ничего, кроме волосатой коровы. Даже меча, и того нет! Но он мечтает о подвигах. Пока он был в яйце, он узнал, что бухой Дядя Витя повадился от скуки крушить и ломать дома крестьян, красть скот, вытаптывать поля. Мама покормила тебя пыльцой фей и ты мгновенно вырос! Ой, ты походу Лунтик! Ты жаждешь жертвоприношений и душ невинных. Но, сначала обойдёмся двумя действиями");
            Greenfields();
            Console.ReadLine();
        }
        static void Greenfields()
        {
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Выбрать эту локацию и подойти к лавке торговца");
            Console.WriteLine("2.Послушать историю Хранителя Поля");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1)
            {
                Shop();
            }
            if (answer1 == 2)
            {
                FieldGuardian();
            }
        }
        static void Shop()
        {
            Console.WriteLine("Весенние скидки 0%! Налетай!");
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Выбрать локацию");
            Console.WriteLine("2.Продать коня");
            Console.WriteLine("3.Купить меч или доспехи");
            Console.WriteLine("4.Прослушать историю");
            Console.WriteLine("5.Купить аптечку");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                ChooseLocation();
            }
            else if (answer == 2)
            {
                if (haveHorse == true)
                {
                    haveHorse = false;
                    money = 100;
                    Console.WriteLine("Хм...Надеюсь конь молодой, а то колбаса сухой будет.А! держи 100 топиков!");
                    Console.WriteLine("Баланс: " + money);
                    Shop();
                }
                else
                {
                    Console.WriteLine("Ты что, ку-ку? Ты мне свою волосатую корову уже продал.");
                    Shop();
                }
            }
            else if (answer == 3)
            {
                BuyItem();
            }
            else if (answer == 4)
            {
                Console.WriteLine("Нефиг было на худую корову волосы клеить, если историю услышать хотел.");
                Shop();
            }
            else if (answer == 5)
            {
                BuyAidKit();
            }
            else if (answer == 6)
            {
                Console.WriteLine("!!FUCK THE SYSTEM!!CHEATER MOD IS ENABLE!!WHOOOOOOOOOOOOOO!!");
                cheatermod = true;
                Shop();
            }
            if (cheatermod == true)
            {
                DMG = 999;
                HP = 999;
            }
        }
        static void FieldGuardian()
        {
            Console.WriteLine("ОМГ!!! ВЕЛИКИЙ ЛУНТИК ПЛАНЕТОВИЧ!!!" );
            Greenfields();
        }
        static void ChooseLocation()
        {
            Console.WriteLine("Выбери локацию:");
            Console.WriteLine("1.Зелёные Поля");
            Console.WriteLine("2.Торгаш");
            Console.WriteLine("3.Лес");
            Console.WriteLine("4.Деревня");
            int travelAnswer = int.Parse(Console.ReadLine());
            if (travelAnswer == 1)
            {
                Greenfields();
            }
            else if (travelAnswer == 2)
            {
                Shop();
            }
            else if (travelAnswer == 3)
            {
                Forest();
            }
            else if (travelAnswer == 4)
            {
                Village();
            }
        }
        static void Forest()
        {
            Console.WriteLine("Это лес.Эй! Кэп Очевидность, ты как сюда попал! А ну, кыш,кыш отсюда!Ты заметил крайне утончённую оргию разбойников");
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Bыбрать локацию");
            Console.WriteLine("2.Aтаковать разбойников");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                ChooseLocation();
            }
            else if (answer == 2)
            {
                FightRobbers();
            }
        }
        static void Village()
        {
            Console.WriteLine("Здесь Дядь Васе кто-то в чичу подмешал озверина, и он вырос до размера кита долбаного и озверел окаянный гад. ");
            Console.WriteLine("Выбери действие:");
            Console.WriteLine("1.Bыбрать локацию");
            Console.WriteLine("2.Aтаковать великанa");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                ChooseLocation();
            }
            else if (answer == 2)
            {
                FightGiant();
            }
        }
        static void BuyItem()
        {
            Random rand = new Random();
            int la = rand.Next(0,2);
            if (la == 0)
            {
                if (money >= 50 && haveSword == false)
                {
                    money -= 50;
                    haveSword = true;
                    DMG = 100;
                    Console.WriteLine("Лови меч, башка (пип)ов полетит с плеч!");
                    Console.WriteLine("Урон: 100");
                    Console.WriteLine("Баланс:" + money);
                    Shop();
                }
                else
                {
                    Console.WriteLine("Да мне пох кто твой батя, я торговец, а не фонд помощи блатным!");
                    Shop();
                }
            }
            else if (la == 1)
            {
                if (money >= 30 && haveArmour == false)
                {
                    money -= 50;
                    haveArmour = true;
                    HP = 100;
                    Console.WriteLine("Лови доспехи! Они только over100500 лет назад отлиты были!");
                    Console.WriteLine("Здоровье: " + HP);
                    Console.WriteLine("Баланс:" + money);
                    Shop();
                }
                else
                {
                    Console.WriteLine("Да мне пох кто твой батя, я торговец, а не фонд помощи блатным!");
                    Shop();
                }
            }

        }
        static void BuyAidKit()
        {
            if (money >= 10)
            {
                money -= 10;
                HP += 30;
                Console.WriteLine("Я те ща дам аптеку, на йодом по башке, а деньги дай.");
                Console.WriteLine("Баланс: " + money);
                Console.WriteLine("Твоё здоровье: " + HP);
                Shop();
            }
            else
            {
                Console.WriteLine("Я СКАЗАЛ ДЕНЬГИ ДАЙ!!!");
                Shop();
            }
        }
        static void FightRobbers()
        {
            RobbersAttack();
            if (robbersHP > 0)
            {
                if (HP > 0)
                {
                    AskQuestionRobbers();
                    HeroAttackRobbers();
                }

                else if (HP <= 0)
                {
                    Console.WriteLine("Ты чуть не сдох, но разбойничья оргия так заманила тебя, что ты присоеденился и сдох от перевозбуждения");
                    End();
                }
            }
            else
            {
                HP = 180;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ты делаешь шашлык-машлык из разбойников");
                Console.WriteLine("Ты высосал их души и кровь.Твоё здоровье восстановилось, а ещё прибавилось бонусное!");
                Console.WriteLine("Теперь твоё здоровье: " + HP);
                Console.ForegroundColor = ConsoleColor.Gray;
                ChooseLocation();
            }
        }
        static void RobbersAttack()
        {
            Console.WriteLine("Разбойники атакуют!");
            HP -= robbersDMG;
            robbersDMG = GetReducedAttack(robbersHP, maxRobbersHP, robbersDMG);
            Console.WriteLine("Твоё здоровье:" + HP);
        }
        static void HeroAttackRobbers()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ты атакуешь!");
            robbersHP = robbersHP - DMG;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Хп : " + robbersHP);
        }
        static void HeroAttackGiant()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ты атакуешь!");
            giantHP = giantHP - DMG;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Хп : " + robbersHP);
        }
        static void End()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Чего надобно, сынок");
            Console.WriteLine("1.Выйти из игры.");
            Console.WriteLine("2.Начать сначала.");
            int lastAnswer = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            if (lastAnswer == 1)
            {
                Environment.Exit(0);
            }
            else if (lastAnswer == 2)
            {
                Reset();
                Greenfields();
            }
        }
        static void AskQuestionRobbers()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выбери дейтсвие:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Атаковать");
            Console.WriteLine("2.Run, vasya, run vasya, run, vasya run.");
            int answerQuestion = int.Parse(Console.ReadLine());

            if (answerQuestion == 1)
            {
                HeroAttackRobbers();
                FightRobbers();
            }
            else if (answerQuestion == 2)
            {
                robbersDMG = 80;
                robbersHP = 110;
                Greenfields();
            }
        }
        static void AskQuestionGiant()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выбери дейтсвие:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Атаковать");
            Console.WriteLine("2.Run, vasya, run vasya, run, vasya run.");
            int answerQuestion = int.Parse(Console.ReadLine());

            if (answerQuestion == 1)
            {
                HeroAttackGiant();
                FightRobbers();
            }
            else if (answerQuestion == 2)
            {
                giantDMG = 100;
                giantHP = 200;
                Greenfields();
            }
        }
        static void Reset()
        {
            cheatermod = false;
            HP = 10;
            DMG = 10;
            haveHorse = true;
            money = 0;
            haveSword = false;
            haveArmour = false;
            robbersDMG = 80;
            robbersHP = 110;
            maxRobbersHP = 110;
        }
        static double GetReducedAttack(double health, double maxHealth, double maxAttack)
        {
            double healthProportion = maxHealth / health;
            double attackProportion = maxAttack / healthProportion;
            return attackProportion;
        }
        static void FightGiant()
        {
            GiantAttack();
            if (giantHP > 0)
            {
                if (HP > 0)
                {
                    AskQuestionFG();
                    HeroAttackGiant();
                }

                else if (HP <= 0)
                {
                    Console.WriteLine("Ты сдох!");
                    End();
                }
            }
            else
            {


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ты показываешь ему фотку его тёщи! Он сдох от инфаркта!");

                End();
            }
        }
        static void GiantAttack()
        {
            Console.WriteLine("Дядя Вася атакуeт!");
            HP -= giantDMG;
            giantDMG = GetReducedAttack(giantHP, maxGiantHP, giantDMG);
            Console.WriteLine("Твоё здоровье:" + HP);
        }
        static void AskQuestionFG()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выбери дейтсвие:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Атаковать");
            Console.WriteLine("2Run, vasya, run vasya, run, vasya run.");
            int answerQuestion = int.Parse(Console.ReadLine());

            if (answerQuestion == 1)
            {
                HeroAttackGiant();
                FightGiant();
            }
            else if (answerQuestion == 2)
            {
                Greenfields();
            }
        }
    }
}