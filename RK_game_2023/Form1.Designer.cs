
namespace RK_game_2023
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_playerGraphLocation = new System.Windows.Forms.Label();
            this.label_YouAre = new System.Windows.Forms.Label();
            this.btn_travel_next = new System.Windows.Forms.Button();
            this.btn_travel_prev = new System.Windows.Forms.Button();
            this.btn_travel = new System.Windows.Forms.Button();
            this.rtf_Graph = new System.Windows.Forms.RichTextBox();
            this.btn_Map = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.btn_Mine = new System.Windows.Forms.Button();
            this.btn_Shop = new System.Windows.Forms.Button();
            this.minePanel = new System.Windows.Forms.Panel();
            this.countdown = new System.Windows.Forms.Label();
            this.lab_treenode_self = new System.Windows.Forms.Label();
            this.lab_treenode_right = new System.Windows.Forms.Label();
            this.lab_treenode_left = new System.Windows.Forms.Label();
            this.narratorLabelMiner = new System.Windows.Forms.Label();
            this.currSecondaryLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.currPrimaryLabel = new System.Windows.Forms.Label();
            this.YouGot = new System.Windows.Forms.Label();
            this.luckLabel = new System.Windows.Forms.Label();
            this.img_Rightnode = new System.Windows.Forms.PictureBox();
            this.img_Leftnode = new System.Windows.Forms.PictureBox();
            this.img_Currnode = new System.Windows.Forms.PictureBox();
            this.btn_GoLeftSubtree = new System.Windows.Forms.Button();
            this.lab_AvgYield = new System.Windows.Forms.Label();
            this.btn_AdvanceDrill = new System.Windows.Forms.Button();
            this.btn_GoRightSubtree = new System.Windows.Forms.Button();
            this.cryptoPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.asc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.list_crypto_coins = new System.Windows.Forms.ListBox();
            this.rtf_crypto_description = new System.Windows.Forms.RichTextBox();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label_MUD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mapPanel.SuspendLayout();
            this.minePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Rightnode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Leftnode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Currnode)).BeginInit();
            this.cryptoPanel.SuspendLayout();
            this.helpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mapPanel.Controls.Add(this.costLabel1);
            this.mapPanel.Controls.Add(this.label2);
            this.mapPanel.Controls.Add(this.label_playerGraphLocation);
            this.mapPanel.Controls.Add(this.label_YouAre);
            this.mapPanel.Controls.Add(this.btn_travel_next);
            this.mapPanel.Controls.Add(this.btn_travel_prev);
            this.mapPanel.Controls.Add(this.btn_travel);
            this.mapPanel.Controls.Add(this.rtf_Graph);
            this.mapPanel.Location = new System.Drawing.Point(2, 56);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(512, 387);
            this.mapPanel.TabIndex = 2;
            // 
            // costLabel1
            // 
            this.costLabel1.AutoSize = true;
            this.costLabel1.Location = new System.Drawing.Point(243, 281);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(31, 13);
            this.costLabel1.TabIndex = 9;
            this.costLabel1.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Travel Options";
            // 
            // label_playerGraphLocation
            // 
            this.label_playerGraphLocation.AutoSize = true;
            this.label_playerGraphLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerGraphLocation.Location = new System.Drawing.Point(49, 43);
            this.label_playerGraphLocation.Name = "label_playerGraphLocation";
            this.label_playerGraphLocation.Size = new System.Drawing.Size(47, 15);
            this.label_playerGraphLocation.TabIndex = 6;
            this.label_playerGraphLocation.Text = "label2";
            // 
            // label_YouAre
            // 
            this.label_YouAre.AutoSize = true;
            this.label_YouAre.Location = new System.Drawing.Point(24, 17);
            this.label_YouAre.Name = "label_YouAre";
            this.label_YouAre.Size = new System.Drawing.Size(102, 13);
            this.label_YouAre.TabIndex = 5;
            this.label_YouAre.Text = "You are currently at:";
            // 
            // btn_travel_next
            // 
            this.btn_travel_next.Location = new System.Drawing.Point(302, 317);
            this.btn_travel_next.Name = "btn_travel_next";
            this.btn_travel_next.Size = new System.Drawing.Size(75, 23);
            this.btn_travel_next.TabIndex = 3;
            this.btn_travel_next.Text = "Next";
            this.btn_travel_next.UseVisualStyleBackColor = true;
            this.btn_travel_next.Click += new System.EventHandler(this.OnClickTravelNext);
            // 
            // btn_travel_prev
            // 
            this.btn_travel_prev.Location = new System.Drawing.Point(152, 316);
            this.btn_travel_prev.Name = "btn_travel_prev";
            this.btn_travel_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_travel_prev.TabIndex = 2;
            this.btn_travel_prev.Text = "Previous";
            this.btn_travel_prev.UseVisualStyleBackColor = true;
            this.btn_travel_prev.Click += new System.EventHandler(this.OnClickTravelPrev);
            // 
            // btn_travel
            // 
            this.btn_travel.Location = new System.Drawing.Point(227, 308);
            this.btn_travel.Name = "btn_travel";
            this.btn_travel.Size = new System.Drawing.Size(75, 42);
            this.btn_travel.TabIndex = 1;
            this.btn_travel.Text = "Travel";
            this.btn_travel.UseVisualStyleBackColor = true;
            this.btn_travel.Click += new System.EventHandler(this.OnClickTravel);
            // 
            // rtf_Graph
            // 
            this.rtf_Graph.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtf_Graph.Location = new System.Drawing.Point(143, 3);
            this.rtf_Graph.Name = "rtf_Graph";
            this.rtf_Graph.ReadOnly = true;
            this.rtf_Graph.Size = new System.Drawing.Size(229, 232);
            this.rtf_Graph.TabIndex = 0;
            this.rtf_Graph.Text = "";
            // 
            // btn_Map
            // 
            this.btn_Map.Location = new System.Drawing.Point(-1, -1);
            this.btn_Map.Name = "btn_Map";
            this.btn_Map.Size = new System.Drawing.Size(75, 23);
            this.btn_Map.TabIndex = 8;
            this.btn_Map.Text = "Map";
            this.btn_Map.UseVisualStyleBackColor = true;
            this.btn_Map.Click += new System.EventHandler(this.btn_Map_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(551, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 355);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.ContextMenuStripChanged += new System.EventHandler(this.cryptolistContextMenuStripChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(200, 338);
            this.inputBox.MaxLength = 100;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(94, 20);
            this.inputBox.TabIndex = 5;
            // 
            // btn_Mine
            // 
            this.btn_Mine.Location = new System.Drawing.Point(72, -1);
            this.btn_Mine.Name = "btn_Mine";
            this.btn_Mine.Size = new System.Drawing.Size(75, 23);
            this.btn_Mine.TabIndex = 8;
            this.btn_Mine.Text = "Mine";
            this.btn_Mine.UseVisualStyleBackColor = true;
            this.btn_Mine.Click += new System.EventHandler(this.worldmap_btn_GotoMine_Click);
            // 
            // btn_Shop
            // 
            this.btn_Shop.Location = new System.Drawing.Point(145, -1);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(75, 23);
            this.btn_Shop.TabIndex = 10;
            this.btn_Shop.Text = "Shop";
            this.btn_Shop.UseVisualStyleBackColor = true;
            this.btn_Shop.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // minePanel
            // 
            this.minePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.minePanel.Controls.Add(this.countdown);
            this.minePanel.Controls.Add(this.lab_treenode_self);
            this.minePanel.Controls.Add(this.lab_treenode_right);
            this.minePanel.Controls.Add(this.lab_treenode_left);
            this.minePanel.Controls.Add(this.narratorLabelMiner);
            this.minePanel.Controls.Add(this.currSecondaryLabel);
            this.minePanel.Controls.Add(this.label8);
            this.minePanel.Controls.Add(this.currPrimaryLabel);
            this.minePanel.Controls.Add(this.YouGot);
            this.minePanel.Controls.Add(this.luckLabel);
            this.minePanel.Controls.Add(this.img_Rightnode);
            this.minePanel.Controls.Add(this.img_Leftnode);
            this.minePanel.Controls.Add(this.img_Currnode);
            this.minePanel.Controls.Add(this.btn_GoLeftSubtree);
            this.minePanel.Controls.Add(this.lab_AvgYield);
            this.minePanel.Controls.Add(this.btn_AdvanceDrill);
            this.minePanel.Controls.Add(this.btn_GoRightSubtree);
            this.minePanel.Location = new System.Drawing.Point(742, 41);
            this.minePanel.Name = "minePanel";
            this.minePanel.Size = new System.Drawing.Size(512, 387);
            this.minePanel.TabIndex = 3;
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Location = new System.Drawing.Point(464, 365);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(0, 13);
            this.countdown.TabIndex = 20;
            // 
            // lab_treenode_self
            // 
            this.lab_treenode_self.AutoSize = true;
            this.lab_treenode_self.Location = new System.Drawing.Point(233, 193);
            this.lab_treenode_self.Name = "lab_treenode_self";
            this.lab_treenode_self.Size = new System.Drawing.Size(41, 13);
            this.lab_treenode_self.TabIndex = 19;
            this.lab_treenode_self.Text = "label10";
            // 
            // lab_treenode_right
            // 
            this.lab_treenode_right.AutoSize = true;
            this.lab_treenode_right.Location = new System.Drawing.Point(333, 60);
            this.lab_treenode_right.Name = "lab_treenode_right";
            this.lab_treenode_right.Size = new System.Drawing.Size(35, 13);
            this.lab_treenode_right.TabIndex = 18;
            this.lab_treenode_right.Text = "label9";
            // 
            // lab_treenode_left
            // 
            this.lab_treenode_left.AutoSize = true;
            this.lab_treenode_left.Location = new System.Drawing.Point(136, 60);
            this.lab_treenode_left.Name = "lab_treenode_left";
            this.lab_treenode_left.Size = new System.Drawing.Size(35, 13);
            this.lab_treenode_left.TabIndex = 17;
            this.lab_treenode_left.Text = "label1";
            // 
            // narratorLabelMiner
            // 
            this.narratorLabelMiner.AutoSize = true;
            this.narratorLabelMiner.Location = new System.Drawing.Point(377, 328);
            this.narratorLabelMiner.Name = "narratorLabelMiner";
            this.narratorLabelMiner.Size = new System.Drawing.Size(0, 13);
            this.narratorLabelMiner.TabIndex = 16;
            // 
            // currSecondaryLabel
            // 
            this.currSecondaryLabel.AutoSize = true;
            this.currSecondaryLabel.Location = new System.Drawing.Point(39, 224);
            this.currSecondaryLabel.Name = "currSecondaryLabel";
            this.currSecondaryLabel.Size = new System.Drawing.Size(35, 13);
            this.currSecondaryLabel.TabIndex = 15;
            this.currSecondaryLabel.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Currently mining:";
            // 
            // currPrimaryLabel
            // 
            this.currPrimaryLabel.AutoSize = true;
            this.currPrimaryLabel.Location = new System.Drawing.Point(39, 203);
            this.currPrimaryLabel.Name = "currPrimaryLabel";
            this.currPrimaryLabel.Size = new System.Drawing.Size(35, 13);
            this.currPrimaryLabel.TabIndex = 11;
            this.currPrimaryLabel.Text = "label1";
            // 
            // YouGot
            // 
            this.YouGot.AutoSize = true;
            this.YouGot.Location = new System.Drawing.Point(39, 335);
            this.YouGot.Name = "YouGot";
            this.YouGot.Size = new System.Drawing.Size(35, 13);
            this.YouGot.TabIndex = 10;
            this.YouGot.Text = "label1";
            // 
            // luckLabel
            // 
            this.luckLabel.AutoSize = true;
            this.luckLabel.Location = new System.Drawing.Point(14, 318);
            this.luckLabel.Name = "luckLabel";
            this.luckLabel.Size = new System.Drawing.Size(106, 13);
            this.luckLabel.TabIndex = 9;
            this.luckLabel.Text = "Wow! You got lucky!";
            // 
            // img_Rightnode
            // 
            this.img_Rightnode.Image = global::RK_game_2023.Resource1.unknownNode;
            this.img_Rightnode.InitialImage = global::RK_game_2023.Resource1.unknownNode;
            this.img_Rightnode.Location = new System.Drawing.Point(302, 74);
            this.img_Rightnode.Name = "img_Rightnode";
            this.img_Rightnode.Size = new System.Drawing.Size(100, 100);
            this.img_Rightnode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Rightnode.TabIndex = 8;
            this.img_Rightnode.TabStop = false;
            // 
            // img_Leftnode
            // 
            this.img_Leftnode.BackColor = System.Drawing.Color.Transparent;
            this.img_Leftnode.Image = ((System.Drawing.Image)(resources.GetObject("img_Leftnode.Image")));
            this.img_Leftnode.Location = new System.Drawing.Point(104, 74);
            this.img_Leftnode.Name = "img_Leftnode";
            this.img_Leftnode.Size = new System.Drawing.Size(100, 100);
            this.img_Leftnode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Leftnode.TabIndex = 7;
            this.img_Leftnode.TabStop = false;
            // 
            // img_Currnode
            // 
            this.img_Currnode.BackColor = System.Drawing.Color.Transparent;
            this.img_Currnode.Image = ((System.Drawing.Image)(resources.GetObject("img_Currnode.Image")));
            this.img_Currnode.Location = new System.Drawing.Point(204, 209);
            this.img_Currnode.Name = "img_Currnode";
            this.img_Currnode.Size = new System.Drawing.Size(100, 100);
            this.img_Currnode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Currnode.TabIndex = 6;
            this.img_Currnode.TabStop = false;
            // 
            // btn_GoLeftSubtree
            // 
            this.btn_GoLeftSubtree.Location = new System.Drawing.Point(152, 318);
            this.btn_GoLeftSubtree.Name = "btn_GoLeftSubtree";
            this.btn_GoLeftSubtree.Size = new System.Drawing.Size(75, 23);
            this.btn_GoLeftSubtree.TabIndex = 5;
            this.btn_GoLeftSubtree.Text = "Go Left";
            this.btn_GoLeftSubtree.UseVisualStyleBackColor = true;
            this.btn_GoLeftSubtree.Click += new System.EventHandler(this.btn_GoLeftSubtree_Click);
            // 
            // lab_AvgYield
            // 
            this.lab_AvgYield.AutoSize = true;
            this.lab_AvgYield.Location = new System.Drawing.Point(39, 268);
            this.lab_AvgYield.Name = "lab_AvgYield";
            this.lab_AvgYield.Size = new System.Drawing.Size(35, 13);
            this.lab_AvgYield.TabIndex = 3;
            this.lab_AvgYield.Text = "label1";
            // 
            // btn_AdvanceDrill
            // 
            this.btn_AdvanceDrill.Location = new System.Drawing.Point(200, 342);
            this.btn_AdvanceDrill.Name = "btn_AdvanceDrill";
            this.btn_AdvanceDrill.Size = new System.Drawing.Size(115, 23);
            this.btn_AdvanceDrill.TabIndex = 2;
            this.btn_AdvanceDrill.Text = "Activate Drill";
            this.btn_AdvanceDrill.UseVisualStyleBackColor = true;
            this.btn_AdvanceDrill.Click += new System.EventHandler(this.btn_AdvanceDrill_Click);
            // 
            // btn_GoRightSubtree
            // 
            this.btn_GoRightSubtree.Location = new System.Drawing.Point(279, 318);
            this.btn_GoRightSubtree.Name = "btn_GoRightSubtree";
            this.btn_GoRightSubtree.Size = new System.Drawing.Size(75, 23);
            this.btn_GoRightSubtree.TabIndex = 1;
            this.btn_GoRightSubtree.Text = "Go Right";
            this.btn_GoRightSubtree.UseVisualStyleBackColor = true;
            this.btn_GoRightSubtree.Click += new System.EventHandler(this.btn_GoRightSubtree_Click);
            // 
            // cryptoPanel
            // 
            this.cryptoPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cryptoPanel.Controls.Add(this.button6);
            this.cryptoPanel.Controls.Add(this.button2);
            this.cryptoPanel.Controls.Add(this.asc);
            this.cryptoPanel.Controls.Add(this.button5);
            this.cryptoPanel.Controls.Add(this.button4);
            this.cryptoPanel.Controls.Add(this.label1);
            this.cryptoPanel.Controls.Add(this.button3);
            this.cryptoPanel.Controls.Add(this.list_crypto_coins);
            this.cryptoPanel.Controls.Add(this.rtf_crypto_description);
            this.cryptoPanel.Controls.Add(this.inputBox);
            this.cryptoPanel.Location = new System.Drawing.Point(1303, 441);
            this.cryptoPanel.Name = "cryptoPanel";
            this.cryptoPanel.Size = new System.Drawing.Size(512, 387);
            this.cryptoPanel.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(253, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Sell";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(185, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Buy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // asc
            // 
            this.asc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asc.Location = new System.Drawing.Point(317, 2);
            this.asc.Name = "asc";
            this.asc.Size = new System.Drawing.Size(55, 23);
            this.asc.TabIndex = 21;
            this.asc.Text = "Asc";
            this.asc.UseVisualStyleBackColor = true;
            this.asc.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(253, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Change";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(200, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Value";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sort";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(147, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Name";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // list_crypto_coins
            // 
            this.list_crypto_coins.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_crypto_coins.FormattingEnabled = true;
            this.list_crypto_coins.Location = new System.Drawing.Point(147, 25);
            this.list_crypto_coins.Name = "list_crypto_coins";
            this.list_crypto_coins.Size = new System.Drawing.Size(211, 251);
            this.list_crypto_coins.TabIndex = 16;
            this.list_crypto_coins.SelectedIndexChanged += new System.EventHandler(this.List_crypto_coins_SelectedIndexChanged);
            // 
            // rtf_crypto_description
            // 
            this.rtf_crypto_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtf_crypto_description.Location = new System.Drawing.Point(79, 282);
            this.rtf_crypto_description.Name = "rtf_crypto_description";
            this.rtf_crypto_description.ReadOnly = true;
            this.rtf_crypto_description.Size = new System.Drawing.Size(345, 50);
            this.rtf_crypto_description.TabIndex = 6;
            this.rtf_crypto_description.Text = "";
            // 
            // helpPanel
            // 
            this.helpPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.helpPanel.Controls.Add(this.richTextBox1);
            this.helpPanel.Location = new System.Drawing.Point(1281, 28);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(512, 387);
            this.helpPanel.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(506, 381);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(2, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(10, 13);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = " ";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoEllipsis = true;
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(2, 453);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(10, 13);
            this.helpLabel.TabIndex = 12;
            this.helpLabel.Text = " ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(611, 17);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(10, 13);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // label_MUD
            // 
            this.label_MUD.AutoSize = true;
            this.label_MUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MUD.Location = new System.Drawing.Point(667, 422);
            this.label_MUD.Name = "label_MUD";
            this.label_MUD.Size = new System.Drawing.Size(35, 13);
            this.label_MUD.TabIndex = 16;
            this.label_MUD.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mongolian Uranium Dollars:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Owned";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2071, 887);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_MUD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.cryptoPanel);
            this.Controls.Add(this.minePanel);
            this.Controls.Add(this.btn_Shop);
            this.Controls.Add(this.btn_Map);
            this.Controls.Add(this.btn_Mine);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mapPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Terminal v0.52";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            this.minePanel.ResumeLayout(false);
            this.minePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Rightnode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Leftnode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Currnode)).EndInit();
            this.cryptoPanel.ResumeLayout(false);
            this.cryptoPanel.PerformLayout();
            this.helpPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button btn_Map;
        private System.Windows.Forms.Button btn_Mine;
        private System.Windows.Forms.Button btn_Shop;
        private System.Windows.Forms.Panel minePanel;
        private System.Windows.Forms.Panel cryptoPanel;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AdvanceDrill;
        private System.Windows.Forms.Button btn_GoRightSubtree;
        private System.Windows.Forms.Label lab_AvgYield;
        private System.Windows.Forms.Button btn_GoLeftSubtree;
        private System.Windows.Forms.PictureBox img_Currnode;
        private System.Windows.Forms.PictureBox img_Rightnode;
        private System.Windows.Forms.PictureBox img_Leftnode;
        private System.Windows.Forms.Label luckLabel;
        private System.Windows.Forms.Label YouGot;
        private System.Windows.Forms.Label currPrimaryLabel;
        private System.Windows.Forms.RichTextBox rtf_Graph;
        private System.Windows.Forms.Button btn_travel;
        private System.Windows.Forms.Label label_YouAre;
        private System.Windows.Forms.Label label_playerGraphLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtf_crypto_description;
        private System.Windows.Forms.ListBox list_crypto_coins;
        private System.Windows.Forms.Label costLabel1;
        private System.Windows.Forms.Label label_MUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label currSecondaryLabel;
        private System.Windows.Forms.Label narratorLabelMiner;
        private System.Windows.Forms.Label lab_treenode_self;
        private System.Windows.Forms.Label lab_treenode_right;
        private System.Windows.Forms.Label lab_treenode_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button asc;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_travel_next;
        private System.Windows.Forms.Button btn_travel_prev;
    }
}

