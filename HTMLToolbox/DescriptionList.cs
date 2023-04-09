using System;
using Hinzberg.HTMLToolbox;
using System.Text;

namespace Hinzberg.HTMLToolbox
{
	public class DescriptionList : IHTMLRenderable, IListContentable<IDescriptionListItem>
	{
        private List<IDescriptionListItem> items;

        public DescriptionList()
        {
            items = new List<IDescriptionListItem>();
        }

        public void Add(IDescriptionListItem item)
        {
            this.items.Add(item);
        }

        public void Remove(IDescriptionListItem item)
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
            sb.Append($"<dl>{Environment.NewLine}");
            foreach (var item in items)
            {
                sb.Append($"{item.HTMLContent}{Environment.NewLine}");
            }
            sb.Append($"</dl>{Environment.NewLine}");
            return sb.ToString();
        }
    }
}

