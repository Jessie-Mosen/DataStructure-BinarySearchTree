using System;
using System.Collections.Generic;
using System.Text;

namespace BSTree
{
    internal class BSTree
    {
        public Node Root { get; set; }

        public BSTree()
        {
            Root = null;
        }
        private void InsertNode(Node tree, Node node)
        {
            if (tree.Word.CompareTo(node.Word) < 0)
            {
                if (tree.Left == null)
                {
                    tree.Left = node;
                }
                else
                {
                    InsertNode(tree.Left, node);
                }
            }
            if (tree.Word.CompareTo(node.Word) > 0)
            {
                if (tree.Right == null)
                {
                    tree.Right = node;
                }
                else
                {
                    InsertNode(tree.Right, node);
                }
            }
        }
        public void Add(string word)
        {
            Node node = new Node(word);
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                InsertNode(Root, node);
            }
        }
        private string TraversePreOrder(Node node)
        {
            StringBuilder sb = new StringBuilder();

            if (node != null)
            {
                sb.Append($"(Length {node.WordLength}: {node.ToString()})");  //how do i locate the postion of the node? and show it?
                sb.Append(TraversePreOrder(node.Left));
                sb.Append(TraversePreOrder(node.Right));
            }
            return sb.ToString();
        }
        private string TraverseInOrder(Node node)
        {
            StringBuilder sb = new StringBuilder();
            if (node != null)
            {
                sb.Append(TraverseInOrder(node.Left));
                sb.Append($"(Length {node.WordLength}: {node.ToString()})");
                sb.Append(TraverseInOrder(node.Right));
            }
            return sb.ToString();
        }
        private string TraversePostOrder(Node node)
        {
            StringBuilder sb = new StringBuilder();
            if (node != null)
            {
                sb.Append(TraversePostOrder(node.Left));
                sb.Append(TraversePostOrder(node.Right));
                sb.Append($"(Length {node.WordLength}: {node.ToString()})");

            }
            return sb.ToString();
        }
        public string PreOrder()
        {
            StringBuilder sb = new StringBuilder();

            if (Root == null)
            {
                sb.Append("Tree is empty");
            }
            else
            {
                sb.Append(TraversePreOrder(Root));
            }
            return sb.ToString();
        }
        public string InOrder()
        {
            StringBuilder sb = new StringBuilder();

            if (Root == null)
            {
                sb.Append("Tree is empty");
            }
            else
            {
                sb.Append(TraverseInOrder(Root));
            }
            return sb.ToString();
        }
        public string PostOrder()
        {
            StringBuilder sb = new StringBuilder();

            if (Root == null)
            {
                sb.Append("Tree is empty");
            }
            else
            {
                sb.Append(TraversePostOrder(Root));
            }
            return sb.ToString();
        }
        private Node Search(Node tree, Node node)
        {
            if (tree != null)
            {
                if (tree.Word.CompareTo(node.Word) == 0)
                {
                    return tree;
                }
                if ((tree.Word.CompareTo(node.Word) < 0))
                {
                    return Search(tree.Left, node);
                }
                else
                {
                    return Search(tree.Right, node);
                }
            }
            return null;
        }
        public string Find(string word)
        {
            Node node = new Node(word);
            node = Search(Root, node);
            if (node != null && node.Word == word)  //debug line 
            {
                return "Target: " + word + " Node found " + node.ToString();
            }
            else
            {
                return "Target: " + word + " Node not found Or Tree is empty";
            }
        }
        private Node Delete(Node tree, Node node)
        {
            if (tree == null)
            {
                return tree;
            }
            if (tree.Word.CompareTo(node.Word) < 0)
            {
                tree.Left = Delete(tree.Left, node);
            }
            else if (tree.Word.CompareTo(node.Word) > 0)
            {
                tree.Right = Delete(tree.Right, node);
            }
            else
            {
                if (tree.Left == null)
                {
                    return tree.Right;
                }
                else if (tree.Right == null)
                {
                    return tree.Left;
                }
                else
                {
                    tree.WordLength = MinValue(tree.Right);
                    tree.Right = Delete(tree.Right, tree);
                }
            }
            return tree;
        }
        public string Remove(string word)
        {
            Node node = new Node(word);
            node = Search(Root, node);
            if (node != null)
            {
                Root = Delete(Root, node);
                return "Target: " + word + " Node removed";
            }
            else
            {
                return "Target: " + word + " Node not found";
            }
        }

        private int MinValue(Node node)
        {
            int minval = node.WordLength;
            while (node.Left != null)
            {
                minval = node.Left.WordLength;
                node = node.Left;
            }
            return minval;
        }
    
        
      
        private int FindTreeDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */      //this is giving rtuening the size of the txt file
                int leftDepth = FindTreeDepth(node.Left);
                int rightDepth = FindTreeDepth(node.Right);

                /* use the larger one */
                if (leftDepth > rightDepth)
                    return (leftDepth + 1);
                else
                    return (rightDepth + 1);
            }
        }

        public int TreeDepth()
        {
            return FindTreeDepth(Root);
        }
    }
}
