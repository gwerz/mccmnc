using System;
using System.Collections.Generic;

namespace com.IMSI.util
{
	public class MyDictionary<TKey, TValue>
	{
		private Dictionary<TKey, TValue>[] _dic;
		private int _nMaxItemPerPart = 40000000;
		#region property
		public int MaxItemPerPart
		{ 
			get { return _nMaxItemPerPart; }
			set { _nMaxItemPerPart = value; }
		}
		public long Count
		{
			get
			{
				long result = 0;
				for (int i = 0; i < _dic.Length; i++)
					result += _dic[i].Count;
				return result;
			}
		}
		public TValue this[TKey Key]
		{
			get 
			{
				try
				{
					for (int i = 0; i < _dic.Length; i++)
						if (_dic[i].ContainsKey(Key))
							return _dic[i][Key];
					KeyNotFoundException e = new KeyNotFoundException();
					throw e;
				}
				catch { throw; }
			}
			set
			{
				try
				{
					bool found = false;
					for (int i = 0; i < _dic.Length; i++)
						if (_dic[i].ContainsKey(Key))
						{
							_dic[i][Key] = value;
							found = true;
							break;
						}
					if (!found)
					{
						KeyNotFoundException e = new KeyNotFoundException();
						throw e;
					}
				}
				catch { throw; }
			}
		}
		#endregion
		public MyDictionary(int CountOfParts)
		{
			_dic = new Dictionary<TKey, TValue>[CountOfParts];
			for (int i = 0; i < CountOfParts; i++)
				_dic[i] = new Dictionary<TKey, TValue>();
		}
		public void Add(TKey Key, TValue Value)
		{
			try
			{
				bool added = false;
				for (int i = 0; i < _dic.Length; i++)
				{
					if (_dic[i].ContainsKey(Key))
					{
						//ArgumentException e = new ArgumentException("Key " + Key.ToString() + " has exists.");
						//throw e;
						//if the Key is exist,not add any more
						added = true;
						break;
					}
					if (_dic[i].Count < _nMaxItemPerPart)
					{
						_dic[i].Add(Key, Value);
						added = true;
						break;
					}
				}
				if (!added)
				{
					OutOfMemoryException e = new OutOfMemoryException("Out of Memory Error. The MyDictionary should be larger.");
					throw e;
				}
			}
			catch { throw; }
		}
		public bool Remove(TKey Key)
		{
			try
			{
				for (int i = 0; i < _dic.Length; i++)
					if (_dic[i].Remove(Key)) return true;
				return false;
			}
			catch { throw; }
		}
		public void Clear()
		{
			for (int i = 0; i < _dic.Length; i++) _dic[i].Clear();
		}
		public bool ContainsKey(TKey Key)
		{
			try
			{
				bool result = false;
				for (int i = 0; i < _dic.Length; i++)
				{
					result |= _dic[i].ContainsKey(Key);
					if (result) break;
				}
				return result;
			}
			catch { throw; }
		}
		public bool ContainsValue(TValue Value)
		{
			try
			{
				bool result = false;
				for (int i = 0; i < _dic.Length; i++)
				{
					result |= _dic[i].ContainsValue(Value);
					if (result) break;
				}
				return result;
			}
			catch { throw; }
		}
	}
}
