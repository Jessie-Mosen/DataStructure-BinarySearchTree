using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BSTree
{
    internal class Node
    {
        public string Word { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int WordLength { get; set; }

        public int Position { get; set; }

        public Node() 
        {
            Word = "Null";
            Left = null;
            Right = null;
            WordLength = Word.Length;
            Position = -1;
        }
        public Node(string word)
        {
            Word = word;
            Left = null;
            Right = null;
            WordLength = Word.Length;
            Position = -1;
        }
        public override string ToString()
        {
            return Word.ToString();
        }
    }   
}
