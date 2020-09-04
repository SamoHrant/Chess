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
    public partial class Form1 : Form
    {
        int z = 1;
        int x = 30;
        int y = 30;
        Button[,] arrButton = new Button[8, 8];
        int a = 1;
        string Name;
        /*int d = 0;
        Button btnF = null;
        Button btnS = null;*/
        public Form1()
        {
            InitializeComponent();

            GameStart();
        }

        public void GameStart()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button();
                    btn.Width = 75;
                    btn.Height = 75;
                    btn.BackColor = a % 2 != 0 ? Color.White : Color.Black;
                    btn.Name = $"{ChessFigure.chessDesk[i, j]}{i}{j}";
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.Location = new Point(x, y);

                    /*if (i == 7 && j == 4)
                    {
                        btn.BackgroundImage = Properties.Resources.sKing;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }*/

                    switch (ChessFigure.chessDesk[i, j])
                    {
                        case "wKing":
                            btn.BackgroundImage = Properties.Resources.wKing;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wRook":
                            btn.BackgroundImage = Properties.Resources.wRook;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wKnight":
                            btn.BackgroundImage = Properties.Resources.wKnight;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wBishop":
                            btn.BackgroundImage = Properties.Resources.wBishop;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wQueen":
                            btn.BackgroundImage = Properties.Resources.wQueen;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bRook":
                            btn.BackgroundImage = Properties.Resources.bRook;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bKnight":
                            btn.BackgroundImage = Properties.Resources.bKnight;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bBishop":
                            btn.BackgroundImage = Properties.Resources.bBishop;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bKing":
                            btn.BackgroundImage = Properties.Resources.bKing;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bQueen":
                            btn.BackgroundImage = Properties.Resources.bQueen;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wPawn":
                            btn.BackgroundImage = Properties.Resources.wPawn;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bPawn":
                            btn.BackgroundImage = Properties.Resources.bPawn;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;


                    }

                    /*if (i == 1)
                    {
                        btn.BackgroundImage = Properties.Resources.bPawn;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    if (i == 6)
                    {
                        btn.BackgroundImage = Properties.Resources.wPawn;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }*/
                    a++;
                    Controls.Add(btn);
                    arrButton[i, j] = btn;
                    x += 75;

                    btn.MouseClick += Btn_MouseClick;
                    btn.MouseDown += Btn_MouseDown;
                }

                a = i % 2 == 0 ? 0 : 1;
                y += 75;
                x = 30;
            }
        }

        public void GameUpdate()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    arrButton[i, j].BackgroundImage = null;

                    /*if (i == 7 && j == 4)
                    {
                        btn.BackgroundImage = Properties.Resources.sKing;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }*/




                }

                /*if (i == 1)
                {
                    btn.BackgroundImage = Properties.Resources.bPawn;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }

                if (i == 6)
                {
                    btn.BackgroundImage = Properties.Resources.wPawn;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }*/
            }


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (ChessFigure.chessDesk[i, j])
                    {
                        case "wKing":
                            arrButton[i, j].BackgroundImage = Properties.Resources.wKing;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wRook":
                            arrButton[i, j].BackgroundImage = Properties.Resources.wRook;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wKnight":
                            arrButton[i, j].BackgroundImage = Properties.Resources.wKnight;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wBishop":
                            arrButton[i, j].BackgroundImage = Properties.Resources.wBishop;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wQueen":
                            arrButton[i, j].BackgroundImage = Properties.Resources.wQueen;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bRook":
                            arrButton[i, j].BackgroundImage = Properties.Resources.bRook;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bKnight":
                            arrButton[i, j].BackgroundImage = Properties.Resources.bKnight;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bBishop":
                            arrButton[i, j].BackgroundImage = Properties.Resources.bBishop;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bKing":
                            arrButton[i, j].BackgroundImage = Properties.Resources.bKing;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bQueen":
                            arrButton[i, j].BackgroundImage = Properties.Resources.bQueen;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "wPawn":
                            arrButton[i, j].BackgroundImage = Properties.Resources.wPawn;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "bPawn":
                            arrButton[i, j].BackgroundImage = Properties.Resources.bPawn;
                            arrButton[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            break;


                    }
                }

            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (btnF == null)
            {
                btnF = (Button)sender;
                btnF.FlatAppearance.BorderColor = Color.Green;              
            }
            else
            {
                d++;

                if (d == 1)
                {
                    btnS = (Button)sender;
                    btnF.FlatAppearance.BorderColor = Color.Black;
                    btnS.FlatAppearance.BorderColor = Color.Green;
                }
                else
                {
                    btnS = (Button)sender;
                    btnS.FlatAppearance.BorderColor = Color.Black;
                    btn.FlatAppearance.BorderColor = Color.Green;
                }
            }*/
        }

        public virtual void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (z == 1)
            {
                Button btn4 = (Button)sender;
                MessageBox.Show(btn4.Name);
                ChessFigure.btn1 = (Button)sender;
                Name = ChessFigure.btn1.Name;
                ChessFigure.i1 = ChessFigure.btn1.Name[ChessFigure.btn1.Name.Length - 2] - 48;
                ChessFigure.j1 = ChessFigure.btn1.Name[ChessFigure.btn1.Name.Length - 1] - 48;
                char[] arr = ChessFigure.btn1.Name.ToCharArray();

                btn4.Name = $"{btn4.Name[ChessFigure.btn1.Name.Length - 2] - 48}{btn4.Name[ChessFigure.btn1.Name.Length - 1] - 48} ";


                ChessFigure.btn1.Name = "";


                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != arr.Length - 1 && i != arr.Length - 2)
                    {
                        ChessFigure.btn1.Name += arr[i].ToString();
                    }
                }

                z++;
            }
            else
            {
                ChessFigure.btn2 = (Button)sender;

                MessageBox.Show(ChessFigure.btn2.Name);

                ChessFigure.i2 = ChessFigure.btn2.Name[0] - 48;
                ChessFigure.j2 = ChessFigure.btn2.Name[1] - 48;

                switch (ChessFigure.btn1.Name)
                {
                    case "wPawn":
                        Pawn p = new Pawn();
                        p.Move();
                        GameUpdate();
                        ChessFigure.btn1.Name = Name;
                        break;
                }

                z = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
