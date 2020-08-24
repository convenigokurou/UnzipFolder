using System;
using System.Windows.Forms;

namespace UnzipFolder
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btnInput_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "入力フォルダ指定";
			fbd.RootFolder = Environment.SpecialFolder.Desktop;
			fbd.ShowNewFolderButton = true;
			fbd.SelectedPath = tbInput.Text;
			
			//ダイアログを表示する
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				tbInput.Text = fbd.SelectedPath;
			}
		}

		private void btnOutput_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "出力フォルダ指定";
			fbd.RootFolder = Environment.SpecialFolder.Desktop;
			fbd.ShowNewFolderButton = true;
			fbd.SelectedPath = tbOutput.Text;
			
			//ダイアログを表示する
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				tbOutput.Text = fbd.SelectedPath;
			}
		}

		private void btnExec_Click(object sender, EventArgs e)
		{
			ExtractForm ef = new ExtractForm();
			ef.InputPath = tbInput.Text;
			ef.OutputPath = tbOutput.Text;
			ef.IsEndDelete = cbIsEndDelete.Checked;
			ef.ShowDialog();

		}
	}
}
