using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MainForm : Form
    {
        private Button[,] cellGrid;
        private Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            cellGrid = new Button[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cellGrid[i, j] = new Button();
                    cellGrid[i, j].Text = "";
                    cellGrid[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    cellGrid[i, j].Margin = new System.Windows.Forms.Padding(0);
                    cellGrid[i, j].Size = new System.Drawing.Size(30, 30);
                    cellGrid[i, j].Click += new EventHandler(cellClick);
                    cellGrid[i, j].Image = global::Minesweeper.Properties.Resources.tile;
                    tableLayoutPanel.Controls.Add(cellGrid[i, j]);
                }
            }
            this.ActiveControl = playAgain;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int time = Int32.Parse(clock.Text) + 1;
            clock.Text = time.ToString();
        }

        private void playAgainClick(object sender, EventArgs e)
        {
            
        }

        private void cellClick(object sender, EventArgs e)
        {
            ((Button) sender).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ((Button)sender).Image = null;
            ((Button)sender).Text = "1";
            ((Button)sender).ForeColor = Color.Red;
        }
    }
}
