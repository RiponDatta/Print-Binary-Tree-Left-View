using System;

namespace Print_Binary_Tree_Left_View
{
    public class BinaryTree
    {
        public Node Root;
        private int CurrentLevel = 0;
        public void PrintLeftView(Node root)
        {
            PrintLeftView(root, 1);
        }

        private void PrintLeftView(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (level > CurrentLevel)
            {
                Console.Write(node.Data + " ");
                CurrentLevel = level;
            }

            PrintLeftView(node.Left, level + 1);
            PrintLeftView(node.Right, level + 1);
        }
    }
}
