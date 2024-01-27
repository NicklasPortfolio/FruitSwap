namespace FruitSwap
{
    partial class Main
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnTopleft = new System.Windows.Forms.Button();
            this.btnTopright = new System.Windows.Forms.Button();
            this.btnBottomleft = new System.Windows.Forms.Button();
            this.btnBottomright = new System.Windows.Forms.Button();
            this.lblFruit = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTop
            // 
            this.btnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.Location = new System.Drawing.Point(336, 40);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(100, 100);
            this.btnTop.TabIndex = 1;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // btnTopleft
            // 
            this.btnTopleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopleft.Location = new System.Drawing.Point(189, 164);
            this.btnTopleft.Name = "btnTopleft";
            this.btnTopleft.Size = new System.Drawing.Size(100, 100);
            this.btnTopleft.TabIndex = 2;
            this.btnTopleft.UseVisualStyleBackColor = true;
            this.btnTopleft.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // btnTopright
            // 
            this.btnTopright.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopright.Location = new System.Drawing.Point(482, 164);
            this.btnTopright.Name = "btnTopright";
            this.btnTopright.Size = new System.Drawing.Size(100, 100);
            this.btnTopright.TabIndex = 3;
            this.btnTopright.UseVisualStyleBackColor = true;
            this.btnTopright.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // btnBottomleft
            // 
            this.btnBottomleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomleft.Location = new System.Drawing.Point(261, 311);
            this.btnBottomleft.Name = "btnBottomleft";
            this.btnBottomleft.Size = new System.Drawing.Size(100, 100);
            this.btnBottomleft.TabIndex = 4;
            this.btnBottomleft.UseVisualStyleBackColor = true;
            this.btnBottomleft.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // btnBottomright
            // 
            this.btnBottomright.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomright.Location = new System.Drawing.Point(415, 311);
            this.btnBottomright.Name = "btnBottomright";
            this.btnBottomright.Size = new System.Drawing.Size(100, 100);
            this.btnBottomright.TabIndex = 5;
            this.btnBottomright.UseVisualStyleBackColor = true;
            this.btnBottomright.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // lblFruit
            // 
            this.lblFruit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFruit.AutoSize = true;
            this.lblFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruit.Location = new System.Drawing.Point(361, 206);
            this.lblFruit.Name = "lblFruit";
            this.lblFruit.Size = new System.Drawing.Size(0, 24);
            this.lblFruit.TabIndex = 6;
            this.lblFruit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(718, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(24, 25);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "3";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 416);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 25);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score: 0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblFruit);
            this.Controls.Add(this.btnBottomright);
            this.Controls.Add(this.btnBottomleft);
            this.Controls.Add(this.btnTopright);
            this.Controls.Add(this.btnTopleft);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnStart);
            this.Name = "Main";
            this.Text = "FruitSwap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnTopleft;
        private System.Windows.Forms.Button btnTopright;
        private System.Windows.Forms.Button btnBottomleft;
        private System.Windows.Forms.Button btnBottomright;
        private System.Windows.Forms.Label lblFruit;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScore;
    }
}

