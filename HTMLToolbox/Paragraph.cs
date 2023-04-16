using System;
using System.Drawing;
using Hinzberg.HTMLToolbox;

namespace Hinzberg.HTMLToolbox
{
    public enum ParagraphAlignment
    {
        Justify,
        Left,
        Right,
        Center
    }

    public class Paragraph : IHTMLRenderable
    {
        private string TextContent { get; set; }
        public ParagraphAlignment Alignment { get; set; }

        public Paragraph()
        {
            TextContent = string.Empty;
            Alignment = ParagraphAlignment.Left;
        }

        public Paragraph(string textContent, ParagraphAlignment alignment = ParagraphAlignment.Left)
        {
            Alignment = alignment;
            TextContent = textContent;
        }

        public string HTMLContent
        {
            get { return CreateHTMLContent(); }
        }

        private string CreateHTMLContent()
        {
            switch (Alignment)
            {
                case ParagraphAlignment.Justify:
                    return $"<p align=\"justify\">{TextContent}</p>{Environment.NewLine}";
                case ParagraphAlignment.Right:
                    return $"<p align=\"right\">{TextContent}</p>{Environment.NewLine}";
                case ParagraphAlignment.Center:
                    return $"<p align=\"center\">{TextContent}</p>{Environment.NewLine}";
            }
            return $"<p align=\"left\">{TextContent}</p>";
        }
    }
}

