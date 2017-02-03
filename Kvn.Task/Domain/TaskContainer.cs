/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/26/2017
 * Time: 8:56 PM
 * 
 * Show more info on https://vkorotenko.github.io
 */ 
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Kvn.Task.Domain
{
	/// <summary>
	/// Description of TaskContainer.
	/// </summary>
	[Serializable]
	public class TaskContainer 
	{
		public TaskContainer() 
		{
			Groups = new SList<Group>();
			Importants = new SList<Important>();
			Tasks = new SList<TaskItem>();
		}		
		public SList<Important> Importants { get; set; }
		public SList<TaskItem> Tasks { get; set; }	
		public SList<Group> Groups { get; set; }
		
		
		public void CreateDefault(string path)
		{
			
			// TODO: add default values
			Settings.Default.TaskFile = path;
			Settings.Default.Save();
			if(!File.Exists(path))
				Save();
		}
		public void Save(){
			var path = Settings.Default.TaskFile;
			var serializer = new XmlSerializer(typeof(TaskContainer));
			var writer = new StreamWriter(path);
			serializer.Serialize(writer.BaseStream,this);
			writer.Close();
		}
		public void Load(){
			var path = Settings.Default.TaskFile;
			var serializer = new XmlSerializer(typeof(TaskContainer));
			var reader = new StreamReader(path);
			var cnt = (TaskContainer)serializer.Deserialize(reader);
			Importants = cnt.Importants;
			Tasks= cnt.Tasks;
			Groups = cnt.Groups;
			reader.Close();
		}
	}

}
