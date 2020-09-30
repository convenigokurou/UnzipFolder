using SharpCompress.Archives;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnzipFolder
{
	public partial class ExtractForm : Form
	{
		public string InputPath { get; set; }
		public string OutputPath { get; set; }
		public bool IsEndDelete { get; set; }

		private Task t;
		private bool endFlag;

		private void UpdateExtFile( string file, int index, int all )
		{
			lblExtFile.Text = $"({index+1}/{all}){file}";
			
			pbExtFile.Minimum = 0;
			pbExtFile.Maximum = all;
			pbExtFile.Value = index+1;
		}

		private void UpdateFile( string file, int index, int all )
		{
			lblFile.Text = $"({index+1}/{all}){file}";
			
			pbFile.Minimum = 0;
			pbFile.Maximum = all;
			pbFile.Value = index+1;
		}
		private void SendLog( string log )
		{
			tbLog.AppendText(log);
		}

		public ExtractForm()
		{
			InitializeComponent();

			FormClosing += ExtractForm_FormClosing;
		}

		private void ExtractForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//稼働中であれば止めるようにする
			if (endFlag == false)
			{
				e.Cancel = true;
				endFlag = true;
			}

			//スレッド終わったか確認
			if( t.IsCompleted == false )
			{
				e.Cancel = true;
			}
		}

		private void ExtractForm_Load(object sender, EventArgs e)
		{
			endFlag = false;
			t = Task.Run( () => 
			{
				try
				{
					List<string> fileList = new List<string>();
					fileList.AddRange(Directory.EnumerateFiles(InputPath, "*.zip", SearchOption.AllDirectories).ToList());
					fileList.AddRange(Directory.EnumerateFiles(InputPath, "*.rar", SearchOption.AllDirectories).ToList());

					int i = 0;
					foreach (string f in fileList)
					{
						Invoke(new Action<string, int, int>(UpdateExtFile), f, i, fileList.Count);

						try
						{
							using (var zip = ArchiveFactory.Open(f))
							{
								var options = new ExtractionOptions();
								options.ExtractFullPath = true;
								options.Overwrite = true;

								int j = 0;
								foreach (var ent in zip.Entries)
								{
									Invoke(new Action<string, int, int>(UpdateFile), ent.Key, j, zip.Entries.Count());

									if (ent.IsDirectory)
									{
										if (!Directory.Exists(OutputPath + Path.DirectorySeparatorChar + ent.Key))
										{
											ent.WriteToDirectory(OutputPath, options);
										}

										try
										{
											//ディレクトリがあるときに日付を変更しようとすると例外が出る とりあえず握りつぶす
											Directory.SetLastWriteTime(Path.GetFullPath(OutputPath + Path.DirectorySeparatorChar + ent.Key), ent.LastModifiedTime.Value);
										}
										catch
										{
											//日付更新
											Invoke(new Action<string>(SendLog), $"注意:{f}\r\n 内容:日付更新失敗(ファイル)\r\n");
										}
									}
									else
									{
										//出力
										ent.WriteToDirectory(OutputPath, options);

										try
										{
											//ディレクトリがあるときに日付を変更しようとすると例外が出る とりあえず握りつぶす
											Directory.SetLastWriteTime(Path.GetFullPath(OutputPath + Path.DirectorySeparatorChar + ent.Key), ent.LastModifiedTime.Value);
										}
										catch
										{
											//日付更新
											Invoke(new Action<string>(SendLog), $"注意:{f}\r\n 内容:日付更新失敗(フォルダ)\r\n");
										}
									}

									j++;

									if (endFlag)
									{
										break;
									}
								}
							}

							if (IsEndDelete)
							{
								if (!endFlag)
								{
									File.Delete(f);
								}
							}

						}
						catch (Exception ex)
						{
							Invoke(new Action<string>(SendLog), $"エラー:{f}\r\n 例外:{ex.Message.Replace("\n", "\r\n")}\r\n" );
						}
						
						i++;

						if ( endFlag )
						{
							break;
						}
					}
				}
				catch(Exception ex)
				{
					Invoke(new Action<string>(SendLog), $"エラー:{ex.Message.Replace("\n", "\r\n")}\r\n");
				}

				endFlag = true;
				Invoke(new Action<string>(SendLog), $"処理終了\r\n");
			});
		}
	}
}
