using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//there is something about working without unity that is quite enjoyable. nothing but a man and his visual studio
namespace RK_game_2023
{
    class TreeNode
    {
        private TreeNode root;
        private TreeNode left;
        private TreeNode right;
        private object Value;
        #region Game Elements




        #endregion





#region Properties
        public object GetValue()
        {
            return Value;
        }

        public TreeNode Root
        {
            get => root;
            set => root = value;
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
#endregion
        //values - gain per turn, luck factor, yield
        //right node is always luckier but limit and gain decreases. luck can increase up to 75 percent chance of random coins
        //left node is less luckier but potentialQuantity steadily decreases until it reaches 40 percent at the last node.
        //you can rev up the drill up to 5 times to increase the speed for same amount of turns, which multiplies gain per turn (makes the node run out faster too
        //if node is depleted all gains are divided by 10
        //drill automatically moves to selected node (by default left) when node is depleted by customizable amount


        /// <summary>
        /// 
        /// </summary>
        /// <param name="iteration">Iteration</param>
        /// <param name="startCryptoPotentialQuantityPerNode">the amount of potential coins you can get from the starting node. subsequent node pQ amount is affected by the next parameter</param>
        /// <param name="potentialQuantityDecreasePerRankPercentage">each node passed through leads to a decrease in pQ</param>
        /// <param name="potentialQuantityPercentage"></param>
        /// <param name="luckFactorStart"></param>
        /// <param name="luckFactorEnd"></param>
        /// <param name=""></param>
        /// <returns></returns>
   
        public TreeNode Generate(int iteration, int iterationLimit, float startCryptoPotentialQuantityPerNode, float potentialQuantityDecreasePerRankPercentage, float potentialQuantityPercentage, float luckFactorStart, float luckFactorEnd, float luckySubtreeGainDecreaseFactor, float luckySubTreeYieldDecreaseFactor, float steadyBranchGainDecrease, float steadyBranchYieldDecrease)
        {
            TreeNode startNode = new TreeNode();
            if (iteration >= iterationLimit)
            {
                return startNode;
            }

            iteration++;
           

            TreeNode leftNode = new TreeNode();
            TreeNode rightNode = new TreeNode();

            startNode.left = leftNode;
            startNode.right = rightNode;




            return startNode;
        }


        #region Algorithms
        //PreOrder Traversal of the binary tree. Read self, go left, go right.
        void preOrder(TreeNode node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.GetValue() + " ");
            preOrder(node.Left);
            preOrder(node.Right);
        }

        //InOrder Traversal of the binary tree. read left, go left, go root, go right.
        void inOrder(TreeNode node)
        {
            if (node == null)
                return;
            if (node.Left != null) Console.WriteLine(node.Left.GetValue() + " ");
            inOrder(node.Left);

            inOrder(node.Right);
        }
        #endregion
    }
}
