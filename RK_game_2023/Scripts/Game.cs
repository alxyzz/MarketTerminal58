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

        public List<GraphNode> nodes;
        
        #endregion

        #region Display Variables
        private List<string> display = new List<string>();

        //blurbs. stuff that appears at the top of the screen.
        public string blurb_Mine = "Mine : Wealth awaits..." + Environment.NewLine + "";
        public string blurb_Map = "Map : Travel the cryptosphere." + Environment.NewLine + "";
        public string blurb_Crypto = "Crypto : Exchange those trashcoins for some *real* Mongolian Uranium Dollars!" + Environment.NewLine + "";

        //tips. indicators for what the player can currently do, that appear at the bottom of the screen.
        public string tip_Mine = "Wealth awaits...";
        public string tip_Map =  "Travel the cryptosphere.";
        public string tip_Crypto =  "Or, you could invest... \n Select your desired coin via the mouse, then input 'buy' or 'sell' followed by your desired value.";

        //private void misc_Help = ""





        #endregion

        #region Components
        public Form1 gameForm;
        
        public TreeNode currentTreeNode;
        public GraphNode currentGraphNode;
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
            return "";
        }

        private void InitializeComponents()
        {
            Wallet.Initialize();
            currentGraphNode = new GraphNode();
            currentGraphNode.GenerateDirectedGraph(Presets.graphNodeAmount);
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
            currentTreeNode = currentGraphNode.Shaft;
        }

        /// <summary>
        /// processes inputs
        /// </summary>
        public void ProcessInput(string b)
        {
            if (CheckTransaction(b.ToLower(), true))
            {

            }
            else if (CheckTransaction(b.ToLower(), false))
            {

            }
           
        }



        private bool CheckTransaction(string input, bool buy)
        {

            if (buy)
            {

            }
            else
            {

            }

        }



        public Tuple<Currency, float, YieldValue, bool> GetMineResult()
        {
            return currentTreeNode.Mine(Scripts.HelperMethods.RandomSeeder.rnd);
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
