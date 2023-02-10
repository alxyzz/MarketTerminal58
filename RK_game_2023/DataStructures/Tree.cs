using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//there is something about working without unity that is quite enjoyable. nothing but a man and his visual studio
namespace RK_game_2023
{
    public enum YieldValue
    {
        Intact = 100,
        Low = 25,
        Depleted = 2
    }
    public class TreeNode
    {


        public int id;
     

        private TreeNode root;
        private TreeNode left;
        private TreeNode right;

        #region Game Elements
        public YieldValue yieldQuality = YieldValue.Intact;
        public float coinLeft;
        public int luck = 5;
        public Currency primary;
        public Currency secondary;
        public float yield = 0;
        private float origYield;
        #endregion





        #region Properties
        public YieldValue GetValue()
        {
            if (yield < (origYield / 5))
            {
                return YieldValue.Depleted;
            }
            if (yield < (origYield/2))
            {
                return YieldValue.Low;
            }
           
           
           else return YieldValue.Intact;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <returns>currency type, amount, rough estimation of yield left, wether we got lucky</returns>
        public Tuple<Currency, float, YieldValue, bool> Mine()
        {
            bool gotLucky = false;
            Currency c;
            float i = Scripts.HelperMethods.RandomSeeder.rnd.Next(1, 101);
            coinLeft -= i;
            i += Scripts.HelperMethods.RandomSeeder.rnd.Next(1, luck); //materializes cryptocurrency from the luckosphere
            float incomingYield = Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 0, 5);
            if (i > 99)
            {
                incomingYield *= 10;
                gotLucky = true;
            }

            if (i > 20 && i < 40)
            {
                c = secondary;
            }
            else c = primary;
            
            switch (yieldQuality)
            {

                case YieldValue.Low:
                    incomingYield = (incomingYield / 100) * (int)YieldValue.Low; //25 percent yield
                    break;
                case YieldValue.Depleted:
                    incomingYield = (incomingYield / 100) * (int)YieldValue.Depleted; //two percent yield. basically done.
                    break;
                default:
                    break;
            }



            return new Tuple<Currency, float, YieldValue, bool>(c, incomingYield, yieldQuality, gotLucky);


        }


        public string GetTreeData(string predec = null)
        {
            string msg = "";
            if (predec != null)
            {
                msg = predec;
            }
            msg += "Tree - "+this.id + " leads to ";



            if (Left != null)
            {
                msg += Left.GetTreeData(msg);
            }
            if (Right != null)
            { msg += Right.GetTreeData(msg);

            }
            return msg;
        }
   
        public TreeNode(/*Currency primC, Currency secC, int iteration, int iterationLimit, float luck,  float luckIncrease, float yieldDecrease */)
        {
           


        }

        public void Generate(Currency primC, Currency secC, int iteration, int iterationLimit, float luck, float luckIncrease, float yieldDecrease)
        {
            id = Presets.lastTreeNodeId;
            Presets.lastTreeNodeId++;
            //TreeNode startNode = new TreeNode(primC, secC, iteration, iterationLimit, luck, luckIncrease, yieldDecrease);
            System.Diagnostics.Debug.WriteLine("Generating tree node. Iteration is " + iteration) ;
            yield = Scripts.HelperMethods.RandomSeeder.rnd.Next(300, 500) - (iteration * yieldDecrease);
            primary = primC;
            secondary = secC;
            origYield = yield;

            if (iteration >= iterationLimit)
            {
                return;
            }

            iteration++;


            TreeNode leftNode = new TreeNode();
            leftNode.Generate(primC, secC, iteration + 1, iterationLimit, luck, luckIncrease, yieldDecrease);

            TreeNode rightNode = new TreeNode();
            rightNode.Generate(primC, secC, iteration + 1, iterationLimit, luck, luckIncrease, yieldDecrease);

            left = leftNode;
            right = rightNode;


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


        void postOrder(TreeNode node)
        {
            if (root != null)
            {
                postOrder(root.Left);
                postOrder(root.Right);
                //root.DisplayNode();
            }
        }


        
        #endregion
    }
}
