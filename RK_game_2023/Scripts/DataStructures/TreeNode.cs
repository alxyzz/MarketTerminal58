using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK_game_2023.Scripts
{
    class TreeNode
    {
        private TreeNode left;
        private TreeNode right;


        private object Value;
        public object GetValue()
        {
            return Value;
        }
        public TreeNode Left
        {
            get => left;
            set => left = value;
        }
        public TreeNode Right
        {
            get => right;
            set => left = value;
        }

        //PreOrder Traversal of the binary tree.
        void preOrder(TreeNode node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.GetValue() + " ");
            preOrder(node.Left);
            preOrder(node.Right);
        }
    }
}
