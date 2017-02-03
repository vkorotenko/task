/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/27/2017
 * Time: 12:56 PM
 * 
 * Show more info on https://vkorotenko.github.io
 */ 
namespace Kvn.Task
{
	partial class FileOpen
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
			this.label1 = new System.Windows.Forms.Label();
			this.selectFileButton = new System.Windows.Forms.Button();
			this.fileTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Store in file:";
			// 
			// selectFileButton
			// 
			this.selectFileButton.Location = new System.Drawing.Point(367, 5);
			this.selectFileButton.Name = "selectFileButton";
			this.selectFileButton.Size = new System.Drawing.Size(29, 25);
			this.selectFileButton.TabIndex = 1;
			this.selectFileButton.Text = "...";
			this.selectFileButton.UseVisualStyleBackColor = true;
			this.selectFileButton.Click += new System.EventHandler(this.SelectFileClick);
			// 
			// fileTextBox
			// 
			this.fileTextBox.Location = new System.Drawing.Point(118, 6);
			this.fileTextBox.Name = "fileTextBox";
			this.fileTextBox.Size = new System.Drawing.Size(243, 22);
			this.fileTextBox.TabIndex = 2;
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(118, 35);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButtonClick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "xml";
			this.openFileDialog.FileName = "OpenFileDialog";
			this.openFileDialog.Title = "File to store task";
			// 
			// FileOpen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 71);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.fileTextBox);
			this.Controls.Add(this.selectFileButton);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileOpen";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "FileOpen";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox fileTextBox;
		private System.Windows.Forms.Button selectFileButton;
		private System.Windows.Forms.Label label1;
	}
}
