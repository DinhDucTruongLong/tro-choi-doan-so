using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTtrochoidoanso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Chuong trinh tro choi doan so---");
            Random Random = new Random();
            int targetNumber = Random.Next(100, 900);
            String targetString = targetNumber.ToString();
            int attempt = 1, MAX_GUESS = 7;
            String guess, feedback = " ";
            while (feedback != " +++" && attempt <= MAX_GUESS)
            {
                Console.WriteLine("Lan doan thu {0}: ", attempt);
                guess = Console.ReadLine();
                feedback = GetFeedback(targetString, guess);
                Console.WriteLine("Phan hoi tu may tinh: {0}", feedback);
                attempt++;

            }
            Console.WriteLine("Nguoi choi da doan {0} lan, tro choi ket thuc!   ",attempt-1);
            if (feedback != "+++")
            {
                Console.WriteLine("Nguoi choi thua cuoc. so lan doan {0}", targetNumber);
            }
            else
                Console.WriteLine("Nguoi choi thang cuoc", attempt);
            Console.ReadLine();
           
        }
        static string GetFeedback(String target, String guess)
        {
            string feedback = " ";
            for(int i = 0; i < guess.Length; i++)
            {
                if (target[i] == guess[i])
                {
                    feedback += "+";    
                }
                else if (target.Contains(guess[i].ToString()))
                {
                    feedback += "?";
                }
            }
            return feedback;
        }
    }
}
