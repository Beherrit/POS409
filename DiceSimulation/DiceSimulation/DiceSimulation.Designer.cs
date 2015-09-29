namespace DiceSimulation
{
    partial class DiceSimulation
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
            this.rollDice = new System.Windows.Forms.Button();
            this.resultsView = new System.Windows.Forms.ListView();
            this.Dice1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dice2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rollNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(105, 226);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(75, 23);
            this.rollDice.TabIndex = 0;
            this.rollDice.Text = "Roll Dice";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // resultsView
            // 
            this.resultsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dice1,
            this.Dice2,
            this.rollNum});
            this.resultsView.Location = new System.Drawing.Point(12, 12);
            this.resultsView.Name = "resultsView";
            this.resultsView.Size = new System.Drawing.Size(260, 208);
            this.resultsView.TabIndex = 1;
            this.resultsView.UseCompatibleStateImageBehavior = false;
            this.resultsView.View = System.Windows.Forms.View.Details;
            // 
            // Dice1
            // 
            this.Dice1.Text = "Dice 1";
            // 
            // Dice2
            // 
            this.Dice2.Text = "Dice 2";
            // 
            // rollNum
            // 
            this.rollNum.Text = "Roll #";
            // 
            // DiceSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultsView);
            this.Controls.Add(this.rollDice);
            this.Name = "DiceSimulation";
            this.Text = "Dice Simulation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.ListView resultsView;
        private System.Windows.Forms.ColumnHeader Dice1;
        private System.Windows.Forms.ColumnHeader Dice2;
        private System.Windows.Forms.ColumnHeader rollNum;
    }
}

