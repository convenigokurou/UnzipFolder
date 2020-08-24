namespace UnzipFolder
{
	partial class Main
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbInput = new System.Windows.Forms.TextBox();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.btnInput = new System.Windows.Forms.Button();
			this.btnOutput = new System.Windows.Forms.Button();
			this.btnExec = new System.Windows.Forms.Button();
			this.cbIsEndDelete = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "入力";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "出力";
			// 
			// tbInput
			// 
			this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbInput.Location = new System.Drawing.Point(47, 6);
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new System.Drawing.Size(274, 19);
			this.tbInput.TabIndex = 2;
			// 
			// tbOutput
			// 
			this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutput.Location = new System.Drawing.Point(47, 31);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Size = new System.Drawing.Size(274, 19);
			this.tbOutput.TabIndex = 3;
			// 
			// btnInput
			// 
			this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInput.Location = new System.Drawing.Point(327, 4);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(30, 23);
			this.btnInput.TabIndex = 4;
			this.btnInput.Text = "...";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// btnOutput
			// 
			this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOutput.Location = new System.Drawing.Point(327, 29);
			this.btnOutput.Name = "btnOutput";
			this.btnOutput.Size = new System.Drawing.Size(30, 23);
			this.btnOutput.TabIndex = 5;
			this.btnOutput.Text = "...";
			this.btnOutput.UseVisualStyleBackColor = true;
			this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
			// 
			// btnExec
			// 
			this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExec.Location = new System.Drawing.Point(363, 4);
			this.btnExec.Name = "btnExec";
			this.btnExec.Size = new System.Drawing.Size(83, 68);
			this.btnExec.TabIndex = 6;
			this.btnExec.Text = "実行";
			this.btnExec.UseVisualStyleBackColor = true;
			this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
			// 
			// cbIsEndDelete
			// 
			this.cbIsEndDelete.AutoSize = true;
			this.cbIsEndDelete.Location = new System.Drawing.Point(47, 56);
			this.cbIsEndDelete.Name = "cbIsEndDelete";
			this.cbIsEndDelete.Size = new System.Drawing.Size(84, 16);
			this.cbIsEndDelete.TabIndex = 7;
			this.cbIsEndDelete.Text = "解凍後削除";
			this.cbIsEndDelete.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 79);
			this.Controls.Add(this.cbIsEndDelete);
			this.Controls.Add(this.btnExec);
			this.Controls.Add(this.btnOutput);
			this.Controls.Add(this.btnInput);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.tbInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Main";
			this.Text = "フォルダ解凍";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.Button btnOutput;
		private System.Windows.Forms.Button btnExec;
		private System.Windows.Forms.CheckBox cbIsEndDelete;
	}
}

