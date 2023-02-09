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
    class Game
    {
        #region vars
       

       

        

       
        

        private bool playing;
        private System.Timers.Timer periodicAction;
        private int timerInterval = 2000;
        private GameState _currentScreenState = GameState.Menu;
        #endregion

        #region Display Variables
        private List<string> display = new List<string>();

        //blurbs. stuff that appears at the top of the screen.
        private string blurb_Menu = "Menu" + Environment.NewLine + "Here you may choose to [p]lay, get some [h]elp, or [q]uit.";
        private string blurb_Mine = "Mine" + Environment.NewLine + "Wealth awaits...";
        private string blurb_Map = "Map" + Environment.NewLine + "Travel the cryptosphere.";
        private string blurb_Help = "Help" + Environment.NewLine + Environment.NewLine + "The game is based around going around on the world map in the form of a graph, finding a mineshaft in the form of a binary tree and gathering crypto currencies from it. ";
        private string blurb_Crypto = "Crypto" + Environment.NewLine + "Exchange those trashcoins for some !real! MUD.";

        //tips. indicators for what the player can currently do, that appear at the bottom of the screen.
        private string tip_Menu = "Keys:" + Environment.NewLine + "Here you may choose to play, get some help, or quit.";
        private string tip_Mine = "Keys:" + Environment.NewLine + "Wealth awaits...";
        private string tip_Map = "Keys:" + Environment.NewLine + "Travel the cryptosphere.";
        private string tip_Crypto = "Keys:" + Environment.NewLine + "[B]ack, [P]urchase, [U]p, [D]own." + Environment.NewLine + "Sort: [A]lphanumeric, [V]alue, Asc[e]nding, Desce[n]ding";

        //private void misc_Help = ""





        #endregion

        #region Components
        private InputManager input; //handles most text based commands
        public Form1 gameForm;
        #endregion

        #region Setup & Logic
        public void GameLoop()
        {
            SetupTimer();
            InitializeComponents();
            SetupAesthetics();
            playing = true;
            while (playing)
            {
                ProcessInput();
               // ProcessTimedEvents();
                RenderDisplay();
            }
        }
        private void InitializeComponents()
        {
            input = new InputManager();
        }
        /// <summary>
        /// sets up the Console window properly.
        /// </summary>
        private void SetupAesthetics()
        {
            //Console.WindowWidth = 50;
            //Console.WindowHeight = 120;
        }


        /// <summary>
        /// processes inputs
        /// </summary>
        private void ProcessInput()
        {
            InputManager.AcceptCommands(Console.ReadLine());
        }



        private void RenderDisplay()
        {
            Render_Title();
            Render_Content();
            Render_Bottom();
           
        }
        string currTitle;
        string currBottomText;




        private void Render_Title()
        {
            string title = "";
            switch (_currentScreenState)
            {
                case GameState.Menu:
                    title = blurb_Menu;

                    break;
                case GameState.Map:
                    title = blurb_Map;

                    break;
                case GameState.Mine:
                    title = blurb_Mine;

                    break;
                case GameState.Crypto:
                    title = blurb_Crypto;

                    break;
                case GameState.Help:
                    title = blurb_Help;

                    break;
            }
            currTitle = title;
        }
        
        private void Render_Bottom()
        {
            string title = "";
            switch (_currentScreenState)
            {
                case GameState.Menu:
                    title = tip_Menu;

                    break;
                case GameState.Map:
                    title = blurb_Map;

                    break;
                case GameState.Mine:
                    title = blurb_Mine;

                    break;
                case GameState.Crypto:
                    title = blurb_Crypto;

                    break;
                case GameState.Help:
                    title = blurb_Help;

                    break;
            }
            currBottomText = title;
        }
        #endregion

        #region Timer

        static int i;
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            i = i * 2;
            List<string> a = new List<string>();
            for (int b = 0; b < 12; b++)
            {
                a.Add("Entry " + b + " - [" + i + "]");
            }

            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                e.SignalTime);

            gameForm.UpdateCryptoInventory(a);




        }

        private void SetupTimer()
        {
            periodicAction = new System.Timers.Timer(timerInterval);
            periodicAction.Elapsed += OnTimedEvent;
            periodicAction.AutoReset = true; // in miliseconds
            periodicAction.Enabled = true;


        }

        #endregion




    }


}
