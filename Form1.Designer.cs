namespace AutoUpdateInstalller
{
    partial class Form1
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
            btnCheckForUpdates = new Button();
            SuspendLayout();
            // 
            // btnCheckForUpdates
            // 
            btnCheckForUpdates.Location = new Point(217, 90);
            btnCheckForUpdates.Name = "btnCheckForUpdates";
            btnCheckForUpdates.Size = new Size(217, 29);
            btnCheckForUpdates.TabIndex = 0;
            btnCheckForUpdates.Text = "Check for updates...";
            btnCheckForUpdates.UseVisualStyleBackColor = true;
            btnCheckForUpdates.Click += btnCheckForUpdates_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheckForUpdates);
            Name = "Form1";
            Text = "v.1.0.0.18";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckForUpdates;
    }
}
