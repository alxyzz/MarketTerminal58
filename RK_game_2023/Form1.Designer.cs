
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
            this.costLabel4 = new System.Windows.Forms.Label();
            this.costLabel3 = new System.Windows.Forms.Label();
            this.costLabel2 = new System.Windows.Forms.Label();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.rtf_AboutCurrentTreeNode = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_playerGraphLocation = new System.Windows.Forms.Label();
            this.label_YouAre = new System.Windows.Forms.Label();
            this.btn_travel4 = new System.Windows.Forms.Button();
            this.btn_travel3 = new System.Windows.Forms.Button();
            this.btn_travel2 = new System.Windows.Forms.Button();
            this.btn_travel1 = new System.Windows.Forms.Button();
            this.rtf_Graph = new System.Windows.Forms.RichTextBox();
            this.btn_Map = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.btn_Mine = new System.Windows.Forms.Button();
            this.btn_Shop = new System.Windows.Forms.Button();
            this.minePanel = new System.Windows.Forms.Panel();
            this.btn_TreeData = new System.Windows.Forms.Button();
            this.rtfbox_TreeData = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.luckLabelText = new System.Windows.Forms.Label();
            this.luckLabel = new System.Windows.Forms.Label();
            this.img_Rightnode = new System.Windows.Forms.PictureBox();
            this.img_Leftnode = new System.Windows.Forms.PictureBox();
            this.img_Currnode = new System.Windows.Forms.PictureBox();
            this.btn_GoLeftSubtree = new System.Windows.Forms.Button();
            this.lab_CryptoType = new System.Windows.Forms.Label();
            this.lab_AvgYield = new System.Windows.Forms.Label();
            this.btn_AdvanceDrill = new System.Windows.Forms.Button();
            this.btn_GoRightSubtree = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cryptoPanel = new System.Windows.Forms.Panel();
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
            this.label6 = new System.Windows.Forms.Label();
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
            this.mapPanel.Controls.Add(this.costLabel4);
            this.mapPanel.Controls.Add(this.costLabel3);
            this.mapPanel.Controls.Add(this.costLabel2);
            this.mapPanel.Controls.Add(this.costLabel1);
            this.mapPanel.Controls.Add(this.rtf_AboutCurrentTreeNode);
            this.mapPanel.Controls.Add(this.label2);
            this.mapPanel.Controls.Add(this.label_playerGraphLocation);
            this.mapPanel.Controls.Add(this.label_YouAre);
            this.mapPanel.Controls.Add(this.btn_travel4);
            this.mapPanel.Controls.Add(this.btn_travel3);
            this.mapPanel.Controls.Add(this.btn_travel2);
            this.mapPanel.Controls.Add(this.btn_travel1);
            this.mapPanel.Controls.Add(this.rtf_Graph);
            this.mapPanel.Location = new System.Drawing.Point(2, 56);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(512, 387);
            this.mapPanel.TabIndex = 2;
            // 
            // costLabel4
            // 
            this.costLabel4.AutoSize = true;
            this.costLabel4.Location = new System.Drawing.Point(368, 350);
            this.costLabel4.Name = "costLabel4";
            this.costLabel4.Size = new System.Drawing.Size(31, 13);
            this.costLabel4.TabIndex = 12;
            this.costLabel4.Text = "1000";
            // 
            // costLabel3
            // 
            this.costLabel3.AutoSize = true;
            this.costLabel3.Location = new System.Drawing.Point(285, 350);
            this.costLabel3.Name = "costLabel3";
            this.costLabel3.Size = new System.Drawing.Size(31, 13);
            this.costLabel3.TabIndex = 11;
            this.costLabel3.Text = "1000";
            // 
            // costLabel2
            // 
            this.costLabel2.AutoSize = true;
            this.costLabel2.Location = new System.Drawing.Point(205, 350);
            this.costLabel2.Name = "costLabel2";
            this.costLabel2.Size = new System.Drawing.Size(31, 13);
            this.costLabel2.TabIndex = 10;
            this.costLabel2.Text = "1000";
            // 
            // costLabel1
            // 
            this.costLabel1.AutoSize = true;
            this.costLabel1.Location = new System.Drawing.Point(124, 350);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(31, 13);
            this.costLabel1.TabIndex = 9;
            this.costLabel1.Text = "1000";
            // 
            // rtf_AboutCurrentTreeNode
            // 
            this.rtf_AboutCurrentTreeNode.Location = new System.Drawing.Point(378, 4);
            this.rtf_AboutCurrentTreeNode.Name = "rtf_AboutCurrentTreeNode";
            this.rtf_AboutCurrentTreeNode.ReadOnly = true;
            this.rtf_AboutCurrentTreeNode.Size = new System.Drawing.Size(122, 96);
            this.rtf_AboutCurrentTreeNode.TabIndex = 8;
            this.rtf_AboutCurrentTreeNode.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 313);
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
            // btn_travel4
            // 
            this.btn_travel4.Location = new System.Drawing.Point(347, 361);
            this.btn_travel4.Name = "btn_travel4";
            this.btn_travel4.Size = new System.Drawing.Size(75, 23);
            this.btn_travel4.TabIndex = 4;
            this.btn_travel4.Text = "button5";
            this.btn_travel4.UseVisualStyleBackColor = true;
            this.btn_travel4.Click += new System.EventHandler(this.OnClickTravelFour);
            // 
            // btn_travel3
            // 
            this.btn_travel3.Location = new System.Drawing.Point(266, 361);
            this.btn_travel3.Name = "btn_travel3";
            this.btn_travel3.Size = new System.Drawing.Size(75, 23);
            this.btn_travel3.TabIndex = 3;
            this.btn_travel3.Text = "button4";
            this.btn_travel3.UseVisualStyleBackColor = true;
            this.btn_travel3.Click += new System.EventHandler(this.OnClickTravelThree);
            // 
            // btn_travel2
            // 
            this.btn_travel2.Location = new System.Drawing.Point(184, 361);
            this.btn_travel2.Name = "btn_travel2";
            this.btn_travel2.Size = new System.Drawing.Size(75, 23);
            this.btn_travel2.TabIndex = 2;
            this.btn_travel2.Text = "button3";
            this.btn_travel2.UseVisualStyleBackColor = true;
            this.btn_travel2.Click += new System.EventHandler(this.OnClickTravelTwo);
            // 
            // btn_travel1
            // 
            this.btn_travel1.Location = new System.Drawing.Point(103, 361);
            this.btn_travel1.Name = "btn_travel1";
            this.btn_travel1.Size = new System.Drawing.Size(75, 23);
            this.btn_travel1.TabIndex = 1;
            this.btn_travel1.Text = "button2";
            this.btn_travel1.UseVisualStyleBackColor = true;
            this.btn_travel1.Click += new System.EventHandler(this.OnClickTravelOne);
            // 
            // rtf_Graph
            // 
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
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(525, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 355);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.ContextMenuStripChanged += new System.EventHandler(this.cryptolistContextMenuStripChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(9, 364);
            this.inputBox.MaxLength = 100;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(481, 20);
            this.inputBox.TabIndex = 5;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputPressEnter);
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
            this.minePanel.Controls.Add(this.btn_TreeData);
            this.minePanel.Controls.Add(this.rtfbox_TreeData);
            this.minePanel.Controls.Add(this.label1);
            this.minePanel.Controls.Add(this.luckLabelText);
            this.minePanel.Controls.Add(this.luckLabel);
            this.minePanel.Controls.Add(this.img_Rightnode);
            this.minePanel.Controls.Add(this.img_Leftnode);
            this.minePanel.Controls.Add(this.img_Currnode);
            this.minePanel.Controls.Add(this.btn_GoLeftSubtree);
            this.minePanel.Controls.Add(this.lab_CryptoType);
            this.minePanel.Controls.Add(this.lab_AvgYield);
            this.minePanel.Controls.Add(this.btn_AdvanceDrill);
            this.minePanel.Controls.Add(this.btn_GoRightSubtree);
            this.minePanel.Controls.Add(this.progressBar1);
            this.minePanel.Location = new System.Drawing.Point(742, 41);
            this.minePanel.Name = "minePanel";
            this.minePanel.Size = new System.Drawing.Size(512, 387);
            this.minePanel.TabIndex = 3;
            // 
            // btn_TreeData
            // 
            this.btn_TreeData.Location = new System.Drawing.Point(17, 6);
            this.btn_TreeData.Name = "btn_TreeData";
            this.btn_TreeData.Size = new System.Drawing.Size(99, 23);
            this.btn_TreeData.TabIndex = 13;
            this.btn_TreeData.Text = "Get Tree Data";
            this.btn_TreeData.UseVisualStyleBackColor = true;
            this.btn_TreeData.Click += new System.EventHandler(this.btn_TreeData_Click);
            // 
            // rtfbox_TreeData
            // 
            this.rtfbox_TreeData.Location = new System.Drawing.Point(122, 6);
            this.rtfbox_TreeData.Name = "rtfbox_TreeData";
            this.rtfbox_TreeData.Size = new System.Drawing.Size(254, 96);
            this.rtfbox_TreeData.TabIndex = 12;
            this.rtfbox_TreeData.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // luckLabelText
            // 
            this.luckLabelText.AutoSize = true;
            this.luckLabelText.Location = new System.Drawing.Point(54, 365);
            this.luckLabelText.Name = "luckLabelText";
            this.luckLabelText.Size = new System.Drawing.Size(35, 13);
            this.luckLabelText.TabIndex = 10;
            this.luckLabelText.Text = "label1";
            // 
            // luckLabel
            // 
            this.luckLabel.AutoSize = true;
            this.luckLabel.Location = new System.Drawing.Point(19, 345);
            this.luckLabel.Name = "luckLabel";
            this.luckLabel.Size = new System.Drawing.Size(106, 13);
            this.luckLabel.TabIndex = 9;
            this.luckLabel.Text = "Wow! You got lucky!";
            // 
            // img_Rightnode
            // 
            this.img_Rightnode.Location = new System.Drawing.Point(284, 142);
            this.img_Rightnode.Name = "img_Rightnode";
            this.img_Rightnode.Size = new System.Drawing.Size(70, 71);
            this.img_Rightnode.TabIndex = 8;
            this.img_Rightnode.TabStop = false;
            // 
            // img_Leftnode
            // 
            this.img_Leftnode.Location = new System.Drawing.Point(152, 142);
            this.img_Leftnode.Name = "img_Leftnode";
            this.img_Leftnode.Size = new System.Drawing.Size(70, 71);
            this.img_Leftnode.TabIndex = 7;
            this.img_Leftnode.TabStop = false;
            // 
            // img_Currnode
            // 
            this.img_Currnode.Location = new System.Drawing.Point(219, 237);
            this.img_Currnode.Name = "img_Currnode";
            this.img_Currnode.Size = new System.Drawing.Size(70, 71);
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
            // 
            // lab_CryptoType
            // 
            this.lab_CryptoType.AutoSize = true;
            this.lab_CryptoType.Location = new System.Drawing.Point(405, 328);
            this.lab_CryptoType.Name = "lab_CryptoType";
            this.lab_CryptoType.Size = new System.Drawing.Size(35, 13);
            this.lab_CryptoType.TabIndex = 4;
            this.lab_CryptoType.Text = "label1";
            this.lab_CryptoType.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_AvgYield
            // 
            this.lab_AvgYield.AutoSize = true;
            this.lab_AvgYield.Location = new System.Drawing.Point(405, 308);
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
            this.btn_AdvanceDrill.Text = "Engage Drill";
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
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(183, 364);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Maximum = 4;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(145, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // cryptoPanel
            // 
            this.cryptoPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cryptoPanel.Controls.Add(this.list_crypto_coins);
            this.cryptoPanel.Controls.Add(this.rtf_crypto_description);
            this.cryptoPanel.Controls.Add(this.inputBox);
            this.cryptoPanel.Location = new System.Drawing.Point(1303, 441);
            this.cryptoPanel.Name = "cryptoPanel";
            this.cryptoPanel.Size = new System.Drawing.Size(512, 387);
            this.cryptoPanel.TabIndex = 4;
            // 
            // list_crypto_coins
            // 
            this.list_crypto_coins.FormattingEnabled = true;
            this.list_crypto_coins.Location = new System.Drawing.Point(147, 12);
            this.list_crypto_coins.Name = "list_crypto_coins";
            this.list_crypto_coins.Size = new System.Drawing.Size(211, 264);
            this.list_crypto_coins.TabIndex = 16;
            this.list_crypto_coins.SelectedIndexChanged += new System.EventHandler(this.List_crypto_coins_SelectedIndexChanged);
            // 
            // rtf_crypto_description
            // 
            this.rtf_crypto_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtf_crypto_description.Location = new System.Drawing.Point(83, 308);
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
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, -1);
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
            this.label_MUD.Location = new System.Drawing.Point(677, 407);
            this.label_MUD.Name = "label_MUD";
            this.label_MUD.Size = new System.Drawing.Size(35, 13);
            this.label_MUD.TabIndex = 16;
            this.label_MUD.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mongolian Uranium Dollars:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Change";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 34);
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
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_AdvanceDrill;
        private System.Windows.Forms.Button btn_GoRightSubtree;
        private System.Windows.Forms.Label lab_AvgYield;
        private System.Windows.Forms.Label lab_CryptoType;
        private System.Windows.Forms.Button btn_GoLeftSubtree;
        private System.Windows.Forms.PictureBox img_Currnode;
        private System.Windows.Forms.PictureBox img_Rightnode;
        private System.Windows.Forms.PictureBox img_Leftnode;
        private System.Windows.Forms.Label luckLabel;
        private System.Windows.Forms.Label luckLabelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtfbox_TreeData;
        private System.Windows.Forms.Button btn_TreeData;
        private System.Windows.Forms.RichTextBox rtf_Graph;
        private System.Windows.Forms.Button btn_travel4;
        private System.Windows.Forms.Button btn_travel3;
        private System.Windows.Forms.Button btn_travel2;
        private System.Windows.Forms.Button btn_travel1;
        private System.Windows.Forms.Label label_YouAre;
        private System.Windows.Forms.Label label_playerGraphLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtf_AboutCurrentTreeNode;
        private System.Windows.Forms.RichTextBox rtf_crypto_description;
        private System.Windows.Forms.ListBox list_crypto_coins;
        private System.Windows.Forms.Label costLabel1;
        private System.Windows.Forms.Label costLabel2;
        private System.Windows.Forms.Label costLabel3;
        private System.Windows.Forms.Label costLabel4;
        private System.Windows.Forms.Label label_MUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

