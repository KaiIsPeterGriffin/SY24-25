using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Button[] btn = new Button[2];
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        public Form1()
        {
            InitializeComponent();
            
            for(int i=0; i<100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i+1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                btnGrid[i].BackColor= Color.Green;
            }
        }
        private Button getButton(int r, int c)
        {
            return (Button)getButton(r, c);
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }

        private void button101_Click(object sender, EventArgs e)
        {

        }

        private void button81_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor= Color.Red;
        }
    }
}
