using System;
using System.Drawing;
using System.Windows.Forms;

namespace s3lab_tpl_csharp_app
{
    class CaroBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        #endregion

        #region Initialize
        public CaroBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constant.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Constant.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constant.CHESS_WIDTH,
                        Height = Constant.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Constant.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text != null && btn.Text != "")
            {
                return;
            }

            Mark(btn);
        }

        private void Mark(Button btn)
        {
            btn.Text = "0";
        }
        #endregion
    }
}

