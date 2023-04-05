﻿using System;
namespace Hinzberg.HTMLToolbox
{
	public class ListItem : IHTMLRenderable
	{
        private string TextContent { get; set; }

        public ListItem()
		{
			TextContent = string.Empty;
		}

        public ListItem(string textContent)
        {
			TextContent = textContent;
        }

		public string HTMLContent => $"<li>{TextContent}</li>";
    }
}

