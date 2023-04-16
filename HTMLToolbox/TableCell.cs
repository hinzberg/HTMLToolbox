namespace Hinzberg.HTMLToolbox
{
    public struct TableCellPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class TableCell : IHTMLRenderable
    {
        public IHTMLRenderable Content { get; private set; }
        public TableCellPosition Position { get; private set; }

        public TableCell(int row, int column, IHTMLRenderable content)
		{
            Position = new TableCellPosition() { X = column, Y = row };
            Content = content;
		}

        public void MovePosition(int row, int column)
        {
            Position = new TableCellPosition() { X = column, Y = row };
        }

        public string HTMLContent
        {
            get { return Content.HTMLContent; }
        }
    }
}

