using System;
namespace Hinzberg.HTMLToolbox
{
    public class Cite : IHTMLRenderable
    {
        public string TextContent { get; set; }

        public Cite()
        {
            TextContent = string.Empty;
        }

        public Cite(string textContent)
        {
            TextContent = textContent;
        }

        public string HTMLContent => $"<cite>{TextContent}</cite>{Environment.NewLine}";
    }
}