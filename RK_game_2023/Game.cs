using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;

namespace RK_game_2023
{/// <summary>
/// handles display and basic game logic
/// </summary>
    class Game
    {
        #region vars
        public enum ScreenState
        {
            Mine, //This screen should allow the player to choose which subtree they want to follow. To leave, get help, etc.
            Map, //This screen should allow the player to move around the graph world map by inputting a number associated to a certain neighboring graph node. the weight of the edge is the cost of passage
            Menu, //allow the player to exit, select enter game, or get help
            Help, //explain the game a bit
            Crypto //accessible during Mine or Map, allows player to exchange cryptos for MUD (Mongolian Uranium-Dollars)
        }

        struct ScreenStructure
        {
            string title;

            string bottom;

            public ScreenStructure(string t, string b)
            {
                title = t; bottom = b;
            }
        }


        

        

        private bool playing;
        private Timer periodicAction;
        private int timerInterval = 2000;
        private ScreenState _currentScreenState = ScreenState.Menu;
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
        //private string tip_Menu = "Keys:" + Environment.NewLine + "Here you may choose to play, get some help, or quit.";
        private string tip_Mine = "Keys:" + Environment.NewLine + "Wealth awaits...";
        private string tip_Map = "Keys:" + Environment.NewLine + "Travel the cryptosphere.";
      //  private string tip_Help = "Keys:" + Environment.NewLine + "Here you may choose to play, get some help, or quit.";
        private string tip_Crypto = "Keys:" + Environment.NewLine + "[B]ack, [P]urchase, [U]p, [D]own." + Environment.NewLine + "Sort: [A]lphanumeric, [V]alue, Asc[e]nding, Desce[n]ding";

        //private void misc_Help = ""


        #endregion

        #region Components
        private InputManager input; //handles most text based commands
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


        private void Render_Title()
        {
            string title = "";
            switch (_currentScreenState)
            {
                case ScreenState.Menu:
                    title = blurb_Menu;

                    break;
                case ScreenState.Map:
                    title = blurb_Map;

                    break;
                case ScreenState.Mine:
                    title = blurb_Mine;

                    break;
                case ScreenState.Crypto:
                    title = blurb_Crypto;

                    break;
                case ScreenState.Help:
                    title = blurb_Help;

                    break;
            }
            Console.WriteLine(title);
        }
        private void Render_Content()
        {

        }
        private void Render_Bottom()
        {

        }
        #endregion

        #region Timer
       

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                e.SignalTime);
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
