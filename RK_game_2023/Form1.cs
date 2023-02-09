using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK_game_2023
{
    public enum GameState
    {
        Mine, //This screen should allow the player to choose which subtree they want to follow. To leave, get help, etc.
        Map, //This screen should allow the player to move around the graph world map by inputting a number associated to a certain neighboring graph node. the weight of the edge is the cost of passage
        Menu, //allow the player to exit, select enter game, or get help
        Help, //explain the game a bit
        Crypto //accessible during Mine or Map, allows player to exchange cryptos for MUD (Mongolian Uranium-Dollars)
    }

    public partial class Form1 : Form
    {

         Game gameref;
        public Form1()
        {
            InitializeComponent();
        }


        public void SwitchPanel(GameState b)
        {
            switch (b)
            {
                case GameState.Mine:

                    break;
                case GameState.Map:

                    break;
                case GameState.Menu:

                    break;
                case GameState.Help:

                    break;
                case GameState.Crypto:

                    break;
                default:
                    break;
            }
        }



        public void RefreshInfo(string title, string bottom)
        {
            titleLabel.Text = title;
            helpLabel.Text = bottom;
        }


        public void DisplayGraphs(List<GraphNode> graph)
        {
            //todo here - render a display for the graph
        }


        
        public void PressHelp()
        {
            helpPanel.Visible = !helpPanel.Visible;
        }


        private void SetupGraphics()
        {
            this.Size = new Size(753, 539);
            minePanel.Location = mapPanel.Location;
            cryptoPanel.Location = mapPanel.Location;
            helpPanel.Location = mapPanel.Location;
        }


        private void SetupGameLogic()
        {
            gameref = new Game();
            gameref.GameLoop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGraphics(); 
            SetupGameLogic();
        }




        public void UpdateCryptoInventory(List<string> CryptoList)
        {
            System.Diagnostics.Debug.WriteLine("UpdateCryptoInventory just ran as part of the periodic loop in Game.");
            listBox1.Items.Clear();
            foreach (string item in CryptoList)
            {
                listBox1.Items.Add(item);
            }
        }


        private void InputPressEnter(object sender, KeyEventArgs e)
        {
            gameref.ProcessInput();
        }

        private void btnBuy_click(object sender, EventArgs e)
        {

        }


        public void ListBoxClickEvent(object sender, EventArgs e)
        {

        }


        private void btnSell_click(object sender, EventArgs e)
        {

        }

        private void cryptolistContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void mine_btn_GotoWorldmap_Click(object sender, EventArgs e)
        {

        }

        private void worldmap_btn_GotoMine_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
