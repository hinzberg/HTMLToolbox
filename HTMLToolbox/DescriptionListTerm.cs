using System;
using Hinzberg.HTMLToolbox;

namespace Hinzberg.HTMLToolbox
{
    public class DescriptionListTerm : IDescriptionListItem
    {
        private string TextContent { get; set; }

        public DescriptionListTerm()
        {
            TextContent = string.Empty;
        }

        public DescriptionListTerm(string textContent)
        {
            TextContent = textContent;
        }

        public string HTMLContent => $"<dt>{TextContent}</dt>";
    }
}

