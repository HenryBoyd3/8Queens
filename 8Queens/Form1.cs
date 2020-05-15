using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Queens
{
    public partial class Form1 : Form
    {
        Button[,] Spaces = new Button[8, 8];
        Location queenplace;//where algorithm lives
        int queen = 0;
        public Form1()
        {
           InitializeComponent();
           queenplace = new Location();
           setBoard();
        }

        private void RandomStart_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if ((row + col) % 2 == 0)
                        Spaces[col, row].BackColor = Color.DarkGray;
                    else
                    {
                        Spaces[col, row].BackColor = Color.White;
                    }
                    Spaces[col, row].Tag = "empty";
                }

            }
        }
        private void setBoard()
        {
            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {

                    Spaces[col, row] = new Button();
                    Spaces[col, row].Size = new Size(44, 44);
                    Spaces[col, row].Name = "" + col  + "" + row + "";
                    Spaces[col, row].Text = "" + (col+1) + "," + (row + 1) + "";
                    if ((row + col) % 2 == 0)
                        Spaces[col, row].BackColor = Color.DarkGray;
                    else
                    {
                        Spaces[col, row].BackColor = Color.White;
                    }
                    Spaces[col, row].Click += new EventHandler(testClick);
                    Spaces[col, row].Tag = "empty";
                    newgrid.Controls.Add(Spaces[col, row]);
                }
            }
        }
        private void testClick(object sender, EventArgs e)
        {
            Button test = sender as Button;
            int y = (test.Location.X - 3) / 50;
            int x = (test.Location.Y - 3) / 50;
            if (Spaces[x, y].Tag.ToString() == "empty")
            {
                Spaces[x, y].Tag = "queen" + queen;
                queen++;
                setMap(x, y);
                
            }
            else if ((Spaces[x, y].Tag.ToString() == "queen"))
            {
                Spaces[x, y].BackColor = Color.Yellow;
                Spaces[x, y].Tag = "empty";
                resetMap();
                queen--;
            }
                
        }

         private void setMap(int col, int row)
         {
            blockRow(col, row);
            blockCol(col,row);
            blockUpLeft(col, row);
            blockUpRight(col, row);
            blockDownLeft(col, row);
            blockDownRight(col, row);
            setQueen(col,row);
         } 
         private void blockRow(int col, int row)
           {
            for (int sRow = 0; sRow < 8; sRow++)
            {
                if (!(sRow == row))
                    block(col, sRow);     
            }
           }
         private void blockCol(int col, int row)
            {
            for (int sCol = 0; sCol < 8; sCol++)
            {
                if (!(sCol == col))
                    block(sCol, row);
            }
            }
         private void blockUpLeft(int col, int row)
           {
            int dCol = col;
            int dRow = row;
            int blocks = 0;
            while (blocks < 8)
            {
                if ((dCol < 0) || (dRow < 0))
                    break;
                if (!(dCol == col) && !(dRow == row))
                {    
                    block(dCol, dRow);
                }
                dCol = dCol - 1;
                dRow = dRow - 1;
                blocks++;
            }
            }
         private void blockUpRight(int col, int row)
            {
            int dCol = col;
            int dRow = row;
            int blocks = 0;
            while (blocks < 8)
            {
                if ((dCol < 0) || (dRow > 7))
                    break;
                if (!(dCol == col) && !(dRow == row))
                {
                    block(dCol, dRow);
                }
                dCol = dCol - 1;
                dRow = dRow + 1;
                blocks++;
            }
            }
         private void blockDownLeft(int col, int row)
           {
            int dCol = col;
            int dRow = row;
            int blocks = 0;
            while (blocks < 8)
            {
                if ((dCol > 7) || (dRow < 0))
                    break;
                if (!(dCol == col) && !(dRow == row))
                {
                    block(dCol, dRow);
                }
                dCol = dCol + 1;
                dRow = dRow - 1;
                blocks++;
            }
           }
         private void blockDownRight(int col, int row)
           {
            int dCol = col;
            int dRow = row;
            int blocks = 0;
            while (blocks < 8)
            {
                if ((dCol > 7) || (dRow > 7))
                    break;
                if (!(dCol == col) && !(dRow == row))
                {
                    block(dCol, dRow);
                }
                dCol = dCol + 1;
                dRow = dRow + 1;
                blocks++;
            }
           }
         private void setQueen (int col, int row)
            {
               Spaces[col,row].Tag = "queen";
               Spaces[col, row].BackColor = Color.Blue;
            }
        private void block(int col, int row)
         {
            if ((!(col < 0 && row < 0) || !(col > 7 && row > 7))
                && (Spaces[col, row].Tag.ToString() == "empty"))
            {
                Spaces[col, row].Tag = "blocked"+queen;
                Spaces[col, row].BackColor = Color.Red;
            }

         }
        private void resetMap()
        {
            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (((row + col) % 2 == 0) && (Spaces[col, row].Tag.ToString() == ("blocked" + queen)))
                    {
                        Spaces[col, row].BackColor = Color.DarkGray;
                        Spaces[col, row].Tag = "empty";

                    }
                    else if (Spaces[col, row].Tag.ToString() == ("blocked" + queen))
                    {
                        Spaces[col, row].BackColor = Color.White;
                        Spaces[col, row].Tag = "empty";
                    }
                    
                }

            }
        }
    }
}
