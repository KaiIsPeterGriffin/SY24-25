using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Converter_thing
{
    public partial class Form1 : Form
    {
        int total = 0;
        int[] bits = new int[8];
        int[] bits2 = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            total = 0;
            if (bits[0] != 0)
                total += 1;
            //
            if (bits[1] != 0)
                total += 2;
            //
            if (bits[2] != 0)
                total += 4;
            //
            if (bits[3] != 0)
                total += 8;
            //
            if (bits[4] != 0)
                total += 16;
            //
            if (bits[5] != 0)
                total += 32;
            //
            if (bits[6] != 0)
                total += 64;
            //
            if (bits[7] != 0)
                total += 128;
            TotalLabel.Text = total.ToString();
        }
        private void Calculate()
        {
            total = 0;
            if (bits2[0] != 0)
                total += 1;
            //
            if (bits2[1] != 0)
                total += 2;
            //
            if (bits2[2] != 0)
                total += 4;
            //
            if (bits2[3] != 0)
                total += 8;
            //
            if (bits2[4] != 0)
                total += 16;
            //
            if (bits2[5] != 0)
                total += 32;
            //
            if (bits2[6] != 0)
                total += 64;
            //
            if (bits2[7] != 0)
                total += 128;
            TotalLabel2.Text = total.ToString();
        }
        private void Bit8_TextChanged(object sender, EventArgs e)
        {
            if (Bit1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;
            //
            if (Bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;
            //
            if (Bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;
            //
            if (Bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            //
            if (Bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;
            //
            if (Bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;
            //
            if (Bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;
            //
            if (Bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;
            Calc();
        }

        private void BitB8_TextChanged(object sender, EventArgs e)
        {
            {
                if (BitB1.Text == "1")
                    bits2[0] = 1;
                else
                    bits2[0] = 0;
                //
                if (BitB2.Text == "1")
                    bits2[1] = 1;
                else
                    bits2[1] = 0;
                //
                if (BitB3.Text == "1")
                    bits2[2] = 1;
                else
                    bits2[2] = 0;
                //
                if (BitB4.Text == "1")
                    bits2[3] = 1;
                else
                    bits2[3] = 0;
                //
                if (BitB5.Text == "1")
                    bits2[4] = 1;
                else
                    bits2[4] = 0;
                //
                if (BitB6.Text == "1")
                    bits2[5] = 1;
                else
                    bits2[5] = 0;
                //
                if (BitB7.Text == "1")
                    bits2[6] = 1;
                else
                    bits2[6] = 0;
                //
                if (BitB8.Text == "1")
                    bits2[7] = 1;
                else
                    bits2[7] = 0;
                Calculate();
            }
        }
    }
}
