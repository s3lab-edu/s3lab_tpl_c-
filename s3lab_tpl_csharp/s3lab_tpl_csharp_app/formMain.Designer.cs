
namespace s3lab_tpl_csharp_app
{
    partial class formMain
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
            this.buttonRound1 = new s3lab_tpl_csharp_customctrl.ButtonRound();
            this.panelCaroBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonRound1
            // 
            this.buttonRound1.BackColor = System.Drawing.Color.Transparent;
            this.buttonRound1.BorderColor = System.Drawing.Color.DimGray;
            this.buttonRound1.ButtonColor = System.Drawing.Color.Red;
            this.buttonRound1.Location = new System.Drawing.Point(790, 2);
            this.buttonRound1.Name = "buttonRound1";
            this.buttonRound1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonRound1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.buttonRound1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonRound1.Size = new System.Drawing.Size(101, 33);
            this.buttonRound1.TabIndex = 5;
            this.buttonRound1.Text = "Hello";
            this.buttonRound1.TextColor = System.Drawing.Color.White;
            this.buttonRound1.UseVisualStyleBackColor = false;
            this.buttonRound1.Click += new System.EventHandler(this.buttonRound1_Click);
            // 
            // panelCaroBoard
            // 
            this.panelCaroBoard.Location = new System.Drawing.Point(1, 2);
            this.panelCaroBoard.Name = "panelCaroBoard";
            this.panelCaroBoard.Size = new System.Drawing.Size(783, 521);
            this.panelCaroBoard.TabIndex = 6;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 524);
            this.Controls.Add(this.panelCaroBoard);
            this.Controls.Add(this.buttonRound1);
            this.Name = "formMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private s3lab_tpl_csharp_customctrl.ButtonRound buttonRound1;
        private System.Windows.Forms.Panel panelCaroBoard;
    }
}

