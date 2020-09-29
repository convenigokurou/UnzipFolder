using System;
using System.IO;
using System.Windows.Forms;

namespace UnzipFolder
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			tbInput.AllowDrop = true;
			tbInput.DragEnter += TbInput_DragEnter;
			tbInput.DragDrop += TbInput_DragDrop;

			tbOutput.AllowDrop = true;
			tbOutput.DragEnter += TbInput_DragEnter; //流用する
			tbOutput.DragDrop += TbOutput_DragDrop;

		}


		private void TbInput_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void TbInput_DragDrop(object sender, DragEventArgs e)
		{
			string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if(fileName.Length > 0)
			{
				if( File.GetAttributes(fileName[0]).HasFlag(FileAttributes.Directory) )
				{
					tbInput.Text = fileName[0];
				}
			}
		}

		private void TbOutput_DragDrop(object sender, DragEventArgs e)
		{
			string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if (fileName.Length > 0)
			{
				if (File.GetAttributes(fileName[0]).HasFlag(FileAttributes.Directory))
				{
					tbOutput.Text = fileName[0];
				}
			}
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
