
namespace IpGet
{
    partial class MainForm
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
            this.getInfoButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.ipListBox = new System.Windows.Forms.ListBox();
            this.hostnameListBox = new System.Windows.Forms.ListBox();
            this.loadingIcon = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(12, 41);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(188, 32);
            this.getInfoButton.TabIndex = 1;
            this.getInfoButton.Text = "Get host info\r\n";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(12, 12);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(686, 23);
            this.addressBox.TabIndex = 2;
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBox_KeyDown);
            // 
            // ipListBox
            // 
            this.ipListBox.FormattingEnabled = true;
            this.ipListBox.ItemHeight = 15;
            this.ipListBox.Location = new System.Drawing.Point(12, 85);
            this.ipListBox.Name = "ipListBox";
            this.ipListBox.Size = new System.Drawing.Size(234, 229);
            this.ipListBox.TabIndex = 3;
            // 
            // hostnameListBox
            // 
            this.hostnameListBox.FormattingEnabled = true;
            this.hostnameListBox.ItemHeight = 15;
            this.hostnameListBox.Location = new System.Drawing.Point(252, 85);
            this.hostnameListBox.Name = "hostnameListBox";
            this.hostnameListBox.Size = new System.Drawing.Size(446, 229);
            this.hostnameListBox.TabIndex = 4;
            // 
            // loadingIcon
            // 
            this.loadingIcon.Image = global::IpGet.Properties.Resources.Dual_Ring_1_5s_58px;
            this.loadingIcon.Location = new System.Drawing.Point(206, 41);
            this.loadingIcon.Name = "loadingIcon";
            this.loadingIcon.Size = new System.Drawing.Size(40, 32);
            this.loadingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingIcon.TabIndex = 5;
            this.loadingIcon.TabStop = false;
            this.loadingIcon.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(252, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(446, 32);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 326);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.loadingIcon);
            this.Controls.Add(this.hostnameListBox);
            this.Controls.Add(this.ipListBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.getInfoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IPGET";
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.ListBox ipListBox;
        private System.Windows.Forms.ListBox hostnameListBox;
        private System.Windows.Forms.PictureBox loadingIcon;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

