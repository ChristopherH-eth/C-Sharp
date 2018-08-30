namespace DiceRoll
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDice = new System.Windows.Forms.ListBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lbDice1 = new System.Windows.Forms.ListBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(212, 435);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(528, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDice
            // 
            this.lbDice.FormattingEnabled = true;
            this.lbDice.Location = new System.Drawing.Point(12, 96);
            this.lbDice.Name = "lbDice";
            this.lbDice.Size = new System.Drawing.Size(391, 147);
            this.lbDice.TabIndex = 2;
            this.lbDice.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDirections.Location = new System.Drawing.Point(9, 9);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(781, 68);
            this.lblDirections.TabIndex = 3;
            this.lblDirections.Text = resources.GetString("lblDirections.Text");
            // 
            // lbDice1
            // 
            this.lbDice1.FormattingEnabled = true;
            this.lbDice1.Location = new System.Drawing.Point(409, 96);
            this.lbDice1.Name = "lbDice1";
            this.lbDice1.Size = new System.Drawing.Size(391, 147);
            this.lbDice1.TabIndex = 4;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(212, 282);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(391, 147);
            this.lbResults.TabIndex = 5;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResults.Location = new System.Drawing.Point(209, 261);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(335, 18);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Dice totals that don\'t occur in either roll sequence:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 467);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lbDice1);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lbDice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roll";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbDice;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.ListBox lbDice1;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label lblResults;
    }
}

