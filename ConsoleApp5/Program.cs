using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kredit_Card Bankoskaya_karta = new Kredit_Card();
            try
            {
                Console.Write("\n Enter card number: ");
                Bankoskaya_karta.NomerKarty = Console.ReadLine();
                if (Bankoskaya_karta.NomerKarty.Length > 17)
                    throw new Exception("\n Invalid card number entered ");
                else if (Bankoskaya_karta.NomerKarty.IndexOf(" ") != -1)
                    throw new Exception("\n Invalid card number entered ");
                else if (Bankoskaya_karta.NomerKarty.Length < 16)
                    throw new Exception("\n Invalid card number entered ");
                Console.Write("\n Enter full name ");
                Bankoskaya_karta.Imya = Console.ReadLine();
                if (Bankoskaya_karta.Imya == " ")
                    throw new Exception("\nInvalid name entered ");
                Console.Write("\n Enter the card term format [12.2023] ");
                Bankoskaya_karta.Data = Console.ReadLine();
                if (Bankoskaya_karta.Data.Length < 6 || Bankoskaya_karta.Data.Length < 7)
                    throw new Exception("\n Wrong date entered ");
                string mecyaz_buf = Bankoskaya_karta.Data[0].ToString() + Bankoskaya_karta.Data[1].ToString();
                string god_buf = Bankoskaya_karta.Data[3].ToString() + Bankoskaya_karta.Data[4].ToString()
                    + Bankoskaya_karta.Data[5].ToString() + Bankoskaya_karta.Data[6].ToString();
                int mecyaz = Convert.ToInt32(mecyaz_buf);
                int god = Convert.ToInt32(god_buf);
                if (god < DateTime.Now.Year)
                    throw new Exception("\n card expired ");
                else if (mecyaz < DateTime.Now.Month)
                    throw new Exception("\n card expired ");
                Console.Write("\n Entered your CVV code ");
                Console.Write("\n Entered your CVV code ");
                Bankoskaya_karta.CVV = Convert.ToInt32(Console.ReadLine());
                if (Bankoskaya_karta.CVV.ToString().Length > 3 || Bankoskaya_karta.CVV.ToString().Length < 3)
                    throw new Exception("\n Invalid code entered");
                Console.WriteLine(" \n ");
                Console.WriteLine(Bankoskaya_karta);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }
}

