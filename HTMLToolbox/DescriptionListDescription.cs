using System;
using Hinzberg.HTMLToolbox;

namespace Hinzberg.HTMLToolbox
{
    public class DescriptionListDescription :  IDescriptionListItem
    {
        private string TextContent { get; set; }

        public DescriptionListDescription()
        {
            TextContent = string.Empty;
        }

        public DescriptionListDescription(string textContent)
        {
            TextContent = textContent;
        }

        public string HTMLContent => $"<dd>{TextContent}</dd>";
    }
}

