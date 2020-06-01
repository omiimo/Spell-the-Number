using System;
using System.Security.Cryptography.X509Certificates;

namespace SpellTheNumberConsole
{
    class Program
    {
        public static bool hasSeprator = false;
        static void Main(string[] args)
        {            
            Console.Write("Input a whole number:");
            string wnumber = Console.ReadLine();

            Console.WriteLine(SpellTheWord(wnumber));

            Console.ReadKey();
        }

        private static string SpellTheWord(string wnumber)
        {
            wnumber = Convert.ToInt32(wnumber).ToString();
            int strLen = wnumber.Length;
            if (Convert.ToInt32(wnumber) <= 0)
                return "Zero";
            string spell;
            switch (strLen)
            {
                case 1: // One's
                    spell = $"{Spell(wnumber)}";
                    break;
                case 2: // Ten's
                    spell = $"{Spell(wnumber)}";
                    break;
                case 3: // Hundred's
                    spell = $"{Spell(wnumber.Substring(0, 1))} Hundred {Separator(wnumber.Substring(1, 2))} {Spell(wnumber.Substring(1,2))}";
                    break;
                case 4: // Thousand's
                    spell = $"{Spell(wnumber.Substring(0, 1))} Thousand {Separator(wnumber.Substring(1, 3))} {SpellTheWord(wnumber.Substring(1,3))}";
                    break;

                case 5: // Ten's Thousand
                    spell = $"{Spell(wnumber.Substring(0, 2))} Thousand {Separator(wnumber.Substring(2, 3))} {SpellTheWord(wnumber.Substring(2, 3))}";
                    break;

                case 6: // Lakh's
                    spell = $"{Spell(wnumber.Substring(0, 1))} Lakh {Separator(wnumber.Substring(1, 5))} {SpellTheWord(wnumber.Substring(1, 5))}";
                    break;

                case 7: // Ten's Lakh
                    spell = $"{Spell(wnumber.Substring(0, 2))} Lakh {Separator(wnumber.Substring(2, 5))} {SpellTheWord(wnumber.Substring(2, 5))}";
                    break;

                case 8: // Crore's
                    spell = $"{Spell(wnumber.Substring(0, 1))} Crore {Separator(wnumber.Substring(1, 7))} {SpellTheWord(wnumber.Substring(1, 7))}";
                    break;

                case 9: // Crore's
                    spell = $"{Spell(wnumber.Substring(0, 2))} Crore {Separator(wnumber.Substring(2, 7))} {SpellTheWord(wnumber.Substring(2, 7))}";
                    break;

                default:
                    spell = "out of range";
                    break;
            }
            return spell;

        }

        private static string Separator(string number)
        {            
            int val = Convert.ToInt32(number);
            if (val > 0 && val < 99)
                return "And";
            else
                return string.Empty;
        }

        private static string Spell(string number)
        {
            int num = Convert.ToInt32(number);
            if (num > 9)
                return SpellTens(number);
            else
                return SpellOnes(number);
        }
        private static string SpellOnes(string number)
        {
            int num = Convert.ToInt32(number);
            string spell = string.Empty;
            switch(num)
            {
                case 1:
                    spell = "One";
                    break;
                case 2:
                    spell = "Two";
                    break;
                case 3:
                    spell = "Three";
                    break;
                case 4:
                    spell = "Four";
                    break;
                case 5:
                    spell = "Five";
                    break;
                case 6:
                    spell = "Six";
                    break;
                case 7:
                    spell = "Seven";
                    break;
                case 8:
                    spell = "Eight";
                    break;
                case 9:
                    spell = "Nine";
                    break;
            }

            return spell;
        }

        private static string SpellTens(string number)
        {
            int num = Convert.ToInt32(number);
            string spell = string.Empty;
            switch (num)
            {
                case 10:
                    spell = "Ten";
                    break;
                case 11:
                    spell = "Eleven";
                    break;
                case 12:
                    spell = "Twelve";
                    break;
                case 13:
                    spell = "Thirteen";
                    break;
                case 14:
                    spell = "Fourteen";
                    break;
                case 15:
                    spell = "Fifteen";
                    break;
                case 16:
                    spell = "Sixteen";
                    break;
                case 17:
                    spell = "Seventeen";
                    break;
                case 18:
                    spell = "Eighteen";
                    break;
                case 19:
                    spell = "Nineteen";
                    break;
                case 20:
                    spell = "Twenty";
                    break;
                case 30:
                    spell = "Thirty";
                    break;
                case 40:
                    spell = "Fourty";
                    break;
                case 50:
                    spell = "Fifty";
                    break;
                case 60:
                    spell = "Sixty";
                    break;
                case 70:
                    spell = "Seventy";
                    break;
                case 80:
                    spell = "Eighty";
                    break;
                case 90:
                    spell = "Ninety";
                    break;
                default:
                    if (num > 0)
                    {
                        spell = SpellTens(number.Substring(0, 1) + "0") + " " + SpellOnes(number.Substring(1));
                    }
                    break;
            }
            return spell;
        }

    }
}
