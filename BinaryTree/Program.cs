using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree {
    class Program {
        static bool loop = true;
        static BiTree tree = new BiTree();


        static void Main(string[] args) {;

            while (loop) {
                Console.Write(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                Console.Write(" $");
                Parser(Lexer(Console.ReadLine()));

            }
        }

        // Lexer - Sammensætter brugerens kommando fra prompten til tokens
        static public string[] Lexer(string text) {
            string[] tokens;
            string tempOrd = "";
            int ordCount = 0;

            int words = 1;
            for (int i = 0; i < text.Length; i++) {
                if (text[i].Equals(' ')) {
                    words++;
                }
            }
            tokens = new string[words];

            for (int i = 0; i < text.Length; i++) {
                if (!text[i].Equals(' ')){
                    tempOrd += text[i];
                } else {
                    tokens[ordCount] = tempOrd;
                    ordCount += 1;
                    tempOrd = "";
                }
            }
            tokens[ordCount] = tempOrd;
            return tokens;
        }

        // Parser - Pattern matcher tokens fra brugeren og kalder funktionerne
        static public void Parser(string[] tokens) {
            for (int i = 0; i < tokens.Length; i++) {
                if (tokens[i].Equals("insert")) {
                    try {
                        int val = Int32.Parse(tokens[i + 1]);
                        tree.Insert(val);

                    } catch (Exception) {
                        Console.WriteLine("ERROR: 'insert' keyword must be followed by an integer");
                        //throw;
                    }
                } else if (tokens[i].Equals("min")){
                    try {
                        Console.WriteLine(tree.min());
                    } catch (Exception) {
                        Console.WriteLine("ERROR: No values inserted");
                        //throw;
                    }
                } else if (tokens[i].Equals("max")) {
                    try {
                        Console.WriteLine(tree.max());
                    } catch (Exception) {
                        Console.WriteLine("ERROR: No values inserted");
                        //throw;
                    }

                } else if (tokens[i].Equals("find")) {
                    try {
                        int val = Int32.Parse(tokens[i + 1]);
                        Console.WriteLine(tree.find(val));
                    } catch (Exception) {
                        Console.WriteLine("ERROR: 'find' keyword must be followed by an integer");
                        //throw;
                    }
                } else if (tokens[i].Equals("exit")) {
                    loop = false;
                }
            }
        }


    }
}