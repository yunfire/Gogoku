using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 五子棋
{
    class EmptyPiece :Piece
    {
        public EmptyPiece(int x, int y) : base(x, y)
        {
            this.Image = null;
        }

        public override PieceType GetPieceType()
        {
            return PieceType.NONE;
        }
    }
}
