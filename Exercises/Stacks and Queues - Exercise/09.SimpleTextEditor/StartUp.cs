using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int commandNumber = int.Parse(Console.ReadLine());
            var stackHistory = new Stack<string>();
            var text = new StringBuilder();

            for (int i = 0; i < commandNumber; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        if (input.Length>1)
                        {
                            stackHistory.Push(text.ToString());
                            text.Append(input[1]);
                        }
                        break;
                    case 2:
                        if (input.Length>1)
                        {
                            var count = int.Parse(input[1]);
                            stackHistory.Push(text.ToString());

                            if (count>text.Length)
                            {
                                text.Clear();
                                break;
                            }

                            text.Remove(text.Length - count, count);
                        }
                        break;
                    case 3:
                        if (input.Length>1)
                        {
                            var index = int.Parse(input[1]);

                            if (index<=text.Length && index>0)
                            {
                                Console.WriteLine(text[index - 1]); ;
                            }
                        }
                        break;
                    case 4:
                        text.Clear();
                        text.Append(stackHistory.Pop());
                        break;
                    default:
                        break;
                }



            }
        }
    }
}
