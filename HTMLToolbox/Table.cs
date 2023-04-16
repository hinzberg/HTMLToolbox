using System.Data.Common;
using System.Text;

namespace Hinzberg.HTMLToolbox
{
	public class Table : IHTMLRenderable
    {
        private int _columnCount = 0;
        private int _rowCount = 0;
        private readonly List<TableCell> _cells = new List<TableCell>();

        public Table(int rowCount = 0, int columnCount = 0)
        {
            _columnCount = columnCount;
            _rowCount = rowCount;
        }

        public void AddColumn()
        {
            _columnCount++;
        }

        public void AddRow()
        {
            _rowCount++;
        }

        public void AddCell(TableCell cell)
        {
            if (cell.Position.X > _columnCount -1  || cell.Position.Y > _rowCount -1)
                throw new IndexOutOfRangeException(@"TableCell Position out of Tablesize.");

            if (cell.Position.X < 0 || cell.Position.Y < 0)
                throw new IndexOutOfRangeException(@"Negative TableCell Position not valid.");

            var oldCell = _cells.Where(a => a.Position.X == cell.Position.X && a.Position.Y == cell.Position.Y).FirstOrDefault();
            if (oldCell != null)
                _cells.Remove(oldCell);

                _cells.Add(cell);
        }

        public void Clear()
        {
            _cells.Clear();
        }

        public void RemoveCell(TableCell cell)
        {
            _cells.Remove(cell);
        }

        public void RemoveCell(int row, int column)
        {
            _cells.RemoveAll(a => a.Position.X == column && a.Position.X == row);
        }

        public string HTMLContent
        {
            get { return CreateHTMLContent(); }
        }

        private string CreateHTMLContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<table>{Environment.NewLine}");

            for (int row = 0; row < _rowCount; row++)
            {
                sb.Append($"<tr>{Environment.NewLine}");
                for (int column = 0; column < _columnCount; column++)
                {
                    sb.Append($"<td>");
                    string content = GetCellContent(column, row);
                    if (content != string.Empty)
                        sb.Append(content);
                    sb.Append($"<td>{Environment.NewLine}");
                }
                sb.Append($"<tr>{Environment.NewLine}");
            }

            sb.Append($"</table>{Environment.NewLine}");
            return sb.ToString();
        }

        private string GetCellContent(int column, int row)
        {
            var cell = _cells.Where(a => a.Position.X == column && a.Position.Y == row).FirstOrDefault();
            if (cell != null)
                return cell.HTMLContent;
            return string.Empty;
        }
    }
}