namespace TileShift
{
    partial class TileShift
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlLoadScreen = new Panel();
            lblLS = new Label();
            tmrLoad = new System.Windows.Forms.Timer(components);
            pnlMenu = new Panel();
            label3 = new Label();
            label1 = new Label();
            pnlModel = new Panel();
            MBlock8 = new Panel();
            MBlock9 = new Panel();
            MBlock7 = new Panel();
            MBlock6 = new Panel();
            MBlock5 = new Panel();
            MBlock4 = new Panel();
            MBlock3 = new Panel();
            MBlock2 = new Panel();
            MBlock1 = new Panel();
            btnStart = new Button();
            btnRestart = new Button();
            btnClose = new Button();
            pnlPatternContainer = new Panel();
            label2 = new Label();
            pnlLabel = new Panel();
            lblLabel = new Label();
            pnlPattern = new Panel();
            Block9 = new Panel();
            btnClick = new Button();
            Block8 = new Panel();
            Block7 = new Panel();
            Block6 = new Panel();
            Block5 = new Panel();
            Block4 = new Panel();
            Block3 = new Panel();
            Block2 = new Panel();
            Block1 = new Panel();
            pnlLoadScreen.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlModel.SuspendLayout();
            pnlPatternContainer.SuspendLayout();
            pnlLabel.SuspendLayout();
            pnlPattern.SuspendLayout();
            Block9.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoadScreen
            // 
            pnlLoadScreen.BackColor = Color.Black;
            pnlLoadScreen.Controls.Add(lblLS);
            pnlLoadScreen.Location = new Point(0, 0);
            pnlLoadScreen.Name = "pnlLoadScreen";
            pnlLoadScreen.Size = new Size(800, 600);
            pnlLoadScreen.TabIndex = 0;
            // 
            // lblLS
            // 
            lblLS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLS.AutoSize = true;
            lblLS.Font = new Font("Ravie", 60F);
            lblLS.ForeColor = Color.White;
            lblLS.Location = new Point(3, 239);
            lblLS.Name = "lblLS";
            lblLS.Size = new Size(774, 107);
            lblLS.TabIndex = 0;
            lblLS.Text = "Shiffy Games";
            // 
            // tmrLoad
            // 
            tmrLoad.Interval = 1000;
            tmrLoad.Tick += tmrLoad_Tick;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Moccasin;
            pnlMenu.Controls.Add(label3);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(pnlModel);
            pnlMenu.Controls.Add(btnStart);
            pnlMenu.Controls.Add(btnRestart);
            pnlMenu.Controls.Add(btnClose);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 561);
            pnlMenu.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(61, 374);
            label3.Name = "label3";
            label3.Size = new Size(30, 61);
            label3.TabIndex = 5;
            label3.Text = "↑";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(42, 435);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 4;
            label1.Text = "Model";
            // 
            // pnlModel
            // 
            pnlModel.BorderStyle = BorderStyle.FixedSingle;
            pnlModel.Controls.Add(MBlock8);
            pnlModel.Controls.Add(MBlock9);
            pnlModel.Controls.Add(MBlock7);
            pnlModel.Controls.Add(MBlock6);
            pnlModel.Controls.Add(MBlock5);
            pnlModel.Controls.Add(MBlock4);
            pnlModel.Controls.Add(MBlock3);
            pnlModel.Controls.Add(MBlock2);
            pnlModel.Controls.Add(MBlock1);
            pnlModel.Location = new Point(30, 280);
            pnlModel.Name = "pnlModel";
            pnlModel.Size = new Size(90, 90);
            pnlModel.TabIndex = 3;
            // 
            // MBlock8
            // 
            MBlock8.BorderStyle = BorderStyle.FixedSingle;
            MBlock8.Location = new Point(30, 60);
            MBlock8.Name = "MBlock8";
            MBlock8.Size = new Size(30, 30);
            MBlock8.TabIndex = 9;
            // 
            // MBlock9
            // 
            MBlock9.BorderStyle = BorderStyle.FixedSingle;
            MBlock9.Location = new Point(60, 60);
            MBlock9.Name = "MBlock9";
            MBlock9.Size = new Size(30, 30);
            MBlock9.TabIndex = 10;
            // 
            // MBlock7
            // 
            MBlock7.BorderStyle = BorderStyle.FixedSingle;
            MBlock7.Location = new Point(0, 60);
            MBlock7.Name = "MBlock7";
            MBlock7.Size = new Size(30, 30);
            MBlock7.TabIndex = 8;
            // 
            // MBlock6
            // 
            MBlock6.BorderStyle = BorderStyle.FixedSingle;
            MBlock6.Location = new Point(60, 30);
            MBlock6.Name = "MBlock6";
            MBlock6.Size = new Size(30, 30);
            MBlock6.TabIndex = 5;
            // 
            // MBlock5
            // 
            MBlock5.BorderStyle = BorderStyle.FixedSingle;
            MBlock5.Location = new Point(30, 30);
            MBlock5.Name = "MBlock5";
            MBlock5.Size = new Size(30, 30);
            MBlock5.TabIndex = 4;
            // 
            // MBlock4
            // 
            MBlock4.BorderStyle = BorderStyle.FixedSingle;
            MBlock4.Location = new Point(0, 30);
            MBlock4.Name = "MBlock4";
            MBlock4.Size = new Size(30, 30);
            MBlock4.TabIndex = 3;
            // 
            // MBlock3
            // 
            MBlock3.BorderStyle = BorderStyle.FixedSingle;
            MBlock3.Location = new Point(60, 0);
            MBlock3.Name = "MBlock3";
            MBlock3.Size = new Size(30, 30);
            MBlock3.TabIndex = 2;
            // 
            // MBlock2
            // 
            MBlock2.BorderStyle = BorderStyle.FixedSingle;
            MBlock2.Location = new Point(30, 0);
            MBlock2.Name = "MBlock2";
            MBlock2.Size = new Size(30, 30);
            MBlock2.TabIndex = 1;
            // 
            // MBlock1
            // 
            MBlock1.BorderStyle = BorderStyle.FixedSingle;
            MBlock1.Location = new Point(0, 0);
            MBlock1.Name = "MBlock1";
            MBlock1.Size = new Size(30, 30);
            MBlock1.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(30, 27);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(103, 46);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(30, 116);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(103, 46);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart pattern";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(30, 190);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 46);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlPatternContainer
            // 
            pnlPatternContainer.BackColor = Color.DarkGoldenrod;
            pnlPatternContainer.Controls.Add(label2);
            pnlPatternContainer.Controls.Add(pnlLabel);
            pnlPatternContainer.Controls.Add(pnlPattern);
            pnlPatternContainer.Dock = DockStyle.Fill;
            pnlPatternContainer.Location = new Point(200, 0);
            pnlPatternContainer.Name = "pnlPatternContainer";
            pnlPatternContainer.Size = new Size(584, 561);
            pnlPatternContainer.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(22, 476);
            label2.Name = "label2";
            label2.Size = new Size(387, 56);
            label2.TabIndex = 5;
            label2.Text = "Match the pattern according to the model.\r\nClick the black block once you've matched!";
            // 
            // pnlLabel
            // 
            pnlLabel.BackColor = Color.Black;
            pnlLabel.Controls.Add(lblLabel);
            pnlLabel.Location = new Point(477, 13);
            pnlLabel.Name = "pnlLabel";
            pnlLabel.Size = new Size(94, 41);
            pnlLabel.TabIndex = 1;
            // 
            // lblLabel
            // 
            lblLabel.AutoSize = true;
            lblLabel.Font = new Font("Segoe UI", 10F);
            lblLabel.ForeColor = Color.White;
            lblLabel.Location = new Point(14, 10);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(61, 19);
            lblLabel.TabIndex = 0;
            lblLabel.Text = "Pattern: ";
            // 
            // pnlPattern
            // 
            pnlPattern.BorderStyle = BorderStyle.FixedSingle;
            pnlPattern.Controls.Add(Block9);
            pnlPattern.Controls.Add(Block8);
            pnlPattern.Controls.Add(Block7);
            pnlPattern.Controls.Add(Block6);
            pnlPattern.Controls.Add(Block5);
            pnlPattern.Controls.Add(Block4);
            pnlPattern.Controls.Add(Block3);
            pnlPattern.Controls.Add(Block2);
            pnlPattern.Controls.Add(Block1);
            pnlPattern.Location = new Point(21, 12);
            pnlPattern.Name = "pnlPattern";
            pnlPattern.Size = new Size(450, 450);
            pnlPattern.TabIndex = 0;
            // 
            // Block9
            // 
            Block9.BorderStyle = BorderStyle.FixedSingle;
            Block9.Controls.Add(btnClick);
            Block9.Location = new Point(300, 300);
            Block9.Name = "Block9";
            Block9.Size = new Size(150, 150);
            Block9.TabIndex = 8;
            Block9.Click += Block9_Click;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(38, 66);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(75, 23);
            btnClick.TabIndex = 0;
            btnClick.Text = "Click me";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Block8
            // 
            Block8.BorderStyle = BorderStyle.FixedSingle;
            Block8.Location = new Point(150, 300);
            Block8.Name = "Block8";
            Block8.Size = new Size(150, 150);
            Block8.TabIndex = 7;
            Block8.Click += Block8_Click;
            // 
            // Block7
            // 
            Block7.BorderStyle = BorderStyle.FixedSingle;
            Block7.Location = new Point(0, 300);
            Block7.Name = "Block7";
            Block7.Size = new Size(150, 150);
            Block7.TabIndex = 6;
            Block7.Click += Block7_Click;
            // 
            // Block6
            // 
            Block6.BorderStyle = BorderStyle.FixedSingle;
            Block6.Location = new Point(300, 150);
            Block6.Name = "Block6";
            Block6.Size = new Size(150, 150);
            Block6.TabIndex = 5;
            Block6.Click += Block6_Click;
            // 
            // Block5
            // 
            Block5.BorderStyle = BorderStyle.FixedSingle;
            Block5.Location = new Point(150, 150);
            Block5.Name = "Block5";
            Block5.Size = new Size(150, 150);
            Block5.TabIndex = 4;
            Block5.Click += Block5_Click;
            // 
            // Block4
            // 
            Block4.BorderStyle = BorderStyle.FixedSingle;
            Block4.Location = new Point(0, 150);
            Block4.Name = "Block4";
            Block4.Size = new Size(150, 150);
            Block4.TabIndex = 3;
            Block4.Click += Block4_Click;
            // 
            // Block3
            // 
            Block3.BorderStyle = BorderStyle.FixedSingle;
            Block3.Location = new Point(300, 0);
            Block3.Name = "Block3";
            Block3.Size = new Size(150, 150);
            Block3.TabIndex = 2;
            Block3.Click += Block3_Click;
            // 
            // Block2
            // 
            Block2.BorderStyle = BorderStyle.FixedSingle;
            Block2.Location = new Point(150, 0);
            Block2.Name = "Block2";
            Block2.Size = new Size(150, 150);
            Block2.TabIndex = 1;
            Block2.Click += Block2_Click;
            // 
            // Block1
            // 
            Block1.BorderStyle = BorderStyle.FixedSingle;
            Block1.Location = new Point(0, 0);
            Block1.Name = "Block1";
            Block1.Size = new Size(150, 150);
            Block1.TabIndex = 0;
            Block1.Click += Block1_Click;
            // 
            // TileShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pnlLoadScreen);
            Controls.Add(pnlPatternContainer);
            Controls.Add(pnlMenu);
            MaximumSize = new Size(800, 600);
            Name = "TileShift";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shiffy Games - Tile Shift";
            pnlLoadScreen.ResumeLayout(false);
            pnlLoadScreen.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlModel.ResumeLayout(false);
            pnlPatternContainer.ResumeLayout(false);
            pnlPatternContainer.PerformLayout();
            pnlLabel.ResumeLayout(false);
            pnlLabel.PerformLayout();
            pnlPattern.ResumeLayout(false);
            Block9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoadScreen;
        private System.Windows.Forms.Timer tmrLoad;
        private Panel pnlMenu;
        private Panel pnlPatternContainer;
        private Button btnStart;
        private Button btnRestart;
        private Button btnClose;
        private Panel pnlPattern;
        private Panel Block3;
        private Panel Block2;
        private Panel Block1;
        private Panel Block9;
        private Panel Block8;
        private Panel Block7;
        private Panel Block6;
        private Panel Block5;
        private Panel Block4;
        private Panel pnlModel;
        private Panel MBlock6;
        private Panel MBlock5;
        private Panel MBlock4;
        private Panel MBlock3;
        private Panel MBlock2;
        private Panel MBlock1;
        private Panel MBlock8;
        private Panel MBlock9;
        private Panel MBlock7;
        private Panel pnlLabel;
        private Label lblLabel;
        private Button btnClick;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblLS;
    }
}
