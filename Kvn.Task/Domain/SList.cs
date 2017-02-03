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
using System.Runtime.Serialization;

namespace Kvn.Task.Domain
{
	[Serializable]
	public class SList<T>
	{
		private List<T> _items;
		public SList(){
			_items = new List<T>();
		}
		public SList(T[] items){
			_items = new List<T>();
			_items.AddRange(items);
		}
		public T[] Items { 
			get{return _items.ToArray();}
			set {_items = new List<T>(value);}
		}
		public T this[int i]
		{
		    get { return _items[i]; }
		    set { _items[i] = value; }
		}
		public bool Delete(T item){
			return _items.Remove(item);
		}
		public void Add(T item){
			 _items.Add(item);
		}
		public void AddRange(IEnumerable<T> items ){
			_items.AddRange(items);
		}
	}
}
