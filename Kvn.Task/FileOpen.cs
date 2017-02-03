/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/27/2017
 * Time: 12:56 PM
 * 
 * Show more info on https://vkorotenko.github.io
 */ 
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kvn.Task
{
	/// <summary>
	/// Description of FileOpen.
	/// </summary>
	public partial class FileOpen : Form
	{
		public string FilePath{get; private set;}
		public FileOpen(string path)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			FilePath = path;
			
		}
		
		void OkButtonClick(object sender, EventArgs e)
		{
			Settings.Default.TaskFile = FilePath;
		}
		
		void SelectFileClick(object sender, EventArgs e)
		{
			var dir = System.IO.Path.GetDirectoryName(FilePath);
			openFileDialog.InitialDirectory = dir;
			if(openFileDialog.ShowDialog() == DialogResult.OK){
				FilePath = openFileDialog.FileName;
			}
		}
	}
}
