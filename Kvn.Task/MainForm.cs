/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/25/2017
 * Time: 9:50 PM
 * 
 * Show more info on https://vkorotenko.github.io
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Kvn.Task.Bl;
using Kvn.Task.Domain;

namespace Kvn.Task
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class MainForm : Form
	{
		public TaskMapper _mapper;
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		
		void AddToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.ExitThread();
		}
		
		void CreteNewTaskToolbarClick(object sender, EventArgs e)
		{
			TaskItem task = new TaskItem{
			Created = DateTime.Now,
			Updated=DateTime.Now,
			DueDate=DateTime.Now
			};
			var groups = _mapper.GetGroup();
			var import = _mapper.GetImport();
			var form = new TaskForm(task,groups,import);
			if(form.ShowDialog() == DialogResult.OK){
				_mapper.AddItem(form.Task);
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			_mapper = new TaskMapper(tasksListView);
			_mapper.CheckExist();
            FielGroupCombo();
            FielImportantComboBox();
			RestoreTaskFormPosition();
		}

        private void FielImportantComboBox()
        {
            var importants = _mapper.GetImport();
            var icb = importantComboBox;
            icb.Items.Add(allSign);
            foreach (var imp in importants)
            {
                icb.Items.Add(imp.Name);
            }
            icb.Items.Add(addString);
        }
        const string allSign = "*";
        const string addString = "Add ...";
        private void FielGroupCombo()
        {
            var groups = _mapper.GetGroup();
            var gcb = groupComboBox;
            gcb.Items.Add(allSign);
            foreach (var group in groups)
            {
                gcb.Items.Add(group.Name);
            }
            gcb.Items.Add(addString);
        }

		void RestoreTaskFormPosition()
		{
			var size = Settings.Default.FormSize;
			var pos = Settings.Default.FormPosition;
			if (pos.X != 0 && pos.Y != 0) {
				Left = pos.Y;
				Top = pos.X;
			}
			if (size.Width != 0 && size.Height != 0) {
				Width = size.Width;
				Height = size.Height;
			}
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Size size = new Size{
				Width = Width,
				Height= Height
			};
			Point pos = new Point{X = Top,Y=Left};
			Settings.Default.FormPosition =pos;
			Settings.Default.FormSize=size;
			Settings.Default.Save();
		}
	}

}
