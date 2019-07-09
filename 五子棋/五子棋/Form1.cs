using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 五子棋
{
    public partial class Form1 : Form
    {
        private Game game = new Game();
        private Board board = new Board();
        int Range = 15; //判定是否在交叉點的範圍


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Piece piece = game.PlaceAPiece(e.X, e.Y );

            if (piece != null)
            {
                this.Controls.Add(piece);
                if(game.Winner==PieceType.BLACK)
                {
                    MessageBox.Show("黑色獲勝");
                    game.Reset();
                    this.Controls.Clear();
                    this.Controls.Add(ResetButton);
                    
                }
                if(game.Winner==PieceType.WHITE)
                {
                    MessageBox.Show("白色獲勝");
                    game.Reset();
                    this.Controls.Clear();
                    this.Controls.Add(ResetButton);
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                MessageBox.Show("Hello");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int Xvalue, Yvalue;//檢查X-X_crosspoint*75的值
            int X,Y; //XY座標
            int X_crosspoint , Y_crosspoint; //左方上方最近交叉點

            // 檢查現在XY軸座標位置
            X = e.Location.X; 
            Y = e.Location.Y;
            X_axis.Text = "" + X;
            Y_axis.Text = "" + Y;

            //檢查X與最近交叉點的差值
            Xvalue = X - (X/75) * 75;
            Yvalue = Y - (Y/75) * 75;
            X_Value.Text = "" + Xvalue;

            //XY交叉點
            if ( Xvalue >= 75 - Range  || Yvalue>=75-Range)
            {
                X_crosspoint = (X + Range) / 75;
                Y_crosspoint = (Y + Range) / 75;
            }
            else
            {
                X_crosspoint = X / 75;
                Y_crosspoint = Y / 75;
            }
            X_CrossPoint.Text = "" + X_crosspoint;
            Y_CrossPoint.Text = "" + Y_crosspoint;

            //是在交叉點上的畫圖式變化為手手
            if (game.CanBePlaced(e.X,e.Y))
            {
                this.Cursor = Cursors.Hand;       
            }
            else
            {
                this.Cursor = Cursors.Default;              
            }
            

            /*
            int Abs_X_positiin = Math.Abs(X - X_crosspoint * 75);
            int Abs_Y_positiin = Math.Abs(Y - Y_crosspoint * 75);

            if (Abs_X_positiin <= Range   &&  Abs_Y_positiin <= Range ) IsInRange = true;
            else IsInRange = false;
            */
        }

      
        //清空所有棋子並且重開一局
        private void ResetButton_Click(object sender, EventArgs e)
        {
            game.Reset();

            foreach (object item in this.Controls)
                   if (item is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)item;
                    pictureBox.Image =null ;
                }

            Controls.Clear();
            Controls.Add(ResetButton);
        }
    }
}
