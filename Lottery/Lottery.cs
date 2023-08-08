using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Lottery : Form
    {
        private LotteryClass _lottery;

        public Lottery()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int maxValue = int.Parse(txtboxmaxvalue.Text);
            int wantedNumbers = int.Parse(txtboxwantednumber.Text);
            _lottery = new LotteryClass(maxValue, wantedNumbers);

            btndraw.Enabled = true;
            btndrawatones.Enabled = true;
        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            if (_lottery != null && !_lottery.IsLotteryFinished())
            {
                int nextNumber = _lottery.DrawNextNumber();
                listBox1.Items.Add(nextNumber);
            }
        }

        private void btndrawatones_Click(object sender, EventArgs e)
        {
            if (_lottery != null)
            {
                int[] allNumbers = _lottery.DrawAllNumbers();
                listBox1.Items.Clear();
                foreach (int number in allNumbers)
                {
                    listBox1.Items.Add(number);
                }
            }
        }

        private void Lottery_Load(object sender, EventArgs e)
        {
            btndraw.Enabled = false;
            btndrawatones.Enabled = false;
        }

 
    }

    
}
