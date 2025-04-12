using Microsoft.VisualBasic;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Cryptography;
using System.Media; 

namespace TileShift
{
    public partial class TileShift : Form
    {
        int interval = 0;
        int iCount;
        public void ApplyColours(int iColours)
        {
            switch (iColours)
            {
                case 0:
                    MBlock1.BackColor = Color.Yellow;
                    MBlock2.BackColor = Color.Fuchsia;
                    MBlock3.BackColor = Color.Purple;
                    MBlock4.BackColor = Color.White;
                    MBlock5.BackColor = Color.Orange;
                    MBlock6.BackColor = Color.Green;
                    MBlock7.BackColor = Color.Black;
                    MBlock8.BackColor = Color.Blue;
                    MBlock9.BackColor = Color.Red;

                    Block1.BackColor = Color.Red;
                    Block2.BackColor = Color.Blue;
                    Block3.BackColor = Color.Green;
                    Block4.BackColor = Color.Purple;
                    Block5.BackColor = Color.Fuchsia;
                    Block6.BackColor = Color.White;
                    Block7.BackColor = Color.Yellow;
                    Block8.BackColor = Color.Orange;
                    Block9.BackColor = Color.Black;
                    break;

                case 1:
                    MBlock1.BackColor = Color.Black;
                    MBlock2.BackColor = Color.Blue;
                    MBlock3.BackColor = Color.Red;
                    MBlock4.BackColor = Color.Purple;
                    MBlock5.BackColor = Color.Green;
                    MBlock6.BackColor = Color.Fuchsia;
                    MBlock7.BackColor = Color.Orange;
                    MBlock8.BackColor = Color.White;
                    MBlock9.BackColor = Color.Yellow;

                    Block1.BackColor = Color.Orange;
                    Block2.BackColor = Color.Red;
                    Block3.BackColor = Color.Green;
                    Block4.BackColor = Color.White;
                    Block5.BackColor = Color.Blue;
                    Block6.BackColor = Color.Purple;
                    Block7.BackColor = Color.Yellow;
                    Block8.BackColor = Color.Fuchsia;
                    Block9.BackColor = Color.Black;
                    break;
                case 2:
                    MBlock1.BackColor = Color.Orange;
                    MBlock2.BackColor = Color.Red;
                    MBlock3.BackColor = Color.Green;
                    MBlock4.BackColor = Color.White;
                    MBlock5.BackColor = Color.Blue;
                    MBlock6.BackColor = Color.Purple;
                    MBlock7.BackColor = Color.Yellow;
                    MBlock8.BackColor = Color.Black;
                    MBlock9.BackColor = Color.Fuchsia;

                    Block1.BackColor = Color.Yellow;
                    Block2.BackColor = Color.Red;
                    Block3.BackColor = Color.Blue;
                    Block4.BackColor = Color.Purple;
                    Block5.BackColor = Color.Green;
                    Block6.BackColor = Color.Fuchsia;
                    Block7.BackColor = Color.Orange;
                    Block8.BackColor = Color.White;
                    Block9.BackColor = Color.Black;
                    break;
                case 3:
                    MessageBox.Show("You win.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                    break;
            }
        }


        public bool MatchedColours()
        {
            bool r = false;
            if (iCount == 0)
            {
                if ((Block7.Left == 0 && Block7.Top == 0) &&
                    (Block5.Left == 150 && Block5.Top == 0) &&
                    (Block4.Left == 300 && Block4.Top == 0) &&
                    (Block6.Left == 0 && Block6.Top == 150) &&
                    (Block8.Left == 150 && Block8.Top == 150) &&
                    (Block3.Left == 300 && Block3.Top == 150) &&
                    (Block9.Left == 0 && Block9.Top == 300) &&
                    (Block2.Left == 150 && Block2.Top == 300) &&
                    (Block1.Left == 300 && Block1.Top == 300))
                    r = true;
            }
            else if (iCount == 1)
            {

                if ((Block9.Left == 0 && Block9.Top == 0) &&
                    (Block5.Left == 150 && Block5.Top == 0) &&
                    (Block2.Left == 300 && Block2.Top == 0) &&
                    (Block6.Left == 0 && Block6.Top == 150) &&
                    (Block3.Left == 150 && Block3.Top == 150) &&
                    (Block8.Left == 300 && Block8.Top == 150) &&
                    (Block1.Left == 0 && Block1.Top == 300) &&
                    (Block4.Left == 150 && Block4.Top == 300) &&
                    (Block7.Left == 300 && Block7.Top == 300))
                    r = true;
            }
            else if (iCount == 2)
            {
                if ((Block7.Left == 0 && Block7.Top == 0) &&
                    (Block2.Left == 150 && Block2.Top == 0) &&
                    (Block5.Left == 300 && Block5.Top == 0) &&
                    (Block8.Left == 0 && Block8.Top == 150) &&
                    (Block3.Left == 150 && Block3.Top == 150) &&
                    (Block4.Left == 300 && Block4.Top == 150) &&
                    (Block1.Left == 0 && Block1.Top == 300) &&
                    (Block9.Left == 150 && Block9.Top == 300) &&
                    (Block6.Left == 300 && Block6.Top == 300))
                    r = true;

            }
            return r;

        }
        public int MoveBlock(int iLeft, int iTop)
        {
            if (iLeft + 150 == Block9.Left && iTop == Block9.Top)
                return 1;
            if (iLeft == Block9.Left + 150 && iTop == Block9.Top)
                return 2;
            if (iTop + 150 == Block9.Top && iLeft == Block9.Left)
                return 3;
            if (iTop == Block9.Top + 150 && iLeft == Block9.Left)
                return 4;
            else
                return 0;

        }
        public void Reload()
        {
            iCount = 0;
            pnlPattern.Enabled = false;
            Block1.Left = 0;
            Block1.Top = 0;
            Block2.Left = 150;
            Block2.Top = 0;
            Block3.Left = 300;
            Block3.Top = 0;
            Block4.Left = 0;
            Block4.Top = 150;
            Block5.Left = 150;
            Block5.Top = 150;
            Block6.Left = 300;
            Block6.Top = 150;
            Block7.Left = 0;
            Block7.Top = 300;
            Block8.Left = 150;
            Block8.Top = 300;
            Block9.Left = 300;
            Block9.Top = 300;

            Block1.BackColor = Color.White;
            Block2.BackColor = Color.White;
            Block3.BackColor = Color.White;
            Block4.BackColor = Color.White;
            Block5.BackColor = Color.White;
            Block6.BackColor = Color.White;
            Block7.BackColor = Color.White;
            Block8.BackColor = Color.White;
            Block9.BackColor = Color.Black;

            MBlock1.BackColor = Color.White;
            MBlock2.BackColor = Color.White;
            MBlock3.BackColor = Color.White;
            MBlock4.BackColor = Color.White;
            MBlock5.BackColor = Color.White;
            MBlock6.BackColor = Color.White;
            MBlock7.BackColor = Color.White;
            MBlock8.BackColor = Color.White;
            MBlock9.BackColor = Color.Black;

            btnStart.Show();
            btnRestart.Hide();
            btnClick.Hide();

        }
        public TileShift()
        {
            InitializeComponent();
            tmrLoad.Enabled = true;
            pnlLoadScreen.Show();
            Reload();
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            interval++;

            if (interval >= 4)
            {
                tmrLoad.Enabled = false;

                pnlLoadScreen.Hide();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            ApplyColours(iCount);
            pnlPattern.Enabled = true;
            btnStart.Hide();
            btnRestart.Show();
            lblLabel.Text = "Pattern: 1";

        }

      

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
            lblLabel.Text = "Pattern: " + (iCount + 1).ToString();
            if (iCount == 0)
            {
                Block1.Left = 0;
                Block1.Top = 0;
                Block2.Left = 150;
                Block2.Top = 0;
                Block3.Left = 300;
                Block3.Top = 0;
                Block4.Left = 0;
                Block4.Top = 150;
                Block5.Left = 150;
                Block5.Top = 150;
                Block6.Left = 300;
                Block6.Top = 150;
                Block7.Left = 0;
                Block7.Top = 300;
                Block8.Left = 150;
                Block8.Top = 300;
                Block9.Left = 300;
                Block9.Top = 300;
            }
            else if (iCount == 1)
            {
                Block7.Left = 0;
                Block7.Top = 0;
                Block5.Left = 150;
                Block5.Top = 0;
                Block4.Left = 300;
                Block4.Top = 0;
                Block6.Left = 0;
                Block6.Top = 150;
                Block8.Left = 150;
                Block8.Top = 150;
                Block3.Left = 300;
                Block3.Top = 150;
                Block9.Left = 0;
                Block9.Top = 300;
                Block2.Left = 150;
                Block2.Top = 300;
                Block1.Left = 300;
                Block1.Top = 300;
            }
            else if (iCount == 2)
            {
                Block9.Left = 0;
                Block9.Top = 0;
                Block5.Left = 150;
                Block5.Top = 0;
                Block2.Left = 300;
                Block2.Top = 0;
                Block6.Left = 0;
                Block6.Top = 150;
                Block3.Left = 150;
                Block3.Top = 150;
                Block8.Left = 300;
                Block8.Top = 150;
                Block1.Left = 0;
                Block1.Top = 300;
                Block4.Left = 150;
                Block4.Top = 300;
                Block7.Left = 300;
                Block7.Top = 300;
            }

        }

        private void Block1_Click(object sender, EventArgs e)
        {
            if (MoveBlock(Block1.Left, Block1.Top) == 1)
            {

                Block1.Left = Block1.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block1.Left, Block1.Top) == 2)
            {
                Block1.Left = Block1.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block1.Left, Block1.Top) == 3)
            {
                Block1.Top = Block1.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block1.Left, Block1.Top) == 4)
            {
                Block1.Top = Block1.Top - 150;
                Block9.Top = Block9.Top + 150;
            }

        }

        private void Block2_Click(object sender, EventArgs e)
        {

            
            if (MoveBlock(Block2.Left, Block2.Top) == 1)
            {

                Block2.Left = Block2.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block2.Left, Block2.Top) == 2)
            {
                Block2.Left = Block2.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block2.Left, Block2.Top) == 3)
            {
                Block2.Top = Block2.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block2.Left, Block2.Top) == 4)
            {
                Block2.Top = Block2.Top - 150;
                Block9.Top = Block9.Top + 150;
            }
        }

        private void Block3_Click(object sender, EventArgs e)
        {
            
            if (MoveBlock(Block3.Left, Block3.Top) == 1)
            {

                Block3.Left = Block3.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block3.Left, Block3.Top) == 2)
            {
                Block3.Left = Block3.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block3.Left, Block3.Top) == 3)
            {
                Block3.Top = Block3.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block3.Left, Block3.Top) == 4)
            {
                Block3.Top = Block3.Top - 150;
                Block9.Top = Block9.Top + 150;
            }
        }

        private void Block4_Click(object sender, EventArgs e)
        {
            
            if (MoveBlock(Block4.Left, Block4.Top) == 1)
            {

                Block4.Left = Block4.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block4.Left, Block4.Top) == 2)
            {
                Block4.Left = Block4.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block4.Left, Block4.Top) == 3)
            {
                Block4.Top = Block4.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block4.Left, Block4.Top) == 4)
            {
                Block4.Top = Block4.Top - 150;
                Block9.Top = Block9.Top + 150;
            }
        }

        private void Block6_Click(object sender, EventArgs e)
        {
            
            if (MoveBlock(Block6.Left, Block6.Top) == 1)
            {

                Block6.Left = Block6.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block6.Left, Block6.Top) == 2)
            {
                Block6.Left = Block6.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block6.Left, Block6.Top) == 3)
            {
                Block6.Top = Block6.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block6.Left, Block6.Top) == 4)
            {
                Block6.Top = Block6.Top - 150;
                Block9.Top = Block9.Top + 150;
            }
        }

        private void Block5_Click(object sender, EventArgs e)
        {
            
            if (MoveBlock(Block5.Left, Block5.Top) == 1)
            {

                Block5.Left = Block5.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block5.Left, Block5.Top) == 2)
            {
                Block5.Left = Block5.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block5.Left, Block5.Top) == 3)
            {
                Block5.Top = Block5.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block5.Left, Block5.Top) == 4)
            {
                Block5.Top = Block5.Top - 150;
                Block9.Top = Block9.Top + 150;
            }
        }

        private void Block7_Click(object sender, EventArgs e)
        {
            
            if (MoveBlock(Block7.Left, Block7.Top) == 1)
            {

                Block7.Left = Block7.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block7.Left, Block7.Top) == 2)
            {
                Block7.Left = Block7.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block7.Left, Block7.Top) == 3)
            {
                Block7.Top = Block7.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block7.Left, Block7.Top) == 4)
            {
                Block7.Top = Block7.Top - 150;
                Block9.Top = Block9.Top + 150;
            }
        }

        private void Block8_Click(object sender, EventArgs e)
        {
            
            if (MoveBlock(Block8.Left, Block8.Top) == 1)
            {

                Block8.Left = Block8.Left + 150;
                Block9.Left = Block9.Left - 150;
            }
            else if (MoveBlock(Block8.Left, Block8.Top) == 2)
            {
                Block8.Left = Block8.Left - 150;
                Block9.Left = Block9.Left + 150;
            }
            else if (MoveBlock(Block8.Left, Block8.Top) == 3)
            {
                Block8.Top = Block8.Top + 150;
                Block9.Top = Block9.Top - 150;
            }
            else if (MoveBlock(Block8.Left, Block8.Top) == 4)
            {
                Block8.Top = Block8.Top - 150;
                Block9.Top = Block9.Top + 150;
            }
        }

        private void Block9_Click(object sender, EventArgs e)
        {
            if (MatchedColours())
            {
                if (btnClick.Visible == false)
                {
                    iCount++;
                    btnClick.Hide();
                }
            }
            else
            {
                if (btnClick.Visible == false)
                {
                    MessageBox.Show("Not a match ~\\('',)/~", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            
            ApplyColours(iCount);
            btnClick.Hide();
            lblLabel.Text = "Pattern: " + (iCount + 1).ToString();
            Block9.Enabled = true;

        }
    }
}
