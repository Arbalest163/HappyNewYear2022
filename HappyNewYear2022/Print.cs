using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HappyNewYear2022
{
    public class Print
    {
        private static string[,] Letter()
        {
            string[,] letter = new string[,]
            {
                {
                    //letter with index 0
                  "    ",
                  "    ",
                  "    ",
                  "    ",
                  "    ",
                  "    ",
                },
                {
                  //letter with index 1
                  "╔══╗",
                  "║╔╗║",
                  "║╚╝║",
                  "║╔╗║",
                  "║║║║",
                  "╚╝╚╝",
                },
                {
                  //letter with index 2
                  "╔═══╗",
                  "║╔══╝",
                  "║╚══╗",
                  "║╔═╗║",
                  "║╚═╝║",
                  "╚═══╝",
                },
                {
                  //letter with index 3
                  "╔══╗ ",
                  "║╔╗║ ",
                  "║╚╝╚╗",
                  "║╔═╗║",
                  "║╚═╝║",
                  "╚═══╝",
                },
                {
                  //letter with index 4
                  "╔══╗",
                  "║╔═╝",
                  "║║  ",
                  "║║  ",
                  "║║  ",
                  "╚╝  ",
                },
                {
                  //letter with index 5
                  " ╔══╗ ",
                  " ║╔╗║ ",
                  " ║║║║ ",
                  " ║║║║ ",
                  "╔╝╚╝╚╗",
                  "╚════╝",
                },
                {
                  //letter with index 6
                  "╔═══╗",
                  "║╔══╝",
                  "║╚══╗",
                  "║╔══╝",
                  "║╚══╗",
                  "╚═══╝",
                },
                {
                  //letter with index 7
                  "╔╩═╩╗",
                  "║╔══╝",
                  "║╚══╗",
                  "║╔══╝",
                  "║╚══╗",
                  "╚═══╝",
                },
                {
                  //letter with index 8
                  "╔╗╔╗╔╗",
                  "║║║║║║",
                  "║╚╝╚╝║",
                  "║╔╗╔╗║",
                  "║║║║║║",
                  "╚╝╚╝╚╝",
                },
                {
                  //letter with index 9
                  "╔═══╗",
                  "╚══╗║",
                  " ╔═╝║",
                  " ╚═╗║",
                  "╔══╝║",
                  "╚═══╝",
                },
                {
                  //letter with index 10
                  "╔╗╔╗",
                  "║║║║",
                  "║║║║",
                  "║║╔║",
                  "║╚╝║",
                  "╚══╝",
                },
                {
                  //letter with index 11
                  "╔╗╩╔╗",
                  "║║ ║║",
                  "║║ ║║",
                  "║║ ╔║",
                  "║╚═╝║",
                  "╚═══╝",
                },
                {
                  //letter with index 12
                  "╔╗╔══╗",
                  "║║║╔═╝",
                  "║╚╝║  ",
                  "║╔╗║  ",
                  "║║║╚═╗",
                  "╚╝╚══╝",
                },
                {
                  //letter with index 13
                  " ╔══╗",
                  " ║╔╗║",
                  " ║║║║",
                  " ║║║║",
                  "╔╝║║║",
                  "╚═╝╚╝",
                },
                {
                  //letter with index 14
                  "╔╗  ╔╗",
                  "║║  ║║",
                  "║╚╗╔╝║",
                  "║╔╗╔╗║",
                  "║║╚╝║║",
                  "╚╝  ╚╝",
                },
                {
                  //letter with index 15
                  "╔╗╔╗",
                  "║║║║",
                  "║╚╝║",
                  "║╔╗║",
                  "║║║║",
                  "╚╝╚╝",
                },
                {
                  //letter with index 16
                  "╔══╗",
                  "║╔╗║",
                  "║║║║",
                  "║║║║",
                  "║╚╝║",
                  "╚══╝",
                },
                {
                  //letter with index 17
                  "╔══╗",
                  "║╔╗║",
                  "║║║║",
                  "║║║║",
                  "║║║║",
                  "╚╝╚╝",
                },
                {
                  //letter with index 18
                  "╔═══╗",
                  "║╔═╗║",
                  "║╚═╝║",
                  "║╔══╝",
                  "║║   ",
                  "╚╝   ",
                },
                {
                  //letter with index 19
                  "╔══╗",
                  "║╔═╝",
                  "║║  ",
                  "║║  ",
                  "║╚═╗",
                  "╚══╝",
                },
                {
                  //letter with index 20
                  "╔════╗",
                  "╚═╗╔═╝",
                  "  ║║  ",
                  "  ║║  ",
                  "  ║║  ",
                  "  ╚╝  ",
                },
                {
                  //letter with index 21
                  "╔╗╔╗",
                  "║║║║",
                  "║╚╝║",
                  "╚═╗║",
                  " ╔╝║",
                  " ╚═╝",
                },
                {
                  //letter with index 22
                  "╔═════╗",
                  "║ ╔╦╗ ║",
                  "║ ║║║ ║",
                  "║ ╚╩╝ ║",
                  "╚═╗ ╔═╝",
                  "  ╚═╝  ",
                },
                {
                  //letter with index 23
                  "╔══╗╔══╗",
                  "╚═╗║║╔═╝",
                  "  ║╚╝║  ",
                  "  ║╔╗║  ",
                  "╔═╝║║╚═╗",
                  "╚══╝╚══╝",
                },
                {
                  //letter with index 24
                  "╔╗╔╗",
                  "║║║║",
                  "║║║║",
                  "║║║║",
                  "║╚╝║",
                  "╚══╗",
                },
                {
                  //letter with index 25
                  "╔╗╔╗",
                  "║║║║",
                  "║╚╝║",
                  "╚═╗║",
                  "  ║║",
                  "  ╚╝",
                },
                {
                  //letter with index 26
                  "╔╗╔╗╔╗",
                  "║║║║║║",
                  "║║║║║║",
                  "║║║║║║",
                  "║╚╝╚╝║",
                  "╚════╝",
                },
                {
                  //letter with index 27
                  "╔╗╔╗╔╗",
                  "║║║║║║",
                  "║║║║║║",
                  "║║║║║║",
                  "║╚╝╚╝║",
                  "╚════╗",
                },
                {
                  //letter with index 28
                  "═╗   ",
                  "╗║   ",
                  "║╚══╗",
                  "║╔═╗║",
                  "║╚═╝║",
                  "╚═══╝",
                },
                {
                  //letter with index 29
                  "╔╗  ╔╗",
                  "║║  ║║",
                  "║╚══╣║",
                  "║╔═╗║║",
                  "║╚═╝║║",
                  "╚═══╩╝",
                },
                {
                  //letter with index 30
                  "╔╗   ",
                  "║║   ",
                  "║╚══╗",
                  "║╔═╗║",
                  "║╚═╝║",
                  "╚═══╝",
                },
                {
                  //letter with index 31
                  "╔═══╗",
                  "╚══╗║",
                  " ╔═╝╝",
                  " ╚═╗╗",
                  "╔══╝║",
                  "╚═══╝",
                },
                {
                  //letter with index 32
                  "╔╗╔══╗",
                  "║║║╔╗║",
                  "║╚╝║║║",
                  "║╔╗║║║",
                  "║║║╚╝║",
                  "╚╝╚══╝",
                },
                {
                  //letter with index 33
                  "╔═══╗",
                  "║╔═╗║",
                  "║╚═╝║",
                  "╚╗╔╗║",
                  " ║║║║",
                  " ╚╝╚╝",
                },
                {
                  //letter with index 34
                  " ╔╗",
                  "╔╝║",
                  "╚╗║",
                  " ║║",
                  " ║║",
                  " ╚╝",
                },
                {
                  //letter with index 35
                  "╔══╗",
                  "╚═╗║",
                  "╔═╝║",
                  "║╔═╝",
                  "║╚═╗",
                  "╚══╝",
                },
                {
                  //letter with index 36
                  "╔══╗",
                  "╚═╗║",
                  "╔═╝║",
                  "╚═╗║",
                  "╔═╝║",
                  "╚══╝",
                },
                {
                  //letter with index 37
                  "╔╗╔╗",
                  "║║║║",
                  "║╚╝║",
                  "╚═╗║",
                  "  ║║",
                  "  ╚╝",
                },
                {
                  //letter with index 38
                  "╔══╗",
                  "║╔═╝",
                  "║╚═╗",
                  "╚═╗║",
                  "╔═╝║",
                  "╚══╝",
                },
                {
                  //letter with index 39
                  "╔══╗",
                  "║╔═╝",
                  "║╚═╗",
                  "║╔╗║",
                  "║╚╝║",
                  "╚══╝",
                },
                {
                  //letter with index 40
                  "╔══╗",
                  "╚═╗║",
                  "  ║║",
                  "  ║║",
                  "  ║║",
                  "  ╚╝",
                },
                {
                  //letter with index 41
                  "╔══╗",
                  "║╔╗║",
                  "║╚╝║",
                  "║╔╗║",
                  "║╚╝║",
                  "╚══╝",
                },
                {
                  //letter with index 42
                  "╔══╗",
                  "║╔╗║",
                  "║╚╝║",
                  "╚═╗║",
                  "╔═╝║",
                  "╚══╝",
                },
                {
                  //letter with index 43
                  "╔══╗",
                  "║╔╗║",
                  "║║║║",
                  "║║║║",
                  "║╚╝║",
                  "╚══╝",
                },
                {
                  //letter with index 44
                  "  ",
                  "  ",
                  "  ",
                  "  ",
                  "╔╗",
                  "╚╣",
                },
                {
                  //letter with index 45
                  "  ",
                  "  ",
                  "  ",
                  "  ",
                  "╔╗",
                  "╚╝",
                },
                {
                  //letter with index 46
                  "╔╗",
                  "║║",
                  "║║",
                  "╚╝",
                  "╔╗",
                  "╚╝",
                },
                {
                  //letter with index 47
                  "╔═╗",
                  "╚╗║",
                  "╔╝║",
                  "║╔╝",
                  "╔╗ ",
                  "╚╝ ",
                },
                {
                  //letter with index 48
                  "  ",
                  "╔╗",
                  "╚╝",
                  "╔╗",
                  "╚╝",
                  "  ",
                },
                {
                  //letter with index 49
                  "╔═╗",
                  "╚╗║",
                  " ║║",
                  " ║║",
                  "╔╝║",
                  "╚═╝",
                },
                {
                  //letter with index 50
                  "╔═╗",
                  "║╔╝",
                  "║║ ",
                  "║║ ",
                  "║╚╗",
                  "╚═╝",
                },
                {
                  //letter with index 51
                  "    ",
                  "    ",
                  "╔══╗",
                  "╚══╝",
                  "    ",
                  "    ",
                },
                {
                  //letter with index 52
                  "              ",
                  " ▄█▀█▄  ▄███▄ ",
                  "▐█░██████████▌",
                  " ██▒█████████ ",
                  "  ▀████████▀  ",
                  "     ▀██▀     ",
                },
                {
                  //letter with index 53
                  "###",
                  "@@@",
                  "###",
                  "@@@",
                  "###",
                  "@@@",
                }
            };

            return letter;
        }

        public static void Phrase(string phrase)
        {
            char[] arrPhrase = phrase.ToCharArray();

            char[] arrSymbol = new char[] { ' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 
                                            'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 
                                            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 
                                            'Ь', 'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', 
                                            '7', '8', '9', '0', ',', '.', '!', '?', ':', ')', 
                                            '(', '-', '♥' };

            string[,] arrLetter = Letter();

            string[,] buffer = new string[arrLetter.GetLength(1), arrPhrase.Length];

            if (arrPhrase.Length > 255)
            {
                Console.WriteLine($"ERROR: the number of characters is more than {255}");
            }

            
            for (byte i = 0; i < arrPhrase.Length; i++)
            { 
                byte index = 0;

                for (byte k = 0; k < arrSymbol.Length; k++)
                {
                    if (arrPhrase[i] == arrSymbol[k])
                    {
                        index = k;
                        break;
                    }
                    else
                    {
                        index = 53;
                    }
                }

                for (byte j = 0; j < arrLetter.GetLength(1); j++)
                {
                    buffer[j, i] = arrLetter[index, j];
                }
            }
            for (byte i = 0; i < arrLetter.GetLength(1); i++)
            {
                for (byte j = 0; j < arrPhrase.Length; j++)
                {
                    Console.Write(buffer[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Clear()
        {
            Console.Clear();
        }
        public static void Delay(double second)
        {
            Thread.Sleep(TimeSpan.FromSeconds(second));
        }
    }
}
