namespace Yatzee_teerling
{
    partial class TeerlingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teerlingLable = new System.Windows.Forms.Label();
            this.werpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teerlingLable
            // 
            this.teerlingLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teerlingLable.Location = new System.Drawing.Point(13, 0);
            this.teerlingLable.Name = "teerlingLable";
            this.teerlingLable.Size = new System.Drawing.Size(100, 100);
            this.teerlingLable.TabIndex = 0;
            this.teerlingLable.Text = "label1";
            this.teerlingLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teerlingLable.Click += new System.EventHandler(this.teerlingLable_Click);
            // 
            // werpButton
            // 
            this.werpButton.Location = new System.Drawing.Point(13, 112);
            this.werpButton.Name = "werpButton";
            this.werpButton.Size = new System.Drawing.Size(100, 23);
            this.werpButton.TabIndex = 1;
            this.werpButton.Text = "Werp";
            this.werpButton.UseVisualStyleBackColor = true;
            this.werpButton.Click += new System.EventHandler(this.werpButton_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.werpButton);
            this.Controls.Add(this.teerlingLable);
            this.Name = "TeerlingView";
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teerlingLable;
        private System.Windows.Forms.Button werpButton;
    }
}
