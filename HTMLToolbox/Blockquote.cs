using System;
namespace Hinzberg.HTMLToolbox
{
    public class BlockQuote : IHTMLRenderable
    {
        public string TextContent { get; set; }

        public BlockQuote()
        {
            TextContent = string.Empty;
        }

        public BlockQuote(string textContent)
        {
            TextContent = textContent;
        }

        public string HTMLContent => $"<blockquote>{TextContent}</blockquote>{Environment.NewLine}";
    }
}
