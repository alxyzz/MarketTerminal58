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
        Game GameData;
        bool mining = false;
        public List<Button> graphTravelButtons;
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

            btn_GoLeftSubtree.Visible = false;
            btn_GoRightSubtree.Visible = false;
            luckLabel.Visible = false;
            YouGot.Visible = false;
            graphTravelButtons = new List<Button>();
            graphTravelButtons.Add(btn_travel);
            graphTravelButtons.Add(btn_travel_prev);
            graphTravelButtons.Add(btn_travel_next);




            lab_treenode_left.Text = "";
            lab_treenode_self.Text = "";
            lab_treenode_right.Text = "";

            btn_travel.Click += new System.EventHandler(this.OnClickTravel);
            btn_travel_prev.Click += new System.EventHandler(this.OnClickTravelPrev);
            btn_travel_next.Click += new System.EventHandler(this.OnClickTravelNext);

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


        public enum ListSortingType
        {
            Name,
            Value,
            Change,
        }

        public enum ListSortOrder
        {
            Ascending,
            Descending
        }


        private void HandleMap()
        {
            label2.Text = "Travel Options";
            if (GameData.currentGraphNode == null)
            {
                System.Diagnostics.Debug.WriteLine("Cannot HandleMap, current graphnode null.");
                label_playerGraphLocation.Text = "";
                return;
            }
            label_playerGraphLocation.Text = "Node " + GameData.currentGraphNode.Identification.ToString();

         
            rtf_Graph.Text = GameData.nodes.ToString();
           

        }


       

        private void SetupGameLogic()
        {
            GameData = new Game();

            GameData.GameLoop(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGraphics();
            SetupGameLogic();
            InitializeUIElements();

            timer1.Start();
        }



        class ListBoxCoinEntry
        {
            public string name;
            public float owned;
            public float price;
            public float lastChange;
            public Currency reference;

        }
        public ListSortingType sortType;
        public ListSortOrder sortOrder;
        public void UpdateMineDisplay()
        {
            if (GameData.currentGraphNode.Shaft.Left != null)
            {
                lab_treenode_left.Text = "Shaft " + GameData.currentGraphNode.Shaft.Left.id;
            }
                lab_treenode_self.Text = "Shaft " + GameData.currentGraphNode.Shaft.id;
            if (GameData.currentGraphNode.Shaft.Right != null)
            {
                lab_treenode_right.Text = "Shaft " + GameData.currentGraphNode.Shaft.Right.id;
            }

           
            switch (GameData.currentGraphNode.Shaft.yieldQuality)
            {
                case YieldValue.Intact:
                    img_Currnode.Image = Resource1.freshNode;
                    break;
                case YieldValue.Low:
                    img_Currnode.Image = Resource1.lowNode;
                    break;
                case YieldValue.Depleted:
                    img_Currnode.Image = Resource1.depletedNode;
                    break;
                default:
                    break;
            }
            if (GameData.currentGraphNode.Shaft.Left != null)
            {
                switch (GameData.currentGraphNode.Shaft.Left.yieldQuality)
                {
                    case YieldValue.Intact:
                        img_Leftnode.Image = Resource1.freshNode;
                        break;
                    case YieldValue.Low:
                        img_Leftnode.Image = Resource1.lowNode;
                        break;
                    case YieldValue.Depleted:
                        img_Leftnode.Image = Resource1.depletedNode;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                img_Leftnode.Image = Resource1.unknownNode;
            }
            if (GameData.currentGraphNode.Shaft.Right != null)
            {
                switch (GameData.currentGraphNode.Shaft.Right.yieldQuality)
                {
                    case YieldValue.Intact:
                        img_Rightnode.Image = Resource1.freshNode;
                        break;
                    case YieldValue.Low:
                        img_Rightnode.Image = Resource1.lowNode;
                        break;
                    case YieldValue.Depleted:
                        img_Rightnode.Image = Resource1.depletedNode;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                img_Rightnode.Image = Resource1.unknownNode;
            }
        }


        private List<ListBoxCoinEntry> ConvertToListBox(Dictionary<string, Currency> dic)
        {

            List<ListBoxCoinEntry> b = new List<ListBoxCoinEntry>();
            foreach (KeyValuePair<string, Currency> item in dic)
            {
                ListBoxCoinEntry a = new ListBoxCoinEntry();

                a.name = item.Value.GetName();
                a.owned = item.Value.GetAmt();
                a.price = item.Value.GetValue();
                a.lastChange = item.Value.lastValueChange;
                a.reference = item.Value;
                b.Add(a);

            }


            






            return b;
        }



        public void UpdateCryptoWalletDisplay()
        {
            List<ListBoxCoinEntry> b = ConvertToListBox(Wallet.content).OrderByDescending(x => x.owned).ToList();
            List<string> cryptoList = new List<string>();
            foreach (var item in b)
            {
                //throw new Exception(item.name);

                string newEntry = item.name +"  "+ item.owned +"  " + item.price;

                cryptoList.Add(newEntry);
            }

            // System.Diagnostics.Debug.WriteLine("UpdateCryptoInventory just ran as part of the periodic loop in Game.");
            // Running on the worker thread
            //this is synchronous btw
            this.SuspendLayout();
            this.listBox1.Invoke((MethodInvoker)delegate
            {
                listBox1.Items.Clear();
                foreach (string item in cryptoList)
                {
                    listBox1.Items.Add(item);
                }
            });
            this.ResumeLayout();
            // Back on the worker thread

        }
        private void TimerTick(object sender, EventArgs e)
        {
            Wallet.ChangePrices();
            label_MUD.Text = Wallet.MUD.ToString();
            UpdateMineDisplay();
            UpdateCryptoMarketDisplay();
            UpdateCryptoWalletDisplay();
            timeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
            switch (GameData._currentScreenState)
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
                    //HandleCrypto();

                    break;
                default:
                    break;
            }
            

        }





        private void ToggleSortType(ListSortingType b)
        {
            sortType = b;
        }



        private void UpdateCryptoMarketDisplay()
        {

            List<ListBoxCoinEntry> b = ConvertToListBox(Wallet.content);
            switch (sortType)
            {
                case ListSortingType.Name:
                    switch (sortOrder)
                    {
                        case ListSortOrder.Ascending:
                            b = b.OrderBy(x => x.name).ToList();
                            break;
                        case ListSortOrder.Descending:
                            b = b.OrderByDescending(x => x.name).ToList();
                            break;
                    }
                    break;
                case ListSortingType.Value:
                    switch (sortOrder)
                    {
                        case ListSortOrder.Ascending:
                            b = b.OrderBy(x => x.price).ToList();
                            break;
                        case ListSortOrder.Descending:
                            b = b.OrderByDescending(x => x.price).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                
                case ListSortingType.Change:
                    switch (sortOrder)
                    {
                        case ListSortOrder.Ascending:
                            b = b.OrderBy(x => x.lastChange).ToList();
                            break;
                        case ListSortOrder.Descending:
                            b = b.OrderByDescending(x => x.lastChange).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
           


            List<string> cryptoList = new List<string>();
            foreach (var item in b)
            {
                //throw new Exception(item.name);
                string newEntry = item.name + "     " + item.price + "    " + item.lastChange;

                cryptoList.Add(newEntry);
            }





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
            if (list_crypto_coins.SelectedItem == null)
            {
                return;
            }
            GameData.currentCurrency = GetCurrencyFromSelectedIndex(list_crypto_coins.SelectedItem.ToString().Substring(0, 4));
            rtf_crypto_description.Text = GameData.currentCurrency.GetName() + " - " + GameData.currentCurrency.GetValue();
        }

        private Currency GetCurrencyFromSelectedIndex(string firstThreeLetters)
        {
            return GameData.currentCurrency = Wallet.content.Where(z => z.Value.GetName() == firstThreeLetters).FirstOrDefault().Value;
        }

        Tuple<Currency, float, YieldValue, bool> lastResult;
        private int miningInterval = 0;
        private void HandleMining()
        {
            System.Diagnostics.Debug.WriteLine("just got another HandleMining tick.");
            miningInterval++;
            countdown.Text = miningInterval.ToString();
            if (miningInterval < 4)
            {
                return;
            }
            miningInterval = 0;

            YouGot.Visible = false;
            System.Diagnostics.Debug.WriteLine("@HandleMining did a tick");
            lastResult = GameData.GetMineResult();
            GameData.GainCurrency(lastResult.Item1, lastResult.Item2);
            YouGot.Visible = true;
            YouGot.Text = "You got " + lastResult.Item2.ToString() + " " + lastResult.Item1.GetName();
            luckLabel.Visible = lastResult.Item4;
            countdown.Text = miningInterval.ToString();
            RefreshMineInfo();
        }

        private void RefreshMineInfo()
        {
            currPrimaryLabel.Text = GameData.currentGraphNode.Shaft.primary.GetName();
            currSecondaryLabel.Text = GameData.currentGraphNode.Shaft.secondary.GetName();
            lab_AvgYield.Text = "Coins in shaft node: " +GameData.currentGraphNode.Shaft.yield.ToString();
        }
        private void SwitchVisibility(GameState newState = GameState.Undefined)
        {
            mining = false;
            GameData._currentScreenState = newState;
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
                    RefreshInfo(GameData.blurb_Mine, GameData.tip_Mine);
                    RefreshMineInfo();
                   
                    break;
                case GameState.Map:
                    foreach (Panel item in panels)
                    {
                        item.Visible = false;
                        item.Enabled = false;
                    }
                    mapPanel.Visible = true;
                    mapPanel.Enabled = true;
                    RefreshInfo(GameData.blurb_Map, GameData.tip_Map);
                    HandleMap();
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
            UpdateCryptoMarketDisplay();

                    RefreshInfo(GameData.blurb_Crypto, GameData.tip_Crypto);
                    break;
                default:
                    SwitchVisibility(GameState.Menu);
                    break;
            }
        }
        #endregion


        #region UI Events



        public void OnClickTravel(object sender, EventArgs e)
        {
           
            if (Wallet.MUD >= GameData.currentlySelectedTravelGraph.Weight)
            {
                Wallet.MUD -= GameData.currentlySelectedTravelGraph.Weight;

                GameData.MoveOnGraphMap(GameData.currentlySelectedTravelGraph);



            }
            else
            {
                label2.Text = "Not enough MUD.";
            }

            label_playerGraphLocation.Text = "Node " + GameData.currentGraphNode.Identification.ToString();
        }
        public int travelIndex = 0;
        public void OnClickTravelPrev(object sender, EventArgs e)
        {
            travelIndex--;
            FinalizeTravel();
        }


        private void FinalizeTravel()
        {
            if (travelIndex < 0)
            {
                travelIndex = 0;
            }
            if (travelIndex >= GameData.currentGraphNode.Edges.Count)
            {
                travelIndex =  GameData.currentGraphNode.Edges.Count-1;
            }
            GameData.currentlySelectedTravelGraph = GameData.currentGraphNode.Edges[travelIndex];
            btn_travel.Text = GameData.currentlySelectedTravelGraph._name;
        }
        public void OnClickTravelNext(object sender, EventArgs e)
        {
            travelIndex++;

            FinalizeTravel();
        }
        public void OnClickTravelFour(object sender, EventArgs e)
        {
            OnClickTravel(3);
        }

        public void OnClickTravel(int i)
        {
            GraphEdge targetEdge = GameData.currentGraphNode.Edges[i];
            if (Wallet.MUD >= targetEdge.Weight)
            {
                Wallet.MUD -= targetEdge.Weight;
               
                GameData.MoveOnGraphMap(targetEdge);
              
               

            }
            else
            {
                label2.Text = "Not enough MUD.";
            }

            label_playerGraphLocation.Text = "Node " + GameData.currentGraphNode.Identification.ToString();
        }










        public void ShopInputError(string b)
        {
            rtf_crypto_description.Text = b ;
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
                btn_AdvanceDrill.Text = "Activate Drill";

                btn_GoLeftSubtree.Visible = true;
                btn_GoRightSubtree.Visible = true;
            }
            else
            {
                btn_AdvanceDrill.Text = "Retract Drill";
                btn_GoLeftSubtree.Visible = false;
                btn_GoRightSubtree.Visible = false ;
            }
            mining = !mining;
            RefreshMineInfo();
        }

       



        #endregion

        

        

        private void button6_Click(object sender, EventArgs e)
        {
            if (sortOrder == ListSortOrder.Ascending)
            {
                sortOrder = ListSortOrder.Descending;
                asc.Text = "Desc";
            }
            else
            if (sortOrder == ListSortOrder.Descending)
            {
                sortOrder = ListSortOrder.Ascending;
                asc.Text = "Asc";
            }
            UpdateCryptoMarketDisplay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleSortType(ListSortingType.Name);
            UpdateCryptoMarketDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToggleSortType(ListSortingType.Value);
            UpdateCryptoMarketDisplay();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToggleSortType(ListSortingType.Change);
            UpdateCryptoMarketDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {//buy
            if (string.IsNullOrEmpty(inputBox.Text))
            {
                return;
            }
            float b = float.Parse(inputBox.Text);
            GameData.ProcessInput(b, true);
            inputBox.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {//sell
            if (string.IsNullOrEmpty(inputBox.Text))
            {
                return;
            }
           float b = float.Parse(inputBox.Text);
            GameData.ProcessInput(b, false);
            inputBox.Text = "";
          
        }

        private void btn_GoRightSubtree_Click(object sender, EventArgs e)
        {
            GameData.MoveOnTree(false); RefreshMineInfo();
        }

        private void btn_GoLeftSubtree_Click(object sender, EventArgs e)
        {
            GameData.MoveOnTree(true); RefreshMineInfo();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
