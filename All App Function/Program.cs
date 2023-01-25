using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_App_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SELECTION
            try
            {
                int select;
            options:
                Console.WriteLine("\t\t\t----------------Application Selection--------------------");
                Console.WriteLine("\n1. Fibonacci");
                Console.WriteLine("2. Palindrome");
                Console.WriteLine("3. Prime Numbers(1-100)");
                Console.WriteLine("4. Matrix (Addition)");
                Console.WriteLine("5. Matrix (Subtraction)");
                Console.WriteLine("6. Eyitotobiju(Max)");
                Console.WriteLine("7. Eyitokereju(Min)");
                Console.WriteLine("8. Quadratic Equation");
                Console.WriteLine("9. Simultaneous Equation");
                Console.WriteLine("10. Mini CBT");

                select = int.Parse(Console.ReadLine());
                Console.Clear();
                #endregion

                switch (select)
                {
                    case 1:
                        #region FIBONACCI
                        {
                            Console.WriteLine("\t\t\t-------------Fibonacci-------------");
                            int x = 0;
                            int y = 1;
                            int z;
                            Console.WriteLine("Fibonacci");

                            Console.WriteLine("0");
                            for (int num = 0; num < 20; ++num)
                            {
                                z = x + y;
                                Console.WriteLine(z);
                                x = y;
                                y = z;
                            }
                            break;
                        }
                    #endregion

                    case 2:
                        #region PALINDROME
                        {
                            Console.WriteLine("\t\t\t-------------Palindrome-------------");
                            string word;
                            string reverse_word = "";

                            Console.WriteLine("Enter a word:");
                            word = Console.ReadLine();
                            for (int i = word.Length - 1; i >= 0; i--)
                            {
                                reverse_word += word.Substring(i, 1);
                            }
                            if (word.ToLower() == reverse_word.ToLower())
                            {
                                Console.WriteLine("\n" + word + " is a palindrome");
                                Console.WriteLine(word + "=" + reverse_word);
                            }
                            else
                            {
                                Console.WriteLine("\n" + word + " is not a palindrome");
                                Console.WriteLine(word + "=" + reverse_word);
                            }
                            break;
                        }
                    #endregion

                    case 3:
                        #region PRIME NUMBER
                        {
                            Console.WriteLine("\t\t\t-------------Prime Numbers (1-100)-------------");
                            Console.WriteLine("Prime Number 1-100");

                            for (int prime = 2; prime <= 100; prime++)
                            {
                                //2,3,5,7
                                if ((prime % 2 != 0 && prime % 3 != 0 && prime % 5 != 0 && prime % 7 != 0) || (prime == 2 || prime == 3 || prime == 5 || prime == 7))
                                {
                                    Console.WriteLine(prime);
                                }
                            }
                            break;
                        }
                    #endregion

                    case 4:
                        #region MATRIX ADDITION
                        {
                            Console.WriteLine("\t\t\t-------------Matrix (Addition)-------------");
                            //FIRST MATRIX
                            int[,] matrix = new int[3, 3];
                            for (int i = 1; i <= 2; i++)
                            {
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.WriteLine("Enter the value of R" + i + " and C" + j + " =");
                                    matrix[i, j] = int.Parse(Console.ReadLine());
                                }
                            }

                            //SECOND MATRIX
                            int[,] matrix1 = new int[3, 3];
                            for (int i = 1; i <= 2; i++)
                            {
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.WriteLine("Enter the second matrix value of R" + i + " and C" + j + " =");
                                    matrix1[i, j] = int.Parse(Console.ReadLine());
                                }
                            }

                            //DISPLAY OF FIRST MATRIX
                            for (int i = 1; i <= 2; i++)
                            {
                                Console.WriteLine("______");
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.Write("|" + matrix[i, j]);
                                }
                                Console.WriteLine("|");
                            }
                            Console.WriteLine("______");

                            Console.WriteLine("\t+");
                            
                            //DISPLAY OF SECOND MATRIX
                            for (int i = 1; i <= 2; i++)
                            {
                                Console.WriteLine("______");
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.Write("|" + matrix1[i, j]);
                                }
                                Console.WriteLine("|");
                            }
                            Console.WriteLine("______");

                            //CALCULATION OF MATRIX
                            matrix[1, 1] += matrix1[1, 1];
                            matrix[2, 1] += matrix1[2, 1];
                            matrix[1, 2] += matrix1[1, 2];
                            matrix[2, 2] += matrix1[2, 2];

                            Console.WriteLine("\n\t=");

                            //DISPLAY OF ANSWER

                            for (int i = 1; i <= 2; i++)
                            {
                                Console.WriteLine("______");
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.Write("|" + matrix[i, j]);
                                }
                                Console.WriteLine("|");
                            }
                            Console.WriteLine("______");
                            break;
                        }
                    #endregion

                    case 5:
                        #region MATRIX SUBTRACTION
                        {
                            Console.WriteLine("\t\t\t-------------Matrix (Subtraction)-------------");
                            int[,] matrix = new int[3, 3];
                            int[,] matrix1 = new int[3, 3];

                            //FIRST MATRIX
                            for (int i = 1; i <= 2; i++)
                            {
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.WriteLine("Enter the value of R" + i + " and C" + j + " =");
                                    matrix[i, j] = int.Parse(Console.ReadLine());
                                }
                            }

                            //SECOND MATRIX
                            for (int i = 1; i <= 2; i++)
                            {
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.WriteLine("\nEnter the second matrix value of R" + i + " and C" + j + " =");
                                    matrix1[i, j] = int.Parse(Console.ReadLine());
                                }
                            }
                            Console.Clear();

                            //DISPLAY OF FIRST MATRIX
                            for (int i = 1; i <= 2; i++)
                            {
                                Console.WriteLine("______");
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.Write("|" + matrix[i, j]);
                                }
                                Console.WriteLine("|");
                            }
                            Console.Write("______");

                            Console.WriteLine("\n\t+");

                            //DISPLAY OF SECOND MATRIX
                            for (int i = 1; i <= 2; i++)
                            {
                                Console.WriteLine("______");
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.Write("|" + matrix1[i, j]);
                                }
                                Console.WriteLine("|");
                            }
                            Console.Write("______");

                            //SUBTRACTION OF MATRIX
                            for (int i = 1; i <= 2; i++)
                            {
                                for (int j = 1; j <= 2; j++)
                                {
                                    matrix[i, j] -= matrix1[i, j];
                                }
                            }

                            Console.WriteLine("\n\t=");

                            //DISPLAY OF ANSWER
                            for (int i = 1; i <= 2; i++)
                            {
                                Console.WriteLine("______");
                                for (int j = 1; j <= 2; j++)
                                {
                                    Console.Write("|" + matrix[i, j]);
                                }
                                Console.WriteLine("|");
                            }
                            Console.Write("______");
                        }
                        break;
                    #endregion

                    case 6:
                        #region Eyitotobiju (MAX)
                        {
                            Console.WriteLine("\t\t\t-------------Eyitotobiju(Max)-------------");
                            double f = eyitotobiju(5, 2);
                            Console.WriteLine(f);
                            Console.ReadKey();

                            double eyitotobiju(double a, double b)
                            {
                                double result = 0;
                                if (a > b)
                                {
                                    result = a;
                                }
                                else if (b > a)
                                {
                                    result = b;
                                }
                                return result;
                            }
                            break;
                        }
                    #endregion

                    case 7:
                        #region EYITOKEREJU
                        {
                            Console.WriteLine("\t\t\t-------------Eyitokereju(Min)-------------");
                            double g = eyitokereju(5, 2);
                            Console.WriteLine(g);
                            Console.ReadKey();
                            double eyitokereju(double a, double b)
                            {
                                double result = 0;
                                if (a < b)
                                {
                                    result = a;
                                }
                                else if (b < a)
                                {
                                    result = b;
                                }
                                return result;
                            }
                            break;
                        }
                    #endregion

                    case 8:
                        #region QUADRATIC EQUATION
                        {
                            Console.WriteLine("\t\t\t-------------Quadratic Equation-------------");
                            double a, b, c, d, n1, n2;
                            Console.WriteLine("\n\t-------------------Program To Solve Quadraric Equations------------------");
                            Console.WriteLine("\n\tFormula for Quadtric Equation = -b+-square root(b^2-4*a*c)/2*a");
                            Console.WriteLine("\tWhere a = first number, b = second number and c = third number");
                            Console.WriteLine("\n\n Enter value of a:");
                            a = double.Parse(Console.ReadLine());

                            Console.WriteLine("\n Enter value of b:");
                            b = double.Parse(Console.ReadLine());

                            Console.WriteLine("\n Enter value of c:");
                            c = double.Parse(Console.ReadLine());

                            d = b * b - 4 * a * c;

                            if (d == 0)
                            {
                                n1 = (-b + Math.Sqrt(d)) / (2 * a);
                                n2 = (-b - Math.Sqrt(d)) / (2 * a);

                                Console.WriteLine("\n1st Root answer = " + n1);
                                Console.WriteLine("2nd Root answer = " + n2);
                            }
                            else if (d > 0)
                            {
                                n1 = (-b + Math.Sqrt(d)) / (2 * a);
                                n2 = (-b - Math.Sqrt(d)) / (2 * a);

                                Console.WriteLine("\n1st Root answer = " + n1);
                                Console.WriteLine("2nd Root answer = " + n2);
                            }
                            else
                            {
                                n1 = (-b / (2 * a));
                                n2 = (Math.Sqrt(-d) / (2 * a));
                                //n1 = (-b + Math.Sqrt(d)) / (2 * a);
                                //n2 = (-b - Math.Sqrt(d)) / (2 * a);
                                Console.WriteLine("Roots are imaginary");
                                Console.WriteLine("\n1st Root answer = " + n1);
                                Console.WriteLine("2nd Root answer = " + n2);
                            }
                            break;
                        }
                    #endregion

                    case 9:
                        #region SIMULTANEOUS EQUATION
                        {
                            Console.WriteLine("\t\t\t-------------Simultaneous Equation-------------");
                            double a, b, c, d, e, f, ds, dx, dy, x, y;
                            Console.WriteLine("\n\t-------------------Program To Solve Simultaneous Equations------------------");
                            //Console.WriteLine("\n\tFormula for Quadtric Equation = -b+-square root(b^2-4*a*c)/2*a");
                            //Console.WriteLine("\tWhere a = first number, b = second number and c = third number");

                            Console.WriteLine("\n\n Enter value of a:");
                            a = double.Parse(Console.ReadLine());

                            Console.WriteLine("\n Enter value of b:");
                            b = double.Parse(Console.ReadLine());

                            Console.WriteLine("\n Enter value of c:");
                            c = double.Parse(Console.ReadLine());

                            //Second Equation

                            Console.WriteLine("\n\n Enter value of d:");
                            d = double.Parse(Console.ReadLine());

                            Console.WriteLine("\n\n Enter value of e:");
                            e = double.Parse(Console.ReadLine());

                            Console.WriteLine("\n\n Enter value of f:");
                            f = double.Parse(Console.ReadLine());

                            y = ((a * f) - (c * d)) / ((a * e) - (b * d));

                            if (a == 0)
                            {
                                x = (f - (e * y)) / d;
                            }
                            else
                            {
                                x = (c - (b * y)) / a;
                            }

                            Console.WriteLine("\tX = " + x + "\n\tY = " + y);
                            break;
                        }
                    #endregion

                    case 10:
                        #region MINI CBT
                        {
                            Console.WriteLine("\t\t\t-------------Mini CBT-------------");
                            Random qes = new Random();
                            string qs;
                            int score = 0;

                            string[] ques = new string[21];
                            string[] ans = new string[21];

                            Console.WriteLine("Enter Your Name:");
                            string name = Console.ReadLine();
                            retry:
                            Console.WriteLine("\nClick Enter to start!");
                            string enter = Console.ReadLine();

                            ques[0] = "Is Kwara still on lockdown?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[0] = "B";
                            ques[1] = "Are muscles needed to move our body?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[1] = "A";
                            ques[2] = "Are wild animals dangerous?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[2] = "A";
                            ques[3] = "Are rattlesnakes poisonous?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[3] = "A";
                            ques[4] = "Are band-aids used for healing?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[4] = "A";
                            ques[5] = "Are umbrellas used to keep you wet?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[5] = "B";
                            ques[6] = "Are flies and robins small insects?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[6] = "A";
                            ques[7] = "Can a fish live out of water?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[7] = "B";
                            ques[8] = "Are chips and pretzels salty?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[8] = "A";
                            ques[9] = "Are lasagna and spaghetti Chinese dishes?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[9] = "B";
                            ques[10] = "Are ovens used to freeze things?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[10] = "B";
                            ques[11] = "Do cats climb trees?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[11] = "A";
                            ques[12] = "Can you use roller skates on the grass?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[12] = "B";
                            ques[13] = "If there is snow on the ground, is it summer?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[13] = "B";
                            ques[14] = "If you want to watch a movie, would you go to a bank?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[14] = "B";
                            ques[15] = "If it is June, is it hot in the North Pole?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[15] = "A";
                            ques[16] = "If someone smiles, are they sad?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[16] = "B";
                            ques[17] = "If you were a bird, would you have fins?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[17] = "B";
                            ques[18] = "Does it snow during the summer?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[18] = "B";
                            ques[19] = "If something is light, would it sink in water?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[19] = "B";
                            ques[20] = "If you cut yourself really bad, should you go to the dentist?" +
                                "\n(a). Yes" +
                                "\n(b). No" +
                                "\n(c). I Don't Know";
                            ans[20] = "B";

                            for (int i = 0; i < 10; i++)
                            {
                            repeat:
                                int a = qes.Next(1, 20);
                                
                                if (ques[a] == "o")
                                { goto repeat;
                                    
                                }
                                Console.WriteLine(ques[a]);
                                qs = Console.ReadLine();

                                ques[a] = "o";
                                //Console.Clear();

                                if (qs.ToUpper() != ans[a])
                                {
                                    Console.WriteLine("Wrong\a");
                                }
                                else
                                {
                                    Console.WriteLine("Correct!");
                                    score++;
                                }

                                //qs = "o";
                            }
                            score *= 100 / 10;
                            Console.WriteLine("\n\t\t" + name + ", Your score = " + score + "%");

                            Console.WriteLine("\n\t\t Do you want to try again?(Y/N)");
                            string retry = Console.ReadLine();

                            if (retry.ToUpper() == "Y")
                            {
                                goto retry;
                            }
                            //Console.ReadKey();
                            break;
                        }
                        #endregion

                    default:
                        Console.WriteLine("Please select correct option!");
                        goto options;
                }

            }
            catch (Exception a)
            {
                Console.WriteLine("\nError!");
                Console.WriteLine(a.Message);
            }
            Console.ReadKey();
        }
    }
}
