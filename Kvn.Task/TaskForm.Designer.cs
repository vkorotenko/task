/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/28/2017
 * Time: 1:27 AM
 * 
 * Show more info on https://vkorotenko.github.io
 */ 
namespace Kvn.Task
{
	partial class TaskForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.createdLabel = new System.Windows.Forms.Label();
			this.createdTextBox = new System.Windows.Forms.TextBox();
			this.dueDateLabel = new System.Windows.Forms.Label();
			this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.percentCombo = new System.Windows.Forms.ComboBox();
			this.doneCheckBox = new System.Windows.Forms.CheckBox();
			this.groupCombo = new System.Windows.Forms.ComboBox();
			this.importantCombo = new System.Windows.Forms.ComboBox();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.grouplabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(12, 11);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 23);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(118, 8);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(426, 22);
			this.nameTextBox.TabIndex = 1;
			// 
			// createdLabel
			// 
			this.createdLabel.Location = new System.Drawing.Point(12, 44);
			this.createdLabel.Name = "createdLabel";
			this.createdLabel.Size = new System.Drawing.Size(100, 23);
			this.createdLabel.TabIndex = 2;
			this.createdLabel.Text = "Created";
			// 
			// createdTextBox
			// 
			this.createdTextBox.Location = new System.Drawing.Point(118, 40);
			this.createdTextBox.Name = "createdTextBox";
			this.createdTextBox.Size = new System.Drawing.Size(140, 22);
			this.createdTextBox.TabIndex = 3;
			// 
			// dueDateLabel
			// 
			this.dueDateLabel.Location = new System.Drawing.Point(282, 44);
			this.dueDateLabel.Name = "dueDateLabel";
			this.dueDateLabel.Size = new System.Drawing.Size(100, 23);
			this.dueDateLabel.TabIndex = 4;
			this.dueDateLabel.Text = "Due date";
			// 
			// dueDatePicker
			// 
			this.dueDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dueDatePicker.Location = new System.Drawing.Point(388, 41);
			this.dueDatePicker.Name = "dueDatePicker";
			this.dueDatePicker.Size = new System.Drawing.Size(156, 22);
			this.dueDatePicker.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Persent";
			// 
			// percentCombo
			// 
			this.percentCombo.FormatString = "00 %";
			this.percentCombo.FormattingEnabled = true;
			this.percentCombo.Location = new System.Drawing.Point(118, 68);
			this.percentCombo.Name = "percentCombo";
			this.percentCombo.Size = new System.Drawing.Size(140, 24);
			this.percentCombo.TabIndex = 7;
			// 
			// doneCheckBox
			// 
			this.doneCheckBox.Location = new System.Drawing.Point(388, 68);
			this.doneCheckBox.Name = "doneCheckBox";
			this.doneCheckBox.Size = new System.Drawing.Size(104, 24);
			this.doneCheckBox.TabIndex = 8;
			this.doneCheckBox.Text = "Done";
			this.doneCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupCombo
			// 
			this.groupCombo.FormattingEnabled = true;
			this.groupCombo.Location = new System.Drawing.Point(118, 98);
			this.groupCombo.Name = "groupCombo";
			this.groupCombo.Size = new System.Drawing.Size(140, 24);
			this.groupCombo.TabIndex = 9;
			// 
			// importantCombo
			// 
			this.importantCombo.FormattingEnabled = true;
			this.importantCombo.Location = new System.Drawing.Point(388, 98);
			this.importantCombo.Name = "importantCombo";
			this.importantCombo.Size = new System.Drawing.Size(156, 24);
			this.importantCombo.TabIndex = 10;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(12, 128);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(532, 120);
			this.descriptionTextBox.TabIndex = 11;
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(282, 254);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 12;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButtonClick);
			// 
			// grouplabel
			// 
			this.grouplabel.Location = new System.Drawing.Point(13, 98);
			this.grouplabel.Name = "grouplabel";
			this.grouplabel.Size = new System.Drawing.Size(100, 23);
			this.grouplabel.TabIndex = 13;
			this.grouplabel.Text = "Group";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(282, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "Important";
			// 
			// TaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 289);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.grouplabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.importantCombo);
			this.Controls.Add(this.groupCombo);
			this.Controls.Add(this.doneCheckBox);
			this.Controls.Add(this.percentCombo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dueDatePicker);
			this.Controls.Add(this.dueDateLabel);
			this.Controls.Add(this.createdTextBox);
			this.Controls.Add(this.createdLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TaskForm";
			this.Text = "TaskForm";
			this.Load += new System.EventHandler(this.TaskFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label grouplabel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.ComboBox importantCombo;
		private System.Windows.Forms.ComboBox groupCombo;
		private System.Windows.Forms.CheckBox doneCheckBox;
		private System.Windows.Forms.ComboBox percentCombo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dueDatePicker;
		private System.Windows.Forms.Label dueDateLabel;
		private System.Windows.Forms.TextBox createdTextBox;
		private System.Windows.Forms.Label createdLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
	}
}
