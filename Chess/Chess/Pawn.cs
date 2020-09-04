using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    class Pawn : ChessFigure
    {
        public override void Move()
        {
            if (i1 == 6)
            {
                if (i2 == i1 - 2)
                {
                    chessDesk[i1, j1] = "";
                    chessDesk[i2, j2] = "wPawn";
                }

                if (i2 == i1 - 1)
                {
                    chessDesk[i1, j1] = "";
                    chessDesk[i2, j2] = "wPawn";
                }
            }
            else
            {
                if(i2 == i1 - 1)
                {
                    chessDesk[i1, j1] = "";
                    chessDesk[i2, j2] = "wPawn";
                }
            }
        }

        public override bool Attack()
        {
            return base.Attack();
        }
    }
}
