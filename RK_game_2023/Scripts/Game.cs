using RK_ConsoleGame.Screens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;

namespace RK_game_2023

{/// <summary>
/// handles display and basic game logic
/// </summary>
/// 


    public static class Presets 
    {

        public static float startingMoney = 1000;
        public static int standardLuck = 15;
        public static float currAmt = 10;//amount of currencies generated. outside MUD.
        public static int graphNodeAmount = 5;
        public static int treeMaxDepth = 5;
        public static int coinNameLength = 4;
        public static int lastGraphNodeId;
        public static int lastTreeNodeId;
    }

  public static class GlobalVariables
    {
        public static bool _MapGenerated = false;
    }
    

    class Game
    {
        #region vars

        







        private bool playing;
        private System.Timers.Timer periodicAction;
        private int timerInterval = 2000;
        public GameState _currentScreenState = GameState.Menu;

        public Graph nodes = new Graph();
        
        #endregion

        #region Display Variables
        private List<string> display = new List<string>();

        //blurbs. stuff that appears at the top of the screen.
        public string blurb_Mine = "Mine : Wealth awaits..." + Environment.NewLine + "";
        public string blurb_Map = "Map : Travel the cryptosphere." + Environment.NewLine + "";
        public string blurb_Crypto = "Crypto : Exchange those trashcoins for some *real* Mongolian Uranium Dollars!" + Environment.NewLine + "";

        //tips. indicators for what the player can currently do, that appear at the bottom of the screen.
        public string tip_Mine = "Wealth awaits...";
        public string tip_Map =  "Tip: Shafts restore after you leave their area. Nature reclaims them - what splendorous beatitude...";
        public string tip_Crypto =  "Or, you could invest... \n Select your desired coin via the mouse, then input 'buy' or 'sell' followed by your desired value, then press enter.";

        //private void misc_Help = ""





        #endregion

        #region Components
        public Form1 gameForm;
        
        public GraphNode currentGraphNode;
        public GraphEdge currentlySelectedTravelGraph;
        public Currency currentCurrency;
        #endregion

        #region Setup & Logic
        public void GameLoop(Form1 formref)
        {
            gameForm = formref;
            SetupTimer();
            InitializeComponents();
        }

        public string GetTreeData()
        {
            return currentGraphNode.Shaft.GetTreeData();
        }

        private void InitializeComponents()
        {
            Wallet.Initialize();
           
            currentGraphNode = new GraphNode();
            nodes.addNode(currentGraphNode);



            GraphNode a1 = new GraphNode();
            nodes.addNode(a1);

            GraphNode a2 = new GraphNode();
            nodes.addNode(a2);

            GraphNode a3 = new GraphNode();
            nodes.addNode(a3);

            GraphNode a4 = new GraphNode();
            nodes.addNode(a4);

            GraphNode a5 = new GraphNode();
            nodes.addNode(a5);


            nodes.addEdge(currentGraphNode, a5, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));
            nodes.addEdge(currentGraphNode, a2, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));
            nodes.addEdge(currentGraphNode, a4, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));
            nodes.addEdge(a1 , a3, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));
            nodes.addEdge(a3, a2, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));
            nodes.addEdge(a1, a5, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));
            nodes.addEdge(a5, a2, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));
            nodes.addEdge(a2, a4, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500));





        }



        public List<GraphEdge> GetPossibleGraphMoves()
        {
            return currentGraphNode.Edges;
        }

        public void MoveOnGraphMap(GraphEdge d)
        {
            if (currentGraphNode != d._A)
            {
                if (currentGraphNode == d._B)
                {
                    currentGraphNode = d._A;
                    
                }
            }
            else if (currentGraphNode != d._B)
            {
                if (currentGraphNode == d._A)
                {
                    currentGraphNode = d._B;
                }
            }
            else
            {

                throw new Exception("MoveOnGraphMap @ 134 - Tried to move to an unconnected GraphNode.");
            }
          
        }


        public void MoveOnTree(bool left)
        {
           
            if (left)
            {
                if (currentGraphNode.Shaft.Left != null)
                {
                    currentGraphNode.ChangeShaft(currentGraphNode.Shaft.Left); gameForm.UpdateMineDisplay();
                    return;
                }
                
            }
            if (currentGraphNode.Shaft.Right != null)
                currentGraphNode.ChangeShaft(currentGraphNode.Shaft.Right); gameForm.UpdateMineDisplay();
        }

        /// <summary>
        /// processes inputs
        /// </summary>
        public void ProcessInput(float qty, bool buy)
        {
            if (buy)
            {
                float price = qty * currentCurrency.GetValue();
                if (Wallet.MUD >= price)
                {
                    Wallet.Transaction(-price, currentCurrency, qty);
                }
                else
                {
                    gameForm.ShopInputError("Not enough money.");
                }
            }
            else
            {//selling
                float price = qty * currentCurrency.GetValue();

                Wallet.Transaction(price, currentCurrency, -qty);
                
            }
                   
           
           
        }



        

        public void GainCurrency(Currency c, float i)
        {

            
            Wallet.ModifyAmount(c.GetName(), i);


        }

        public Tuple<Currency, float, YieldValue, bool> GetMineResult()
        {
            return currentGraphNode.Shaft.Mine();
        }
       
        #endregion

        #region Timer

        static int i;
       


        public List<string> GetCryptoUpdate()
        {
            List<string> a = new List<string>();
            foreach (KeyValuePair<string, Currency> item in Wallet.content)
            {
                string msg = item.Key + "         " + item.Value.GetAmt() +"         "+ item.Value.GetValue() + "       " + item.Value.lastValueChange;
                a.Add(msg);
            }

            return a;
        }


        private void SetupTimer()
        {
            //periodicAction = new System.Timers.Timer(timerInterval);
            //periodicAction.Elapsed += OnTimedEvent;
            //periodicAction.AutoReset = true; // in miliseconds
            //periodicAction.Enabled = true;


        }

        #endregion




    }


}
