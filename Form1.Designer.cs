namespace FunFX_Demo
{
    partial class BounceForm
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
            Bouncer = new PictureBox();
            Ticker = new System.Windows.Forms.Timer(components);
            PosTracker = new Label();
            ((System.ComponentModel.ISupportInitialize)Bouncer).BeginInit();
            SuspendLayout();
            // 
            // Bouncer
            // 
            Bouncer.BackColor = SystemColors.ActiveCaption;
            Bouncer.Location = new Point(738, 438);
            Bouncer.Name = "Bouncer";
            Bouncer.Size = new Size(50, 50);
            Bouncer.TabIndex = 0;
            Bouncer.TabStop = false;
            // 
            // Ticker
            // 
            Ticker.Enabled = true;
            Ticker.Interval = 1;
            Ticker.Tick += Ticker_Tick;
            // 
            // PosTracker
            // 
            PosTracker.AutoSize = true;
            PosTracker.Location = new Point(360, 78);
            PosTracker.Name = "PosTracker";
            PosTracker.Size = new Size(0, 15);
            PosTracker.TabIndex = 1;
            // 
            // BounceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(PosTracker);
            Controls.Add(Bouncer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BounceForm";
            Text = "BounceBox";
            ((System.ComponentModel.ISupportInitialize)Bouncer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Bouncer;
        private System.Windows.Forms.Timer Ticker;
        private Label PosTracker;
    }
}