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
        //col and row are backwards so the program solves the problem from left to right then top to bottom
        Button[,] Spaces = new Button[8, 8];
        int queen = 0;
        int ran1, ran2;
        public Form1()
        {
            InitializeComponent();
            setBoard();
        }

        private void RestartButton(object sender, EventArgs e)
        {
            reset();
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
                    Spaces[col, row].Text = "" + (col) + "," + (row) + "";
                }

            }
            queen = 0;
        }
        //makes the board at runtime and fills all buttons
        private void setBoard()
        {
            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {

                    Spaces[col, row] = new Button();
                    Spaces[col, row].Size = new Size(44, 44);
                    Spaces[col, row].Name = "" + col + "" + row + "";
                    Spaces[col, row].Text = "" + (col ) + "," + (row ) + "";
                    if ((row + col) % 2 == 0)
                        Spaces[col, row].BackColor = Color.DarkGray;
                    else
                    {
                        Spaces[col, row].BackColor = Color.White;
                    }
                    Spaces[col, row].Click += new EventHandler(QueenSelectClick);
                    Spaces[col, row].Tag = "empty";
                    newgrid.Controls.Add(Spaces[col, row]);
                }
            }
        } 

        #region Block_And_Unblock_Functions
        private void setMap(int col, int row)
        {
            blockRow(col, row);
            blockCol(col, row);
            blockUpLeft(col, row);
            blockUpRight(col, row);
            blockDownLeft(col, row);
            blockDownRight(col, row);
            setQueen(col, row);
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
        private void setQueen(int col, int row)
        {
            
            Spaces[col, row].Tag = ("queen" + queen);         
            Spaces[col, row].BackColor = Color.Blue;
            Spaces[col, row].Text = "Q"+queen;
            if (queen == 1)
                Spaces[col, row].BackColor = Color.Green;
        }
        private void removeLastQueen()
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
        private void block(int col, int row)
        {
            if ((!(col < 0 && row < 0) || !(col > 7 && row > 7))
                && (Spaces[col, row].Tag.ToString() == "empty"))
            {
                Spaces[col, row].Tag = "blocked" + queen;
                Spaces[col, row].BackColor = Color.Red;
            }

        }
        #endregion
        //algorithm and starting locations for algorithm
        #region algorithm
        private void QueenSelectClick(object sender, EventArgs e)
        {
            Button test = sender as Button;
            int y = (test.Location.X - 3) / 50;
            int x = (test.Location.Y - 3) / 50;
            startAlg(x, y);
            test.BackColor = Color.DarkGoldenrod;//your placed queen
        }
        private void randomStart(object sender, EventArgs e)
        {
            var rand = new Random();
            ran1 = rand.Next(8);
            ran2 = rand.Next(8);
            startAlg(ran1,ran2);
        }
        private void startAlg(int column, int Row)
        {
            if (queen == 0)
                Spaces[column, Row].BackColor = Color.Green;//color of starting space
            while (queen < 8)
            {

                recrsiveFun(column, Row);
                
            }


        }
        private void recrsiveFun(int c, int r)
        {
            if (queen == 8)//checks if puzzle is won
            {
            }
            else if (Spaces[c, r].Tag.ToString() == ("queen" + queen) && r == 7 && !(c == 0))
            {
                removeQueen(c, r);
                recrsiveFun((c - 1), (0));
            }
            else if (Spaces[c, r].Tag.ToString() == ("queen" + queen) && r == 7 && (c == 0))
            {
                removeQueen(c, r);
                recrsiveFun((7), (0));
            }
            else if (Spaces[c, r].Tag.ToString() == ("queen" + queen))
            {
                removeQueen(c, r);
                recrsiveFun(c, (r + 1));
            }
            else if (Spaces[c, r].Tag.ToString() == "empty" && (c == 7))
            {
                emptyLocations(c, r);
                recrsiveFun((0), 0);
            }
            else if (Spaces[c, r].Tag.ToString() == "empty" && !(c == 7))
            {
                emptyLocations(c, r);
                recrsiveFun((c + 1), 0);
            }
            else if (!(Spaces[c, r].Tag.ToString() == "empty") && r < 7)
            {
                recrsiveFun(c, (r + 1));
            }
            else if ((r == 7) && !(c == 0))
            {
                recrsiveFun((c - 1), r = 0);
            }
            else if ((c == 0) && r == 7)
            {
                recrsiveFun(c = 7, r = 0);
            }

        }
        private void emptyLocations(int x, int y)
        {
            Spaces[x, y].Tag = "queen" + queen;
            queen++;
            setMap(x, y);
        }
        private void removeQueen(int x, int y)
        {

            Spaces[x, y].Tag = "empty";
            Spaces[x, y].Text = "" + (x) + "," + (y) + "";
            removeLastQueen();
            queen--;

        }
        #endregion
    }
}
