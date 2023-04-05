using System;
using System.Text;
using System.Xml.Linq;

namespace Hinzberg.HTMLToolbox
{
	public class HTMLDocument : IListContentable<IHTMLRenderable>, IHTMLRenderable
    {
		List<IHTMLRenderable> elements;

        public HTMLDocument()
		{
			this.elements = new List<IHTMLRenderable>();
		}
        		
        public void Add(IHTMLRenderable item)
        {
            this.elements.Add(item);
        }

        public void Remove(IHTMLRenderable item)
        {
            this.elements.Remove(item);
        }

        public void Clear()
        {
            this.elements.Clear();
        }

        public string HTMLContent
        {
            get { return CreateHTMLContent();  }
        }

        private string CreateHTMLContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<!DOCTYPE html>{Environment.NewLine}");
            sb.Append($"<html>{Environment.NewLine}");

            sb.Append($"<body>{Environment.NewLine}");
            foreach (var element in elements)
            {
                sb.Append(element.HTMLContent);
            }
            sb.Append($"</body>{Environment.NewLine}");
            sb.Append($"</html>{Environment.NewLine}");

            return sb.ToString();
        }
    }
}

