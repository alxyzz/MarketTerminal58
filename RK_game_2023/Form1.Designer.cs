
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.btn_Map = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Mine = new System.Windows.Forms.Button();
            this.btn_Shop = new System.Windows.Forms.Button();
            this.minePanel = new System.Windows.Forms.Panel();
            this.cryptoPanel = new System.Windows.Forms.Panel();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.cryptoPanel.SuspendLayout();
            this.helpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mapPanel.Location = new System.Drawing.Point(2, 56);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(512, 387);
            this.mapPanel.TabIndex = 2;
            // 
            // btn_Map
            // 
            this.btn_Map.Location = new System.Drawing.Point(-1, -1);
            this.btn_Map.Name = "btn_Map";
            this.btn_Map.Size = new System.Drawing.Size(75, 23);
            this.btn_Map.TabIndex = 8;
            this.btn_Map.Text = "Map";
            this.btn_Map.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(525, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 381);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.ContextMenuStripChanged += new System.EventHandler(this.cryptolistContextMenuStripChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuy_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 471);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputPressEnter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(520, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(216, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sell";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSell_click);
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
            // 
            // minePanel
            // 
            this.minePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.minePanel.Location = new System.Drawing.Point(742, 41);
            this.minePanel.Name = "minePanel";
            this.minePanel.Size = new System.Drawing.Size(512, 387);
            this.minePanel.TabIndex = 3;
            // 
            // cryptoPanel
            // 
            this.cryptoPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cryptoPanel.Controls.Add(this.button2);
            this.cryptoPanel.Controls.Add(this.button1);
            this.cryptoPanel.Location = new System.Drawing.Point(1056, 441);
            this.cryptoPanel.Name = "cryptoPanel";
            this.cryptoPanel.Size = new System.Drawing.Size(512, 387);
            this.cryptoPanel.TabIndex = 4;
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 381);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(2, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 13);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "label1";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoEllipsis = true;
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(2, 446);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(35, 13);
            this.helpLabel.TabIndex = 12;
            this.helpLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2071, 887);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.cryptoPanel);
            this.Controls.Add(this.minePanel);
            this.Controls.Add(this.btn_Shop);
            this.Controls.Add(this.btn_Map);
            this.Controls.Add(this.btn_Mine);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mapPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Terminal v0.52";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cryptoPanel.ResumeLayout(false);
            this.helpPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
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
    }
}

