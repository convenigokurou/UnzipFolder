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

		private void UpdateExtFile( string file, int index, int all )
		{
			lblExtFile.Text = $"({index+1}/{all}){file}";
			
			pbExtFile.Minimum = 0;
			pbExtFile.Maximum = all - 1;
			pbExtFile.Value = index;
		}

		private void UpdateFile( string file, int index, int all )
		{
			lblFile.Text = $"({index+1}/{all}){file}";
			
			pbFile.Minimum = 0;
			pbFile.Maximum = all - 1;
			pbFile.Value = index;
		}

		public ExtractForm()
		{
			InitializeComponent();
		}

		private void ExtractForm_Load(object sender, EventArgs e)
		{
			Task t = Task.Run( () => 
			{ 
				List<string> fileList = new List<string>();
				fileList.AddRange( Directory.EnumerateFiles( InputPath, "*.zip", SearchOption.AllDirectories ).ToList() );
				fileList.AddRange( Directory.EnumerateFiles( InputPath, "*.rar", SearchOption.AllDirectories ).ToList() );

				int i = 0;
				foreach( string f in fileList)
				{
					Invoke( new Action<string, int, int>(UpdateExtFile),  f, i, fileList.Count);

                    using (var zip = ArchiveFactory.Open(f))
                    {
						var options = new ExtractionOptions();
						options.ExtractFullPath = true;
						options.Overwrite = true;

						int j = 0;
						foreach(var ent in zip.Entries)
						{
							Invoke( new Action<string, int, int>(UpdateFile),  ent.Key, j, zip.Entries.Count());

							ent.WriteToDirectory(OutputPath, options);
							
							j++;
						}
					}

					if( IsEndDelete )
					{
						File.Delete(f);
					}

					i++;
				}

				Invoke( new Action(Close) );
			});
		}
	}
}
