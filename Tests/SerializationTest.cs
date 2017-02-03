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
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Kvn.Task.Domain;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class SerializationTest{
		string path ="ser.xml";
		[Test]
		public void Serialize(){
			TaskContainer cont = new TaskContainer();
			cont.Groups.Add(new Group{Name="test"});
			
			
			
			var serializer = new XmlSerializer(typeof(TaskContainer));
			StringBuilder sb = new StringBuilder();
			StringWriter sw = new StringWriter(sb);
			serializer.Serialize(sw, cont); 
			string xmlResult = sw.GetStringBuilder().ToString();
			var test = File.ReadLines(path);
		}
	}
}
