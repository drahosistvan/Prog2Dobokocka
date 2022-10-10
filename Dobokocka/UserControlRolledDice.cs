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
    public partial class UserControlRolledDice : UserControl
    {
        private int dieceValue;
        List<Image> images = new List<Image> {
            Properties.Resources.dice_1,
            Properties.Resources.dice_2,
            Properties.Resources.dice_3,
            Properties.Resources.dice_4,
            Properties.Resources.dice_5,
            Properties.Resources.dice_6,
        };

        public UserControlRolledDice(int dieceValue)
        {
            InitializeComponent();

            this.dieceValue = dieceValue;
        }

        private void UserControlRolledDice_Load(object sender, EventArgs e)
        {
            labelRolledDiceValue.Text = dieceValue.ToString();
            pictureBoxDiece.Image = images[dieceValue-1];
        }
    }
}
