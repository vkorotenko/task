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
	public class BaseItem{
		public BaseItem(){
			Id= Guid.NewGuid();
		}
		[Key]
		public Guid Id { get; set; }		
	}

}
