using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 五子棋
{
    class Game
    {
        private Board board = new Board();
        private PieceType CurrentPlayer = PieceType.BLACK;
        private PieceType winner = PieceType.NONE;

        public PieceType Winner { get { return winner; } }

        public bool CanBePlaced(int x,int y)
        {
            return board.CanBePlaced(x, y);
        }

        public Piece PlaceAPiece(int x,int y)
        {
            Piece piece = board.PlaceAPiece(x,y, CurrentPlayer);
            //檢查是否現在下棋的人勝利
            CheckWinner();

            //交換選手
            if (piece != null)
            {
                if (CurrentPlayer == PieceType.BLACK)
                    CurrentPlayer = PieceType.WHITE;
                else if (CurrentPlayer == PieceType.WHITE)
                    CurrentPlayer = PieceType.BLACK;
                return piece;
            }
            return null;
        }


        
        private void CheckWinner()
        {
            int targetX = 0;
            int targetY = 0;
            int centerX = board.LastPlaceNode.X;
            int centerY = board.LastPlaceNode.Y;

            //檢查八個不同的方向
            for (int DirX = -1; DirX <= 1; DirX++)
            {
                for (int DirY = -1; DirY <= 1; DirY++)
                {

                    if (DirX == 0 && DirY == 0)
                        continue;
                    int TheOtherCount = 1;
                    int count = 1;
                    //紀錄現在看到幾顆相同的棋子
                    while (count+TheOtherCount < 6)
                    {
                         targetX = centerX + count * DirX;
                         targetY = centerY + count * DirY; 
                        
                        if (targetX < 0 || targetX >= Board.NODE_COUNT ||
                            targetY < 0 || targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != CurrentPlayer)
                            break;

                        count++;
                    }

                    //判斷另一方向的棋子數
                    while(count+TheOtherCount  < 6)
                    {
                        targetX = centerX - TheOtherCount * DirX;
                        targetY = centerY - TheOtherCount * DirY;

                        if (targetX < 0 || targetX >= Board.NODE_COUNT ||
                            targetY < 0 || targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != CurrentPlayer)
                            break;

                        TheOtherCount++;
                    }

                    if (count+TheOtherCount == 6)
                    {
                        winner = CurrentPlayer;
                    }
                }
            }
        }

        //將贏家設為沒有贏家 並且清空存放棋子的矩陣
        public void Reset()
        {
            winner = PieceType.NONE;
            board.CleanPiece();
            CurrentPlayer = PieceType.BLACK;
        }
    }
}
