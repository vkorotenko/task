/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/26/2017
 * Time: 3:24 AM
 * 
 * Show more info on https://vkorotenko.github.io
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kvn.Task.Domain
{
	/// <summary>
	/// Description of Task.
	/// </summary>
	///[Table("Tasks")]
	[Serializable]
	public class TaskItem : BaseItem
	{
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public DateTime DueDate { get; set; }
		public bool IsComplite { get; set; }
		public TaskItem Parent { get; set; }
		public SList<TaskItem> Childs { get; set; }
		public Group Group { get; set; }
		public SList<Comment> Comments { get; set; }
		[Range(0,100)]
		public int Persent { get; set; }
	}

}
