using System;
using System.Drawing;
using System.Windows.Forms;

namespace Conway_s_Game_of_Life
{
    struct Cell
    {
        public int x;
        public int y;
        public bool filled;

        public Cell(int x = 0, int y = 0, bool filled = false)
        {
            this.x = x;
            this.y = y;
            this.filled = filled;
        }
    }

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private const int LINE_WIDTH = 1;
        private static int CELL_W = 8;
        private static int CELL_H = 8;
        private static int CELLS_X = 90;
        private static int CELLS_Y = 60;

        private readonly Color LINE_COLOR = Color.Black;
        private readonly Color CELL_COLOR = Color.Black;

        private Cell[,] cells = new Cell[CELLS_X, CELLS_Y];

        private bool edit = true;
        private int gen = 0;

        private void DrawCells()
        {
            Image game = pb_display.Image;

            using (Graphics g = Graphics.FromImage(game))
            {
                g.Clear(Color.White);

                for (int i = 0; i < CELLS_X; i++)
                    g.DrawLine(new Pen(LINE_COLOR, LINE_WIDTH), (CELL_W + LINE_WIDTH) * i, 0, (CELL_W + LINE_WIDTH) * i, pb_display.Height);

                for (int i = 0; i < CELLS_Y; i++)
                    g.DrawLine(new Pen(LINE_COLOR, LINE_WIDTH), 0, (CELL_H + LINE_WIDTH) * i, pb_display.Width, (CELL_H + LINE_WIDTH) * i);

                foreach (Cell cell in cells)
                    if (cell.filled)
                        g.FillRectangle(new SolidBrush(CELL_COLOR), cell.x, cell.y, CELL_W, CELL_H);
            }

            pb_display.Invalidate();
        }

        private int CalculateNeighbours(int x, int y, Cell[,] arr)
        {
            int n = 0;

            for (int i = x > 0 ? x - 1 : x; i < (x < CELLS_X - 1 ? x + 2 : x + 1); i++)
                for (int j = y > 0 ? y - 1 : y; j < (y < CELLS_Y - 1 ? y + 2 : y + 1); j++)
                    if (arr[i, j].filled)
                        n++;

            if (arr[x, y].filled)
                n--;

            return n;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < CELLS_X; i++)
                for (int j = 0; j < CELLS_Y; j++)
                    cells[i, j] = new Cell((CELL_W + LINE_WIDTH) * i + 1, (CELL_H + LINE_WIDTH) * j + 1);

            pb_display.Image = new Bitmap(pb_display.Width, pb_display.Height);

            DrawCells();

