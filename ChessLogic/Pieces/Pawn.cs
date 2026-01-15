namespace ChessLogic
{
    public class Pawn : Piece
    {
        public override PieceType Type => PieceType.pawn;

        public override Player Color { get; }

        public Pawn(Player color) 
        {
            Color = color;
        }

        public override Piece copy()
        {
            Pawn copy = new Pawn(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
