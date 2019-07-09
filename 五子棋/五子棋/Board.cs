using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace 五子棋
{
    class Board
    {
        public static readonly int NODE_COUNT = 9;      //設定旗子邊界為9
        private static readonly Point NO_MATCH_POINT = new Point(-1, -1);  //當沒有在旗子座標內的時候位址設定為(-1,-1)


        private Point lastPlaceNode = NO_MATCH_POINT;  //旗子最後放的地方
        public Point LastPlaceNode { get { return lastPlaceNode; } } //外界可存取最後放下旗子的地方


        private static readonly int  OFFSET = 75; //棋盤最外圍邊界
        private static readonly int NODE_RADIUS = 10; //交叉點判定位址
        private static readonly int NODE_DISTANCE=75; //每隔之間的距離
        public Piece[,] pieces = new Piece [NODE_COUNT, NODE_COUNT];  //

        public PieceType GetPieceType(int NodeIdX, int NodeIdY)
        {
            if (pieces[NodeIdX, NodeIdY] == null)
                return PieceType.NONE;
            return pieces[NodeIdX, NodeIdY].GetPieceType();
        }

        public bool CanBePlaced(int x, int y)
        {
            //TODO:找出最近的節點(Node)
            Point NODE_ID = FindTheClosetNode(x, y);

            //TODO:如果沒有的話回傳false
            if (NODE_ID == NO_MATCH_POINT)
                return false;

            //TODO:如果有的的話,檢查是否已經有旗子存在
            if (pieces[NODE_ID.X, NODE_ID.Y] != null)
                return false;

            return true;

        }

        public Piece PlaceAPiece(int x, int y, PieceType Type)
        {
            //TODO:找出最近的節點(Node)
            Point NODE_ID = FindTheClosetNode(x, y);

            //TODO:如果沒有的話回傳false
            if (NODE_ID == NO_MATCH_POINT)
                return null;

            //TODO:如果有的的話,檢查是否已經有棋子存在
            if (pieces[NODE_ID.X, NODE_ID.Y] != null)
                return null;
            //根據Type 產生對應的旗子
            Point formPos = convertToFormPosition(NODE_ID);

            if(Type == PieceType.BLACK)
            {
                pieces[NODE_ID.X, NODE_ID.Y] = new BlackPiece(formPos.X, formPos.Y);
            }
            else if(Type == PieceType.WHITE)
            {
                pieces[NODE_ID.X, NODE_ID.Y] = new WhitePiece(formPos.X, formPos.Y);
            }

            lastPlaceNode = NODE_ID;

            return pieces[NODE_ID.X, NODE_ID.Y];
        }

        private Point convertToFormPosition(Point nodeID)
        {
            Point formPosition = new Point();
            formPosition.X = nodeID.X * NODE_DISTANCE + OFFSET;
            formPosition.Y = nodeID.Y * NODE_DISTANCE + OFFSET;
            return formPosition;
        }

        private Point FindTheClosetNode(int x,int y) //判斷二維判斷式
        {
            int nodeIdX = FindTheClosetNode(x);
            if (nodeIdX == -1||nodeIdX>= NODE_COUNT)
                return NO_MATCH_POINT;

            int nodeIdY = FindTheClosetNode(y);
            if (nodeIdY == -1 || nodeIdX>= NODE_COUNT)
                return NO_MATCH_POINT;

            return new Point(nodeIdX, nodeIdY);
        }

        private int FindTheClosetNode(int pos) //判斷一維判斷式
        {
            if (pos <= OFFSET - NODE_RADIUS)
                return -1;
            pos -= OFFSET;
            
            int quotient = pos / NODE_DISTANCE;
            int remainder = pos % NODE_DISTANCE;

            if (remainder <= NODE_RADIUS) return quotient;
            else if (remainder >= NODE_DISTANCE - NODE_RADIUS) return quotient + 1;
            else return -1;
        }

        //清空存放棋子的矩陣內容 ,修改測試github同步功能
        public void CleanPiece()
        {
           /* for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    pieces[i, j] = null;
                }
            }
            */
             Array.Clear(pieces, 0, 81);
        }
        
    }
}
