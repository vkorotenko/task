/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/12/2017
 * Time: 4:15 AM
 * 
 * Show more info on https://vkorotenko.github.io
 */ 
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Kvn.Task.Bl;

namespace Kvn.Task
{
	public sealed class NotificationIcon
	{
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
        private bool mainFormOpened;
        private MainForm mainForm;
		#region Initialize icon and menu
		public NotificationIcon()
		{
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());
			
			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			notifyIcon.ContextMenu = notificationMenu;
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("Show tasks", showTasksClick),
				new MenuItem("About", menuAboutClick),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "Kvn.Task", out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
				}
			} // releases the Mutex
		}
		#endregion
		
		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("About This Application");
		}
		private void showTasksClick(object sender,EventArgs e){

            if (mainForm == null)
            {
                var form = new MainForm();
                mainForm = form;
                mainFormOpened = true;
                form.FormClosed += formFormClosed;
                form.ShowDialog();
            }
            else {
                mainForm.Focus();
            }
            
		}

        void formFormClosed(object sender, FormClosedEventArgs e)
        {
            mainFormOpened = false;
            mainForm = null;
        }
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void IconDoubleClick(object sender, EventArgs e)
		{
            this.showTasksClick(sender, e);
		}
		#endregion
	}
}
