using System;
using System.Text;

namespace Hinzberg.HTMLToolbox
{
	public class UnorderedList : IHTMLRenderable, IListContentable<ListItem>
	{
		private List<ListItem> items;

        public UnorderedList()
		{
			items = new List<ListItem>();
		}

		public void Add(ListItem item)
		{
			this.items.Add(item);
		}

        public void Remove(ListItem item)
        {
            this.items.Remove(item);
        }

		public void Clear()
		{
			this.items.Clear();
		}

        public string HTMLContent
		{
			get { return CreateHTMLContent(); }
		}

		private string CreateHTMLContent()
		{
            StringBuilder sb = new StringBuilder();
            sb.Append($"<ul>{Environment.NewLine}");
            foreach (var item in items)
            {
                sb.Append($"{item.HTMLContent}{Environment.NewLine}");
            }
            sb.Append($"</ul>{Environment.NewLine}");
            return sb.ToString();
        }
    }
}


