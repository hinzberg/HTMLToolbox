using System;
namespace Hinzberg.HTMLToolbox
{
	public interface IListContentable<T>
	{
		void Add(T item);
		void Remove(T item);
		void Clear();
	}
}

