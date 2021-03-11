using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESELvc
{
    class Program
    {
        static string Validate(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k)
        {
            int valid = (a * 1) + (b * 3) + (c * 7) + (d * 9) + (e * 1) + (f * 3) + (g * 7) + (h * 9) + (i * 1) + (j * 3) + (k * 1);
            string validString = valid.ToString();
            char validChar = validString.Last();
 
            if (validChar.ToString() == "0")
            {
                return "is valid";
            }
            else
            {
                return "is not valid";
            }
        }
        static string Gender(int j)
        {
            if (j % 2 == 0)
            {
                return "Female";
            } 
            else
            {
                return "Male";
            }
        }
        static string Month(int c, int d)
        {
            string cS = c.ToString();
            string dS = d.ToString();
            if (c == 1 || c == 0)
            {
                return cS + dS;
            } 
            else if (c == 2 || c == 3)
            {
                string cd = cS + dS;
                int iCD = Int32.Parse(cd);
                int vCD = iCD - 20;
                string vS = vCD.ToString();
                return vS;
            }
            else
            {
                return "null";
            }
        }
        static void Main()
        {
            Console.Title = "Polish PESEL validator and checker | by Nyxon";
            Console.Write("Provide PESEL number: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string pesel = Console.ReadLine();
            string a, b, c, d, e, f, g, h, i, j, k;
            a = "null"; b = "null"; c = "null"; d = "null"; e = "null"; f = "null"; g = "null"; h = "null"; i = "null"; j = "null"; k = "null";
            string[] pslSplit = pesel.Split();
            foreach (string res in pslSplit)
            {
                a = res.Substring(0, 1);
                b = res.Substring(1, 1);
                c = res.Substring(2, 1);
                d = res.Substring(3, 1);
                e = res.Substring(4, 1);
                f = res.Substring(5, 1);
                g = res.Substring(6, 1);
                h = res.Substring(7, 1);
                i = res.Substring(8, 1);
                j = res.Substring(9, 1);
                k = res.Substring(10, 1);
            }
            int iA = Int32.Parse(a);
            int iB = Int32.Parse(b);
            int iC = Int32.Parse(c);
            int iD = Int32.Parse(d);
            int iE = Int32.Parse(e);
            int iF = Int32.Parse(f);
            int iG = Int32.Parse(g);
            int iH = Int32.Parse(h);
            int iI = Int32.Parse(i);
            int iJ = Int32.Parse(j);
            int iK = Int32.Parse(k);
            if (pesel.Length == 11)
            {
                string isValid = Validate(iA, iB, iC, iD, iE, iF, iG, iH, iI, iJ, iK);
                string myGender = Gender(iJ);
                string month = Month(iC, iD);
                string date = "null";
                if (iC == 1 || iC == 0)
                {
                    date = e + f + "." + month + ".19" + a + b;
                }
                else if (iC == 2 || iC == 3)
                {
                    date = e + f + "." + month + ".20" + a + b;
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Provided PESEL: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(pesel);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("PESEL ");
                if (isValid == "is valid")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                } 
                else if (isValid == "is not valid")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(isValid);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Date of birth: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(date);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Gender: ");
                if (myGender == "Male")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (myGender == "Female")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                Console.WriteLine(myGender);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PESEL is incorrect");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ReadKey(true);
        }
    }
}
