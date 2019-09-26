using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9_Playing_games_
{
    class Program
    {
        int count = 0;
        public void fun(int x)
        {
            for (int i=1;i != 0;)
            {
                Console.WriteLine("..U Want stop thE Game...s=0 or No=1.. ");
                i = Convert.ToInt32(Console.ReadLine());
                count = count + 1;
            }
            
          
        }
        static void Main(string[] args)
        {
            int user = 0, op = 0, count = 0, balance = 0, num = 0,ul,a;
            int[] arr = new int[10];
            Console.WriteLine("..Select to play Unlimited..");
            ul = Convert.ToInt32(Console.ReadLine());
            arr[ul] = 1;
            Program obj = new Program();
            obj.fun(ul);
            while (count != 11)
            {
                Console.WriteLine("....Which game u Want to Play.... ");
                Console.WriteLine("The games are  0 1 2 3 4 5 6 7 8 9 ");
                user = Convert.ToInt32(Console.ReadLine());
                  
              if (user < 10)
                {


                    for (int i = user; i < 10; i++)
                    {

                        if (user == i)
                        {
                            if (arr[i] == 1)
                            {

                                Console.WriteLine("): Sorry.....:( This Game Already Played");
                            }
                            else
                            {
                                Console.WriteLine("(: .....Welcome to play..... :) ");
                                arr[i] = 1;
                                num = num + 1;
                            }


                        }

                    }

                }
                else { Console.WriteLine("Invalid Game Option....Please try again"); }

                Console.WriteLine("If You Want Continue To Play :)...Yes = 1 or No = 0 ");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    count = count + 1;
                }
                else { break; }

            }
            Console.WriteLine("You Played and UnPlayed Game");
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == 1)
                {
                    Console.WriteLine(i + " Played Game");
                }
                else
                {
                    Console.WriteLine(i + " Unplayed Game");
                }

                //Console.WriteLine(i);
            }
            Console.WriteLine("Number of Game to Played = " + num);
            balance = 10 - num;
            Console.WriteLine("Number of Game Unplayed =" + balance);
        }
    }
}
