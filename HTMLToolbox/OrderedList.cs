using System;
using System.Text;

namespace Hinzberg.HTMLToolbox
{
    public enum OrderedListType
    {
        Numbers, 
        UppercaseLetters, 
        LowercaseLetters, 
        UppercaseRomanNumbers, 
        LowercaseRomanNumbers 
    }

    public class OrderedList : IHTMLRenderable, IListContentable<ListItem>
    {
        private List<ListItem> items;
        public OrderedListType ListType { get; set; }

        public OrderedList(OrderedListType listType = OrderedListType.Numbers)
        {
            ListType = listType;
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

            switch (ListType)
            {
                case OrderedListType.UppercaseLetters:
                    sb.Append($"<ol type= \"A\">{Environment.NewLine}");
                    break;

                case OrderedListType.LowercaseLetters:
                    sb.Append($"<ol type= \"a\">{Environment.NewLine}");
                    break;

                case OrderedListType.UppercaseRomanNumbers:
                    sb.Append($"<ol type= \"I\">{Environment.NewLine}");
                    break;

                case OrderedListType.LowercaseRomanNumbers:
                    sb.Append($"<ol type= \"i\">{Environment.NewLine}");
                    break;

                default:
                    sb.Append($"<ol type= \"1\">{Environment.NewLine}");
                    break;
            }

            foreach (var item in items)
            {
                sb.Append($"{item.HTMLContent}{Environment.NewLine}");
            }
            sb.Append($"</ol>{Environment.NewLine}");
            return sb.ToString();
        }
    }
}


