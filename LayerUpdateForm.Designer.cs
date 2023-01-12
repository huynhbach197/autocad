
namespace AutoCadProgrammingDemo
{
    partial class LayerUpdateForm
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
            this.enterPathLabel = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListBox();
            this.updateLayerButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterPathLabel
            // 
            this.enterPathLabel.AutoSize = true;
            this.enterPathLabel.Location = new System.Drawing.Point(12, 34);
            this.enterPathLabel.Name = "enterPathLabel";
            this.enterPathLabel.Size = new System.Drawing.Size(57, 13);
            this.enterPathLabel.TabIndex = 0;
            this.enterPathLabel.Text = "Enter Path";
            this.enterPathLabel.UseWaitCursor = true;
            this.enterPathLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(91, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(250, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\new file.dwg\r\n";
            this.txtPath.UseWaitCursor = true;
            this.txtPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(354, 32);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.UseWaitCursor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(15, 69);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(350, 147);
            this.listFile.TabIndex = 3;
            this.listFile.UseWaitCursor = true;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // updateLayerButton
            // 
            this.updateLayerButton.Location = new System.Drawing.Point(319, 250);
            this.updateLayerButton.Name = "updateLayerButton";
            this.updateLayerButton.Size = new System.Drawing.Size(92, 33);
            this.updateLayerButton.TabIndex = 8;
            this.updateLayerButton.Text = "Update";
            this.updateLayerButton.UseVisualStyleBackColor = true;
            this.updateLayerButton.UseWaitCursor = true;
            this.updateLayerButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(24, 250);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(34, 13);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Info...";
            this.infoLabel.UseWaitCursor = true;
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // LayerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 321);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.updateLayerButton);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.enterPathLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LayerUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.LayerUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPathLabel;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button updateLayerButton;
        private System.Windows.Forms.Label infoLabel;
    }
}

