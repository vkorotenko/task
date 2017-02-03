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
using Kvn.Task.Domain;

namespace Kvn.Task.Bl
{
	public class TaskMapper{
		TaskContainer _container;
		ListView _view;
		public TaskMapper(ListView view){
		_container = new TaskContainer();
		_view = view;
		FielGrid();
	}
		void FielGrid(){
		_view.Items.Clear();
		foreach(var task in _container.Tasks.Items){
			_view.Items.Add(new ListViewItem(task.Name));
		}
		_view.Update();
	}
		public void AddItem(TaskItem task){
		_container.Tasks.Add(task);
		Save();
		FielGrid();
	}
		/// <summary>
		/// Проверяем наличие файла беря название из файла настроек, при необходимости создаем новый.
		/// </summary>
		public void CheckExist()
		{
			var doc = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
			string path = Settings.Default.TaskFile;
			if(string.IsNullOrEmpty(path)){
				_container.CreateDefault(Path.Combine(doc,"task.xml"));
			}			
			_container.Load();
			FielGrid();
		}
		public void Save(){
			_container.Save();
		}
		
		public Group[] GetGroup()
		{
			return _container.Groups.Items;
		}
		
		public Important[] GetImport()
		{
			return _container.Importants.Items;
		}
	}
}
