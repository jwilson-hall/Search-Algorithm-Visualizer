using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Algorithms
{
    public partial class Main : Form
    {
        //--------------------Variables--------------------------------
        bool start = false, endGoal = false, walls = false;
        Brush activeBrush = null;
        String strActiveBrush = null;
        int milli_seconds, x, y;
        static int gridSize = 5;
        int[,] grid_Array = new int[gridSize, gridSize];
        //-------------------------------------------------------------
        //----------------------------Main-----------------------------
        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            gridSize = Convert.ToInt32(updown_numCols.Value);
        }
        private void Program_Timer_Tick(object sender, EventArgs e)
        {
            milli_seconds += 1;
            //Point relativePoint = Control.MousePosition;
            Point relativePoint = pnl_Grid.PointToClient(Cursor.Position);
            mouseDrawing(relativePoint);
        }
        private void pnl_Grid_MouseUp(object sender, MouseEventArgs e)
        {
            Program_Timer.Stop();
        }
        private void pnl_Grid_MouseDown(object sender, MouseEventArgs e)
        {
            Program_Timer.Start();
            
        }
        //--------------------------------------------------------------

        //-----------------------Panel--------------------------------
        private void pnl_Grid_Paint(object sender, PaintEventArgs e)
        {
            if (milli_seconds < 2)
            {
                Paint_Layout(Convert.ToInt32(updown_numCols.Value));
                Program_Timer.Stop();
            }
        }

        private void pnl_Grid_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            Paint_Layout(Convert.ToInt32(updown_numCols.Value));
            
        }
        //------------------------------------------------------------


        
        private void updown_numCols_ValueChanged(object sender, EventArgs e)
        {
            gridSize = Convert.ToInt32(updown_numCols.Value);
            resetValues();
            Paint_Layout(gridSize);
        }
        
        //--------------------Functions----------------------------
        private void Paint_Layout(int numberOfCols)
        {
            var g = pnl_Grid.CreateGraphics();
            g.Clear(pnl_Grid.BackColor);
            int numOfCells = numberOfCols;
            int cellSize = pnl_Grid.Width / numOfCells;
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            float y = 0f, x = 0f;
            float xSpace = pnl_Grid.Width / numOfCells;
            float ySpace = pnl_Grid.Height / numOfCells;
            //verticle lines
            for (int i = 0; i < numOfCells+1; i++)
            {
                g.DrawLine(pen, x, y, x, pnl_Grid.Height-1);
                x += xSpace;
            }
            //horizontal lines
            x = 0f;
            for (int i = 0; i < numOfCells+1; i++)
            {
                g.DrawLine(pen, x, y, pnl_Grid.Width-1, y);
                y += ySpace;
            }
            drawStartEnd(grid_Array);
        }
        private void removePath(int[,] grid)
        {
            Graphics g = pnl_Grid.CreateGraphics();
            int rowLength = grid.GetLength(0);
            int colLength = grid.GetLength(1);
            Brush brush = new SolidBrush(Color.White);
            for (int i = 0; i < rowLength; i++)
            {

                for (int j = 0; j < colLength; j++)
                {
                    int y = i;
                    int x = j;
                    float xSpace = pnl_Grid.Width / Convert.ToInt32(updown_numCols.Value);
                    float ySpace = pnl_Grid.Height / Convert.ToInt32(updown_numCols.Value);
                    int gridX = (int)(x * xSpace);
                    int gridY = (int)(y * ySpace);

                    if (grid[i, j] == 0)
                    {
                        brush = new SolidBrush(Color.White);
                    }
                    else if (grid[i, j] == 1)
                    {
                        brush = new SolidBrush(Color.DarkGray);
                    }
                    else if (grid[i, j] == 2)
                    {
                        brush = new SolidBrush(Color.DodgerBlue);
                    }
                    else if (grid[i, j] == 3)
                    {
                        brush = new SolidBrush(Color.Firebrick);
                    }
                    else if (grid[i, j] == 5)
                    {
                        brush = new SolidBrush(Color.White);
                        grid[i, j] = 0;
                    }
                    g.FillRectangle(brush, new Rectangle(gridX + 1, gridY + 1, Convert.ToInt32(xSpace) - 1, Convert.ToInt32(ySpace) - 1));
                }
            }
        }
        private void drawStartEnd(int [,] grid)
        {
            Graphics g = pnl_Grid.CreateGraphics();
            int rowLength = grid.GetLength(0);
            int colLength = grid.GetLength(1);
            Brush brush = new SolidBrush(Color.White);
            for (int i = 0; i < rowLength; i++)
            {

                for (int j = 0; j < colLength; j++)
                {
                    int y = i;
                    int x = j;
                    float xSpace = pnl_Grid.Width / Convert.ToInt32(updown_numCols.Value);
                    float ySpace = pnl_Grid.Height / Convert.ToInt32(updown_numCols.Value);
                    int gridX = (int)(x * xSpace);
                    int gridY = (int)(y * ySpace);

                    if (grid[i,j] == 0)
                    {
                        brush = new SolidBrush(Color.White);
                    }
                    else if (grid[i, j] == 1)
                    {
                        brush = new SolidBrush(Color.DarkGray);
                    }
                    else if (grid[i, j] == 2)
                    {
                        brush = new SolidBrush(Color.DodgerBlue);
                    }
                    else if (grid[i, j] == 3)
                    {
                        brush = new SolidBrush(Color.Firebrick);
                    }
                    else if (grid[i, j] == 5)
                    {
                        brush = new SolidBrush(Color.Purple);
                    }
                    g.FillRectangle(brush, new Rectangle(gridX + 1, gridY + 1, Convert.ToInt32(xSpace) - 1, Convert.ToInt32(ySpace) - 1));
                }
            }
        }
        private void Draw_Path(int[,] path)
        {
            var g = pnl_Grid.CreateGraphics();
            int rowLength = path.GetLength(0);
            int colLength = path.GetLength(1);
            Brush brush = new SolidBrush(Color.Purple);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (path[j,i] == 5)
                    {
                        int x = i;
                        int y = j;
                        float xSpace = pnl_Grid.Width / Convert.ToInt32(updown_numCols.Value);
                        float ySpace = pnl_Grid.Height / Convert.ToInt32(updown_numCols.Value);
                        int gridX = (int)(x * xSpace);
                        int gridY = (int)(y * ySpace);
                        g.FillRectangle(brush, new Rectangle(gridX + 1, gridY + 1, Convert.ToInt32(xSpace) - 1, Convert.ToInt32(ySpace) - 1));
                    }
                }
            }
        }
        private void printstats()
        {
            Console.WriteLine("BOOLs: start " + start + " end " + endGoal);
            Console.WriteLine(activeBrush);
        }
        private void resetValues()
        {
            start = false;
            endGoal = false;
            gridSize = Convert.ToInt32(updown_numCols.Value);
            grid_Array = new int[gridSize, gridSize];
        }
        //--------------------------------------------------------
        //--------------------Buttons----------------------------
        private void btn_remove_Click(object sender, EventArgs e)
        {
            activeBrush = new SolidBrush(Color.White);
            strActiveBrush = "remove";
            lbl_ActiveBrush.Text = "Active Brush: " + strActiveBrush;
        }
        private void btn_wall_Click(object sender, EventArgs e)
        {
            if (walls != true)
            {
                activeBrush = new SolidBrush(Color.DarkGray);
                strActiveBrush = "wall";
                lbl_ActiveBrush.Text = "Active Brush: " + strActiveBrush;
            }
        }

        private void btn_Start_Algo_Click(object sender, EventArgs e)
        {
            removePath(grid_Array);
            Search s = new Search();
            int[,] path = s.AStar(grid_Array);
            if (path != null)
            {
                Draw_Path(path);

            }
            else
            {
                MessageBox.Show("Path does not exist! ");
            }
        }

        private void btn_remove_path_Click(object sender, EventArgs e)
        {
            removePath(grid_Array);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetValues();
            drawStartEnd(grid_Array);
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            drawStartEnd(grid_Array);
            Paint_Layout(gridSize);
        }

        

        private void btn_start_location_Click(object sender, EventArgs e)
        {
            //printstats();
            if (start != true)
            {
                activeBrush = new SolidBrush(Color.DodgerBlue);
                strActiveBrush = "start";
                lbl_ActiveBrush.Text = "Active Brush: " + strActiveBrush;
            }
        }
        private void btn_end_location_Click(object sender, EventArgs e)
        {
            //printstats();
            if (endGoal != true)
            {
                activeBrush = new SolidBrush(Color.Firebrick);
                strActiveBrush = "end";
                lbl_ActiveBrush.Text = "Active Brush: " + strActiveBrush;
            }
        }
        //--------------------------------------------------------

        ////--------------------Mouse----------------------------
        private void pnl_Grid_MouseClick(object sender, MouseEventArgs e)
        {
            //printstats();
            mouseDrawing(e.Location);
            
        }
        private void mouseDrawing(Point e)
        {
            if (activeBrush != null)
            {
                Point p = new Point(e.X, e.Y);
                x = p.X;
                y = p.Y;
                x /= pnl_Grid.Width / Convert.ToInt32(updown_numCols.Value);
                y /= pnl_Grid.Height / Convert.ToInt32(updown_numCols.Value);
                Brush brush = activeBrush;
                Pen pen = new Pen(brush, 5);
                float xSpace = pnl_Grid.Width / Convert.ToInt32(updown_numCols.Value);
                float ySpace = pnl_Grid.Height / Convert.ToInt32(updown_numCols.Value);
                var g = pnl_Grid.CreateGraphics();
                int gridX = (int)(x * xSpace);
                int gridY = (int)(y * ySpace);

                try
                {
                    //Console.WriteLine("X: " + gridX + " Y: " + gridY);

                    if (strActiveBrush == "start")
                    {

                        if (grid_Array[y, x] == 3)
                        {
                            endGoal = false;
                        }
                        grid_Array[y, x] = 2;
                        start = true;
                        activeBrush = null;
                        lbl_ActiveBrush.Text = "Active Brush: " + "null";
                    }
                    else if (strActiveBrush == "end")
                    {
                        if (grid_Array[y, x] == 2)
                        {
                            start = false;
                        }
                        grid_Array[y, x] = 3;
                        endGoal = true;
                        activeBrush = null;
                        lbl_ActiveBrush.Text = "Active Brush: " + "null";
                    }
                    else if (strActiveBrush == "wall")
                    {
                        if (grid_Array[y, x] == 2)
                        {
                            start = false;
                        }
                        else if (grid_Array[y, x] == 3)
                        {
                            endGoal = false;
                        }
                        grid_Array[y, x] = 1;
                    }
                    else if (strActiveBrush == "remove")
                    {
                        if (grid_Array[y, x] == 2)
                        {
                            start = false;
                        }
                        else if (grid_Array[y, x] == 3)
                        {
                            endGoal = false;
                        }
                        grid_Array[y, x] = 0;

                    }
                    g.FillRectangle(brush, new Rectangle(gridX + 1, gridY + 1, Convert.ToInt32(xSpace) - 1, Convert.ToInt32(ySpace) - 1));
                    int rowLength = grid_Array.GetLength(0);
                    int colLength = grid_Array.GetLength(1);

                    /*for (int i = 0; i < rowLength; i++)
                    {
                        for (int j = 0; j < colLength; j++)
                        {
                            Console.Write(string.Format("{0} ", grid_Array[i, j]));
                        }
                        Console.Write(Environment.NewLine + Environment.NewLine);
                    }*/
                }
                catch (IndexOutOfRangeException)
                {
                    //do nothing
                }

            }
        }

        //--------------------------------------------------------


    }
}
