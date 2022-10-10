using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobokocka
{
    public partial class Form1 : Form
    {
        int hanyszor;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            flowLayoutPanelRolledDiece.Controls.Clear();

            hanyszor = int.Parse(numericUpDownNumberOfThrows.Value.ToString());

            for(int i=0; i<hanyszor; i++)
            {
                flowLayoutPanelRolledDiece.Controls.Add(
                new UserControlRolledDice(new Diece().roll())
            );
            }
        }
    }
}
