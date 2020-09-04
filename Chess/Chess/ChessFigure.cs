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
    class ChessFigure
    {
        public static string[,] chessDesk = new string[8, 8]
        {         
            { "bRook", "bKnight", "bBishop", "bQueen", "bKing", "bBishop", "bKnight", "bRook" },
            { "bPawn", "bPawn", "bPawn", "bPawn", "bPawn", "bPawn", "bPawn", "bPawn" },
            { "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "" },
            { "wPawn", "wPawn", "wPawn", "wPawn", "wPawn", "wPawn", "wPawn", "wPawn" },
            { "wRook", "wKnight", "wBishop", "wQueen", "wKing", "wBishop", "wKnight", "wRook" }
        };

        public static Button btn1;
        public static Button btn2;
        public static int i1;
        public static int j1;
        public static int i2;
        public static int j2;

        public virtual void Move()
        {

        }

        public virtual bool Attack()
        {
            return false;
        }


    }
}
