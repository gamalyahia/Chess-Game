using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;

namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSource = new()
        {
           { PieceType.pawn , LoadImage("Assets/PawnW.png") },
           { PieceType.Bishop , LoadImage("Assets/BishopW.png") },
           { PieceType.Knight , LoadImage("Assets/KnightW.png") },
           { PieceType.Queen , LoadImage("Assets/QueenW.png") },
           { PieceType.Rook , LoadImage("Assets/RookW.png") },
           { PieceType.King , LoadImage("Assets/KingW.png") },
        };

        private static readonly Dictionary<PieceType, ImageSource> blackSource = new()
        {
           { PieceType.pawn , LoadImage("Assets/PawnB.png") },
           { PieceType.Bishop , LoadImage("Assets/BishopB.png") },
           { PieceType.Knight , LoadImage("Assets/KnightB.png") },
           { PieceType.Queen , LoadImage("Assets/QueenB.png") },
           { PieceType.Rook , LoadImage("Assets/RookB.png") },
           { PieceType.King , LoadImage("Assets/KingB.png") },
        };
        private static ImageSource LoadImage(String filePath)
        {
            return new BitmapImage(new Uri(filePath ,  UriKind.Relative));
        }
        public static ImageSource GetImage(Player color , PieceType type)
        {
            return color switch
            {
                Player.White => whiteSource[type],
                Player.Black => blackSource[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }

            return GetImage(piece.Color , piece.Type);
        }

    }
}
