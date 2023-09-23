using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form2 : Form
    {
        public TextBox textBoxMove;
        PictureBox picturebox0 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox1 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox2 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox3 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox4 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox5 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox6 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox7 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox8 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox9 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox10 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        PictureBox picturebox11 = new PictureBox { Visible = true, SizeMode = PictureBoxSizeMode.Zoom };
        int column, row;
        string _x, _y, move;
        public Form2()
        {
            InitializeComponent();
            var items = new object[] { "White King", "White Queen", "White Rook", "White Bishop", "White Knight", "White Pawn",
                                       "Black King", "Black Queen", "Black Rook", "Black Bishop", "Blacke Knight", "Black Pawn" };
            comboBoxFugura.Items.AddRange(items);    
            tableLayoutPanelBoard.CellPaint += (object sender, TableLayoutCellPaintEventArgs e) =>
            {
                Brush brush = ((e.Column & 1) != (e.Row & 1)) ? Brushes.DarkGray : Brushes.Gray;
                e.Graphics.FillRectangle(brush, e.CellBounds);                
            };            
        }
        private string figureMove(PictureBox pictureBox)
        {
            List<string> lst = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H"};
            List<string> num = new List<string> { "8", "7", "6", "5", "4", "3", "2", "1" };              
            _x = tableLayoutPanelBoard.GetColumn(pictureBox).ToString(); // _x буквы
            _y = tableLayoutPanelBoard.GetRow(pictureBox).ToString(); // _y цифры
            for (int i  = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < num.Count; j++)
                {
                    if (i.ToString() == _x && j.ToString() == _y)
                    {
                        _x = lst[i];
                        _y = num[j];
                    }
                } 
            }                        
            move = (_x + _y);
            return move;
        }
        private void tableLayoutPanelBoard_Click(object sender, EventArgs e)
        {           
            findPoint(tableLayoutPanelBoard.PointToClient(Cursor.Position));            
            switch (comboBoxFugura.SelectedIndex)
            {
                case 0:                   
                    picturebox0.Image = Properties.Resources.whiteKing;
                    tableLayoutPanelBoard.Controls.Add(picturebox0, column, row);      
                   // textBoxMove.Text = "White King " + tableLayoutPanelBoard.GetColumn(picturebox0).ToString() + ":" + tableLayoutPanelBoard.GetRow(picturebox0).ToString();
                    //textBoxMove.Text = "White King " + column.ToString() + row.ToString();
                    textBoxMove.Text = "White King " + figureMove(picturebox0).ToString();
                    break;
                case 1:                   
                    picturebox1.Image = Properties.Resources.whiteQueen;
                    tableLayoutPanelBoard.Controls.Add(picturebox1, column, row);
                    textBoxMove.Text = "White Queen " + figureMove(picturebox1).ToString();
                    break;
                case 2:                  
                    picturebox2.Image = Properties.Resources.whiteRook;
                    tableLayoutPanelBoard.Controls.Add(picturebox2, column, row);
                    textBoxMove.Text = "White Rook " + figureMove(picturebox2).ToString();
                    break;
                case 3:                   
                    picturebox3.Image = Properties.Resources.whiteBishop;
                    tableLayoutPanelBoard.Controls.Add(picturebox3, column, row);
                    textBoxMove.Text = "White Bishop " + figureMove(picturebox3).ToString();
                    break;
                case 4:                   
                    picturebox4.Image = Properties.Resources.whiteKnight;
                    tableLayoutPanelBoard.Controls.Add(picturebox4, column, row);
                    textBoxMove.Text = "White Knight " + figureMove(picturebox4).ToString();
                    break;
                case 5:                  
                    picturebox5.Image = Properties.Resources.whitePawn;
                    tableLayoutPanelBoard.Controls.Add(picturebox5, column, row);
                    textBoxMove.Text = "White Pawn " + figureMove(picturebox5).ToString();
                    break;
                case 6:                    
                    picturebox6.Image = Properties.Resources.blackKing;
                    tableLayoutPanelBoard.Controls.Add(picturebox6, column, row);
                    textBoxMove.Text = "Black King " + figureMove(picturebox6).ToString();
                    break;
                case 7:                    
                    picturebox7.Image = Properties.Resources.blackQueen;
                    tableLayoutPanelBoard.Controls.Add(picturebox7, column, row);
                    textBoxMove.Text = "Black Queen " + figureMove(picturebox7).ToString();
                    break;
                case 8:                    
                    picturebox8.Image = Properties.Resources.blackRook;
                    tableLayoutPanelBoard.Controls.Add(picturebox8, column, row);
                    textBoxMove.Text = "Black Rook " + figureMove(picturebox8).ToString();
                    break;
                case 9:                    
                    picturebox9.Image = Properties.Resources.blackBishop;
                    tableLayoutPanelBoard.Controls.Add(picturebox9, column, row);
                    textBoxMove.Text = "Black Bishop " + figureMove(picturebox9).ToString();
                    break;
                case 10:                   
                    picturebox10.Image = Properties.Resources.blackeKnight;
                    tableLayoutPanelBoard.Controls.Add(picturebox10, column, row);
                    textBoxMove.Text = "Black Knight " + figureMove(picturebox10).ToString();
                    break;
                case 11:                   
                    picturebox11.Image = Properties.Resources.blackPawn;
                    tableLayoutPanelBoard.Controls.Add(picturebox11, column, row);
                    textBoxMove.Text = "Black Pawn " + figureMove(picturebox11).ToString();
                    break;
            }
        }
        private void findPoint(Point point)
        {
            if (point.X > tableLayoutPanelBoard.Width || point.Y > tableLayoutPanelBoard.Height)
            {
                return;
            }     
            int w = tableLayoutPanelBoard.Width;
            int h = tableLayoutPanelBoard.Height;
            int[] widths = tableLayoutPanelBoard.GetColumnWidths();
            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
            {
                w -= widths[i];                
            }            
            column = i + 1;
            int[] heights = tableLayoutPanelBoard.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
            {
                h -= heights[i];                
            }
            row = i + 1;    
        }       
    }
}
