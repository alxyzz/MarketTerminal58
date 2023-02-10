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
        Undefined,
        Mine, //This screen should allow the player to choose which subtree they want to follow. To leave, get help, etc.
        Map, //This screen should allow the player to move around the graph world map by inputting a number associated to a certain neighboring graph node. the weight of the edge is the cost of passage
        Menu, //allow the player to exit, select enter game, or get help
        Help, //explain the game a bit
        Crypto //accessible during Mine or Map, allows player to exchange cryptos for MUD (Mongolian Uranium-Dollars)
    }

    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>();
        Game gameref;
        bool mining = false;
        public List<Button> graphTravelButtons;
        public List<GraphEdge> travelPoints;
        public List<Label> travelCostLabel;
        public Form1()
        {
            InitializeComponent();
        }

        #region Other Functionality

        private void InitializeUIElements()
        {
            panels.Add(minePanel);
            panels.Add(helpPanel);
            panels.Add(cryptoPanel);
            panels.Add(mapPanel);

            graphTravelButtons = new List<Button>();
            graphTravelButtons.Add(btn_travel1);
            graphTravelButtons.Add(btn_travel2);
            graphTravelButtons.Add(btn_travel3);
            graphTravelButtons.Add(btn_travel4);
            btn_travel1.Click += new System.EventHandler(this.OnClickTravelOne);
            btn_travel2.Click += new System.EventHandler(this.OnClickTravelTwo);
            btn_travel3.Click += new System.EventHandler(this.OnClickTravelThree);
            btn_travel4.Click += new System.EventHandler(this.OnClickTravelFour);
            travelCostLabel = new List<Label>() { costLabel1 , costLabel2, costLabel3, costLabel4};
        }

        public void SwitchPanel(GameState b)
        {
            switch (b)
            {
                case GameState.Mine:

                    break;
                case GameState.Map:

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


        private void SetupGraphics()
        {
            this.Size = new Size(753, 539);
            minePanel.Location = mapPanel.Location;
            cryptoPanel.Location = mapPanel.Location;
            helpPanel.Location = mapPanel.Location;
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }


        enum ListSortingType
        {
            Name,
            Value,
            Decrease,
            Increase,
        }

        enum ListSortOrde
        {
            Ascending,
            Descending
        }


        private void HandleMap()
        {
            if (gameref.currentGraphNode == null)
            {
                label_playerGraphLocation.Text = "";
            }else label_playerGraphLocation.Text = "Node " + gameref.currentGraphNode.Identification.ToString();

            for (int i = 0; i < graphTravelButtons.Count; i++)
            {
                graphTravelButtons[i].Enabled = travelCostLabel[i].Enabled = false;

            }
            travelPoints = new List<GraphEdge>(gameref.currentGraphNode.Edges.Count);
            
            for (int i = 0; i < gameref.currentGraphNode.Edges.Count; i++)
            {
                graphTravelButtons[i].Enabled = travelCostLabel[i].Enabled = true;
                travelCostLabel[i].Text = travelPoints[i].Weight.ToString();
                graphTravelButtons[i].Text = travelPoints[i]._B.Identification.ToString() + " to " + travelPoints[i]._A.Identification.ToString();
            }

            rtf_Graph.Text = gameref.currentGraphNode.GetGraphMatrix();
        }

        private void SetupGameLogic()
        {
            gameref = new Game();

            gameref.GameLoop(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGraphics();
            SetupGameLogic();
            InitializeUIElements();

            timer1.Start();
        }
        public void UpdateCryptoInventory(List<string> CryptoList)
        {
            Wallet.ChangePrices();
            System.Diagnostics.Debug.WriteLine("UpdateCryptoInventory just ran as part of the periodic loop in Game.");
            // Running on the worker thread
            //this is synchronous btw
            this.SuspendLayout();
            this.listBox1.Invoke((MethodInvoker)delegate
            {
                listBox1.Items.Clear();
                foreach (string item in CryptoList)
                {
                    listBox1.Items.Add(item);
                }
            });
            this.ResumeLayout();
            // Back on the worker thread

            HandleCrypto();
        }
        private void TimerTick(object sender, EventArgs e)
        {

            UpdateCryptoInventory(gameref.GetCryptoUpdate());
            timeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
            switch (gameref._currentScreenState)
            {
                case GameState.Mine:
                    if (mining)
                    {
                        HandleMining();
                    }
                    break;
                case GameState.Map:
                    HandleMap();
                    break;
                case GameState.Crypto:
                    HandleCrypto();
                    break;
                default:
                    break;
            }
            

        }





        private void HandleCrypto()
        {


            List<string> cryptoList = new List<string>();
            foreach (KeyValuePair<string, Currency> item in Wallet.content)
            {

                Currency coin = item.Value;
                string newEntry = item.Key+" - "+ coin.GetValue() + "" + coin.lastValueChange;
                cryptoList.Add(newEntry);

            }

            System.Diagnostics.Debug.WriteLine("UpdateCryptoInventory just ran as part of the periodic loop in Game.");
            // Running on the worker thread
            //this is synchronous btw
            this.SuspendLayout();
            this.list_crypto_coins.Invoke((MethodInvoker)delegate
            {
                list_crypto_coins.Items.Clear();
                foreach (string item in cryptoList)
                {
                    list_crypto_coins.Items.Add(item);
                }
            });
            this.ResumeLayout();

        }


        private void List_crypto_coins_SelectedIndexChanged(object sender, EventArgs e)
        {


            string firstThreeLetters = list_crypto_coins.SelectedItem.ToString().Substring(0, 4);
            //throw new Exception(list_crypto_coins.SelectedItem.ToString().Substring(0, 4));
            gameref.currentCurrency = Wallet.content.Where(z => z.Value.GetName() == firstThreeLetters).FirstOrDefault().Value;


            rtf_crypto_description.Text = gameref.currentCurrency.GetName() + " - " + gameref.currentCurrency.GetValue();

        }



        Tuple<Currency, float, YieldValue, bool> lastResult;
        private void HandleMining()
        {
            luckLabelText.Visible = false;


            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value > 3)
            {
                lastResult = gameref.GetMineResult();
                luckLabelText.Visible = true;
                luckLabelText.Text = "You just found " + lastResult.Item2.ToString() + " " + lastResult.Item1.GetName();
            }
            luckLabel.Visible = lastResult.Item4;
            luckLabelText.Visible = lastResult.Item4;
        }
        private void SwitchVisibility(GameState newState = GameState.Undefined)
        {
            switch (newState)
            {
                case GameState.Mine:
                    foreach (Panel item in panels)
                    {
                        item.Visible = false;
                        item.Enabled = false;
                    }
                    minePanel.Visible = true;
                    minePanel.Enabled = true;
                    RefreshInfo(gameref.blurb_Mine, gameref.tip_Mine);
                    break;
                case GameState.Map:
                    foreach (Panel item in panels)
                    {
                        item.Visible = false;
                        item.Enabled = false;
                    }
                    mapPanel.Visible = true;
                    mapPanel.Enabled = true;
                    RefreshInfo(gameref.blurb_Map, gameref.tip_Map);
                    break;
                case GameState.Help:
                    foreach (Panel item in panels)
                    {
                        item.Visible = false;
                        item.Enabled = false;
                    }
                    helpPanel.Visible = true;
                    helpPanel.Enabled = true;
                    RefreshInfo("Help information. :)", "Your friendly neighborhood readme.");
                    break;
                case GameState.Crypto:
                    foreach (Panel item in panels)
                    {
                        item.Visible = false;
                        item.Enabled = false;
                    }
                    cryptoPanel.Visible = true;
                    cryptoPanel.Enabled = true;
                    
                    RefreshInfo(gameref.blurb_Crypto, gameref.tip_Crypto);
                    break;
                default:
                    SwitchVisibility(GameState.Menu);
                    break;
            }
        }
        #endregion


        #region UI Events



        public void OnClickTravelOne(object sender, EventArgs e)
        {
            OnClickTravel(0);
        }
        public void OnClickTravelTwo(object sender, EventArgs e)
        {
            OnClickTravel(1);
        }
        public void OnClickTravelThree(object sender, EventArgs e)
        {
            OnClickTravel(2);
        }
        public void OnClickTravelFour(object sender, EventArgs e)
        {
            OnClickTravel(3);
        }

        public void OnClickTravel(int i)
        {
            if (travelPoints[i] == null)
            {
                throw new Exception("Null Exception Error @ OnClickTravel - could not find the targeted graph edge.");
            }
            GraphEdge b = travelPoints[i];
            if (Wallet.MUD >= b.Weight)
            {
                Wallet.MUD -= b.Weight;
                GraphNode other = travelPoints[i].getOther(gameref.currentGraphNode);
                gameref.MoveOnGraphMap(b);
              
               

            }
            else
            {
                //make funny noise
            }
        }



       



       


      

      


        public void InputPressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gameref.ProcessInput(inputBox.Text);
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

        private void worldmap_btn_GotoMine_Click(object sender, EventArgs e)
        {
            SwitchVisibility(GameState.Mine);

        }




      

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            SwitchVisibility(GameState.Crypto);
        }

        private void btn_Map_Click(object sender, EventArgs e)
        {
            SwitchVisibility(GameState.Map);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            SwitchVisibility(GameState.Help);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_AdvanceDrill_Click(object sender, EventArgs e)
        {
            if (mining)
            {
                mining = false;
                btn_AdvanceDrill.Text = "Engage Drill";

                btn_GoLeftSubtree.Visible = true;
                btn_GoRightSubtree.Visible = true;
            }
            else
            {
                btn_AdvanceDrill.Text = "Retract Drill";
                mining = true;
                btn_GoLeftSubtree.Visible = false;
                btn_GoRightSubtree.Visible = false;
            }

        }

        private void btn_TreeData_Click(object sender, EventArgs e)
        {

            rtfbox_TreeData.Text = gameref.GetTreeData();

        }



        #endregion

       
    }
}
