
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.worldmap_Panel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.mine_btn_GotoWorldmap = new System.Windows.Forms.Button();
            this.mine_Panel = new System.Windows.Forms.Panel();
            this.worldmap_btn_GotoMine = new System.Windows.Forms.Button();
            this.worldmap_Panel.SuspendLayout();
            this.mine_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldmap_Panel
            // 
            this.worldmap_Panel.BackColor = System.Drawing.Color.Transparent;
            this.worldmap_Panel.Controls.Add(this.mine_btn_GotoWorldmap);
            this.worldmap_Panel.Location = new System.Drawing.Point(2, 5);
            this.worldmap_Panel.Name = "worldmap_Panel";
            this.worldmap_Panel.Size = new System.Drawing.Size(512, 403);
            this.worldmap_Panel.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(525, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 381);
            this.listBox1.TabIndex = 3;
            this.listBox1.ContextMenuStripChanged += new System.EventHandler(this.cryptolistContextMenuStripChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuy_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 427);
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
            this.button2.Location = new System.Drawing.Point(602, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sell";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSell_click);
            // 
            // mine_btn_GotoWorldmap
            // 
            this.mine_btn_GotoWorldmap.Location = new System.Drawing.Point(0, 0);
            this.mine_btn_GotoWorldmap.Name = "mine_btn_GotoWorldmap";
            this.mine_btn_GotoWorldmap.Size = new System.Drawing.Size(75, 23);
            this.mine_btn_GotoWorldmap.TabIndex = 8;
            this.mine_btn_GotoWorldmap.Text = "Map";
            this.mine_btn_GotoWorldmap.UseVisualStyleBackColor = true;
            // 
            // mine_Panel
            // 
            this.mine_Panel.BackColor = System.Drawing.Color.Transparent;
            this.mine_Panel.Controls.Add(this.worldmap_btn_GotoMine);
            this.mine_Panel.Location = new System.Drawing.Point(2, 5);
            this.mine_Panel.Name = "mine_Panel";
            this.mine_Panel.Size = new System.Drawing.Size(512, 403);
            this.mine_Panel.TabIndex = 9;
            // 
            // worldmap_btn_GotoMine
            // 
            this.worldmap_btn_GotoMine.Location = new System.Drawing.Point(0, 0);
            this.worldmap_btn_GotoMine.Name = "worldmap_btn_GotoMine";
            this.worldmap_btn_GotoMine.Size = new System.Drawing.Size(75, 23);
            this.worldmap_btn_GotoMine.TabIndex = 8;
            this.worldmap_btn_GotoMine.Text = "Mine";
            this.worldmap_btn_GotoMine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mine_Panel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.worldmap_Panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Terminal v0.52";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.worldmap_Panel.ResumeLayout(false);
            this.mine_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel worldmap_Panel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mine_btn_GotoWorldmap;
        private System.Windows.Forms.Panel mine_Panel;
        private System.Windows.Forms.Button worldmap_btn_GotoMine;
    }
}

