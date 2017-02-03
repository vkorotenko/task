/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/28/2017
 * Time: 1:27 AM
 * 
 * Show more info on https://vkorotenko.github.io
 */ 
using System;
using System.Drawing;
using System.Windows.Forms;

using Kvn.Task.Domain;

namespace Kvn.Task
{
	/// <summary>
	/// Description of TaskForm.
	/// </summary>
	public partial class TaskForm : Form
	{
		public TaskItem Task { get; set; }
		public Group[] Groups { get; set; }
		public Important[] Importants { get; set; }
		public TaskForm( TaskItem task, Group[] groups, Important[] import)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Task = task;
			Groups = groups;
			Importants = import;
			
		}
		
		void TaskFormLoad(object sender, EventArgs e)
		{
			nameTextBox.Text = Task.Name;
			createdTextBox.Text = Task.Created.ToString("dd/MM/yyyy HH:mm");
			dueDatePicker.Value = Task.DueDate;
			doneCheckBox.Checked = Task.IsComplite;
			FielPercents(Task.Persent);
			descriptionTextBox.Text = Task.Description;
		}
		void FielPercents(int value){
			for (int i = 0; i <= 10; i++) {
				percentCombo.Items.Add(i*10);
			}
			percentCombo.SelectedValue =Task.Persent;
		}
		
		void OkButtonClick(object sender, EventArgs e)
		{
			Task.Name = nameTextBox.Text;
			Task.Description = descriptionTextBox.Text;
			Task.DueDate= dueDatePicker.Value;
			Task.IsComplite =doneCheckBox.Checked;
		}
	}
}