            btn_pause.Enabled = false;
            btn_edit.Enabled = false;
        }

        #region Buttons
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            btn_clear.BackColor = Color.Transparent;
            btn_pause.BackColor = Color.Transparent;
            btn_edit.BackColor = Color.Transparent;

            slider_size.Enabled = true;
            timer_main.Enabled = false;
            btn_pause.Enabled = false;
            btn_edit.Enabled = false;
            btn_start.Enabled = true;
            edit = true;

            for (int i = 0; i < CELLS_X; i++)
                for (int j = 0; j < CELLS_Y; j++)
                    cells[i, j].filled = false;

            gen = 0;
            lb_gen.Text = "Generation : " + gen;

            DrawCells();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            timer_main.Enabled = false;
            btn_edit.BackColor = Color.Transparent;
            edit = true;

            gen = 0;
            lb_gen.Text = "Generation : " + gen;

            slider_size.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            edit = false;
            timer_main.Enabled = true;
            btn_pause.Enabled = true;

            slider_size.Enabled = false;
            btn_start.Enabled = false;
        }

        private void Btn_pause_Click(object sender, EventArgs e)
        {
            timer_main.Enabled = false;
            slider_size.Enabled = true;
            btn_start.Enabled = true;
            btn_edit.Enabled = true;

            btn_clear.BackColor = Color.Transparent;
            btn_pause.BackColor = Color.Transparent;
            btn_edit.BackColor = Color.Transparent;

            btn_pause.Enabled = false;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Timer_main_Tick(object sender, EventArgs e)
        {
            Cell[,] copy = new Cell[CELLS_X, CELLS_Y];

            for (int i = 0; i < CELLS_X; i++)
                for (int j = 0; j < CELLS_Y; j++)
                    copy[i, j] = cells[i, j];

            for (int i = 0; i < CELLS_X; i++)
            {
                for (int j = 0; j < CELLS_Y; j++)
                {
                    int neightbours = CalculateNeighbours(i, j, copy);

                    if (neightbours == 3)
                        cells[i, j].filled = true;
                    else if (neightbours < 2 || neightbours > 3)
                        cells[i, j].filled = false;
                }
            }

            lb_gen.Text = "Generation : " + ++gen;

            DrawCells();
        }

        #region DisplayEvents
        private int mouseX = 0;
        private int mouseY = 0;
        private bool mouseDown = false;
        private Point lastCell = new Point(-1, -1);

        private void Pb_display_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                int x = mouseX / (CELL_W + LINE_WIDTH);
                int y = mouseY / (CELL_H + LINE_WIDTH);

                if (x >= 0 && y >= 0 && x < CELLS_X && y < CELLS_Y)
                    cells[x, y].filled = !cells[x, y].filled;

                DrawCells();
            }
            else
                btn_edit.BackColor = Color.LightGreen;
        }

        private void Pb_display_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Pb_display_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Pb_display_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;

            if (mouseDown)
            {
                if (edit)
                {
                    int x = e.X / (CELL_W + LINE_WIDTH);
                    int y = e.Y / (CELL_H + LINE_WIDTH);

                    Point currentCell = new Point(x, y);

                    if (x >= 0 && y >= 0 && x < CELLS_X && y < CELLS_Y && lastCell != currentCell)
                    {
                        cells[x, y].filled = !cells[x, y].filled;
                        lastCell = currentCell;
                    }

                    DrawCells();
                }
                else
                    btn_edit.BackColor = Color.LightGreen;
            }
        }
        #endregion

        private void Slider_speed_Scroll(object sender, EventArgs e)
        {
            timer_main.Interval = 1000 / slider_speed.Value;
            lb_speed.Text = "Speed\n" + slider_speed.Value.ToString();
        }

        private void Slider_size_Scroll(object sender, EventArgs e)
        {
            if (timer_main.Enabled == false)
            {
                Cell[,] oldCells = new Cell[CELLS_X, CELLS_Y];

                for (int i = 0; i < CELLS_X; i++)
                    for (int j = 0; j < CELLS_Y; j++)
                        oldCells[i, j] = cells[i, j];

                CELLS_X = slider_size.Value;
                CELLS_Y = Convert.ToInt32(slider_size.Value / 1.5f);

                CELL_W = (pb_display.Width + (CELLS_X - 1)) / CELLS_X;
                CELL_H = (pb_display.Height + (CELLS_Y - 1)) / CELLS_Y;

                cells = new Cell[CELLS_X, CELLS_Y];

                for (int i = 0; i < CELLS_X; i++)
                {
                    for (int j = 0; j < CELLS_Y; j++)
                    {
                        if (oldCells.GetLength(0) > i && oldCells.GetLength(1) > j)
                            cells[i, j] = new Cell((CELL_W + LINE_WIDTH) * i + 1, (CELL_H + LINE_WIDTH) * j + 1, oldCells[i, j].filled);
                        else
                            cells[i, j] = new Cell((CELL_W + LINE_WIDTH) * i + 1, (CELL_H + LINE_WIDTH) * j + 1);
                    }
                }

                lb_size.Text = "Size\n" + CELLS_X.ToString() + "x" + CELLS_Y.ToString();

                DrawCells();
            }
            else
            {
                btn_clear.BackColor = Color.LightGreen;
                btn_pause.BackColor = Color.LightGreen;
            }
        }

        private void lb_sizeCover_Click(object sender, EventArgs e)
        {
            if (slider_size.Enabled == false)
            {
                btn_clear.BackColor = Color.LightGreen;
                btn_pause.BackColor = Color.LightGreen;
            }
        }
    }
}