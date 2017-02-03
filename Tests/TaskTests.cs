/*
 * Created by SharpDevelop.
 * User: Vladimir Korotenko
 * Date: 1/26/2017
 * Time: 4:35 AM
 * 
 * Show more info on https://vkorotenko.github.io
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Kvn.Task.Domain;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class TaskTests{
		[Test(Description="Enumerate all record")]
		public void EnumerateAll(){
			//var t = DbContext.Instance;
			//var values = t.Tasks.All();
		}
		[Test]
		public void GetById(){}
	}
}
