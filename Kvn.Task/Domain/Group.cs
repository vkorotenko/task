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
	[Serializable]
	public class Group : BaseItem
	{
		[Required]		
		public string Name { get; set; }
		public SList<TaskItem> Tasks { get; set; }
	}

}
