using System;
namespace Hinzberg.HTMLToolbox
{
    public enum HeadlineSize
    {
        Size1, Size2, Size3, Size4, Size5, Size6
    }

    public class Headline : IHTMLRenderable
    {
        private string TextContent { get; set; }
        public HeadlineSize Size { get; set; }

        public Headline()
        {
            TextContent = string.Empty;
            Size = HeadlineSize.Size1;
        }

        public Headline(string textContent, HeadlineSize size = HeadlineSize.Size1)
        {
            Size = size;
            TextContent = textContent;
        }

        public string HTMLContent
        {
            get { return CreateHTMLContent(); }
        }

        private string CreateHTMLContent()
        {
            switch(Size)
            {
                case HeadlineSize.Size2:
                    return $"<h2>{TextContent}</h2>";
                case HeadlineSize.Size3:
                    return $"<h3>{TextContent}</h3>";
                case HeadlineSize.Size4:
                    return $"<h4>{TextContent}</h4>";
                case HeadlineSize.Size5:
                    return $"<h5>{TextContent}</h5>";
                case HeadlineSize.Size6:
                    return $"<h6>{TextContent}</h6>";
            }
            return $"<h1>{TextContent}</h1>";
        }
    }
}

