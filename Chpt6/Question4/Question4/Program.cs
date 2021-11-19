using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int suits = 1; suits < 4; suits++)
            {
                if (suits != 0)
                {
                    Console.Write(suits);
                }

                switch (suits)
                {
                    case 1:
                    {
                        Console.Write("\nclub");
                        break;
                    }
                    case 2:
                    {
                        Console.Write("\ndiamond");
                        break;
                    }
                    case 3:
                    {
                        Console.Write("\nheart");
                        break;
                    }
                    case 4:
                    {
                        Console.Write("\nspades");
                        break;
                    }
                    default:
                        Console.Write("Invalid");
                        break;
                }

                for (int cards = 2; cards <= 13; cards++)
                {
                    switch (cards)
                    {
                        case 1:
                        {
                            Console.Write("\n1");
                            break;
                        }
                        case 2:
                        {
                            Console.Write("\n2");
                            break;
                        }
                        case 3:
                        {
                            Console.Write("\n3");
                            break;
                        }
                        case 4:
                        {
                            Console.Write("\n4");
                            break;
                        }
                        case 5:
                        {
                            Console.Write("\n5");
                            break;
                        }
                        case 6:
                        {
                            Console.Write("\n6");
                            break;
                        }
                        case 7:
                        {
                            Console.Write("\n7");
                            break;
                        }
                        case 8:
                        {
                            Console.Write("\n8");
                            break;
                        }
                        case 9:
                        {
                            Console.Write("\n9");
                            break;
                        }
                        case 10:
                        {
                            Console.Write("\nJ");
                            break;
                        }
                        case 11:
                        {
                            Console.Write("\nQ");
                            break;
                        }
                        case 12:
                        {
                            Console.Write("\nK");
                            break;
                        }
                        case 13:
                        {
                            Console.Write("\nA");
                            break;
                        }
                        default:
                            Console.Write("out of available suits");
                            break;
                    }
                }
            }
        }
    }
}