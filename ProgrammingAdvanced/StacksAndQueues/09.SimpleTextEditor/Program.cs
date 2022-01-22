﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<char> stack = new Stack<char>();
            Stack<string> commands = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string comm = input[0];
                if (comm != "4")
                {
                    string arg = input[1];
                    if (comm == "1") 
                    {
                        foreach (var cha in arg)
                        {
                            stack.Push(cha);
                        }

                        commands.Push(string.Join(' ', input));
                    }
                    else if (comm == "2") 
                    {
                        string saveUndo = string.Join(' ', input);
                        string entireDeletion = "";
                        int deleteCount = int.Parse(arg);

                        for (int j = 0; j < deleteCount; j++)
                        {
                            char deleted = stack.Pop();
                            entireDeletion += deleted;
                        }

                        stack.TrimExcess();
                        char[] array = entireDeletion.ToCharArray();
                        Array.Reverse(array);
                        string current = new String(array);

                        saveUndo += ":" + current;
                        commands.Push(saveUndo);
                    }
                    else if (comm == "3")
                    {
                        int index = int.Parse(arg) - 1;
                        int count = stack.Count();
                        int convertedInd = count - index - 1; 
                        char toPrint = stack.ToList()[convertedInd];
                        Console.WriteLine(toPrint);
                    }
                }
                else //4
                {
                    string[] toUndoArr = commands.Pop().Split();
                    comm = toUndoArr[0];
                    string arg = toUndoArr[1];
                    if (comm == "1")
                    {
                        int len = arg.Length;
                        for (int j = 0; j < len; j++)
                        {
                            stack.Pop();
                        }
                    }
                    else if (comm == "2")
                    {
                        string[] mini = arg.Split(":");
                        string internalArg = mini[1];

                        foreach (var cha in internalArg)
                        {
                            stack.Push(cha);
                        }
                    }

                }
            }
        }
    }
}
    

