namespace UnzipFolder
{
	partial class ExtractForm
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
			this.lblExtFile = new System.Windows.Forms.Label();
			this.lblFile = new System.Windows.Forms.Label();
			this.pbExtFile = new System.Windows.Forms.ProgressBar();
			this.pbFile = new System.Windows.Forms.ProgressBar();
			this.tbLog = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblExtFile
			// 
			this.lblExtFile.AutoSize = true;
			this.lblExtFile.Location = new System.Drawing.Point(12, 9);
			this.lblExtFile.Name = "lblExtFile";
			this.lblExtFile.Size = new System.Drawing.Size(35, 12);
			this.lblExtFile.TabIndex = 0;
			this.lblExtFile.Text = "label1";
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Location = new System.Drawing.Point(12, 50);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(35, 12);
			this.lblFile.TabIndex = 1;
			this.lblFile.Text = "label2";
			// 
			// pbExtFile
			// 
			this.pbExtFile.Location = new System.Drawing.Point(12, 24);
			this.pbExtFile.Name = "pbExtFile";
			this.pbExtFile.Size = new System.Drawing.Size(616, 23);
			this.pbExtFile.TabIndex = 2;
			// 
			// pbFile
			// 
			this.pbFile.Location = new System.Drawing.Point(12, 65);
			this.pbFile.Name = "pbFile";
			this.pbFile.Size = new System.Drawing.Size(616, 23);
			this.pbFile.TabIndex = 3;
			// 
			// tbLog
			// 
			this.tbLog.Location = new System.Drawing.Point(14, 94);
			this.tbLog.Multiline = true;
			this.tbLog.Name = "tbLog";
			this.tbLog.ReadOnly = true;
			this.tbLog.Size = new System.Drawing.Size(614, 109);
			this.tbLog.TabIndex = 4;
			// 
			// ExtractForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 215);
			this.Controls.Add(this.tbLog);
			this.Controls.Add(this.pbFile);
			this.Controls.Add(this.pbExtFile);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.lblExtFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ExtractForm";
			this.Text = "解凍中";
			this.Load += new System.EventHandler(this.ExtractForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblExtFile;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.ProgressBar pbExtFile;
		private System.Windows.Forms.ProgressBar pbFile;
		private System.Windows.Forms.TextBox tbLog;
	}
}