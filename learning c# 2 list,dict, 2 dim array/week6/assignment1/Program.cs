using System;
using System.IO;

namespace assignment1
{
    class Program
    {
        const int SIZE = 8;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            ChessPiece[,] chessboard = new ChessPiece[SIZE, SIZE];
            InitChessboard(chessboard);
            DisplayChessboard(chessboard);
            PlayChess(chessboard);

        }

        void InitChessboard(ChessPiece[,] chessboard)
        {

            for (int nrOfRows = 0; nrOfRows < chessboard.GetLength(0); nrOfRows++)
            {
                for (int nrOfColumns = 0; nrOfColumns < chessboard.GetLength(1); nrOfColumns++)
                {
                    chessboard[nrOfRows, nrOfColumns] = null;

                }
            }
            PutChessPieces(chessboard);
        }

        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            int count = 8;
            ChessPiece chesspiece = new ChessPiece();
            for (int nrOfRows = 0; nrOfRows < chessboard.GetLength(0); nrOfRows++)
            {
                Console.Write(count + " ");
                for (int nrOfColumns = 0; nrOfColumns < chessboard.GetLength(1); nrOfColumns++)
                {
                    chesspiece = chessboard[nrOfRows, nrOfColumns];
                    if ((nrOfRows + nrOfColumns) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    DisplayChessPiece(chesspiece);
                    Console.ResetColor();
                }
                count--;
                Console.WriteLine();
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h");
        }

        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.Queen,
                                        ChessPieceType.King, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };

            for (int nrOfColumns = 0; nrOfColumns < chessboard.GetLength(1); nrOfColumns++)
            {
                //rij 0
                chessboard[0, nrOfColumns] = new ChessPiece();
                chessboard[0, nrOfColumns].Color = ChessPieceColor.black;
                chessboard[0, nrOfColumns].Type = order[nrOfColumns];
                //rij 1
                chessboard[1, nrOfColumns] = new ChessPiece();
                chessboard[1, nrOfColumns].Color = ChessPieceColor.black;
                chessboard[1, nrOfColumns].Type = ChessPieceType.Pawn;
                //rij 7
                chessboard[6, nrOfColumns] = new ChessPiece();
                chessboard[6, nrOfColumns].Color = ChessPieceColor.white;
                chessboard[6, nrOfColumns].Type = ChessPieceType.Pawn;
                // rij 8
                chessboard[7, nrOfColumns] = new ChessPiece();
                chessboard[7, nrOfColumns].Color = ChessPieceColor.white;
                chessboard[7, nrOfColumns].Type = order[nrOfColumns];
            }
        }
        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece != null)
            {
                if (chessPiece.Color == ChessPieceColor.white)
                {
                    Console.ForegroundColor = ConsoleColor.White;// is text standaard niet wit
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                switch (chessPiece.Type)
                {
                    case ChessPieceType.Rook:
                        Console.Write(" r ");
                        break;
                    case ChessPieceType.Knight:
                        Console.Write(" k ");
                        break;
                    case ChessPieceType.Bishop:
                        Console.Write(" b ");
                        break;
                    case ChessPieceType.Queen:
                        Console.Write(" Q ");
                        break;
                    case ChessPieceType.King:
                        Console.Write(" K ");
                        break;
                    case ChessPieceType.Pawn:
                        Console.Write(" p ");
                        break;
                }

                Console.ResetColor();
            }
            else
            {
                Console.Write("   ");
            }
        }

        Position String2Position(string userPos)
        {
            userPos = userPos.ToLower();
            // "a2": "a" => 1st column (0), "2" => 7th row (6)
            Position pos = new Position();
            try
            {
                pos.column = userPos[0] - 'a';
                pos.row = 8 - int.Parse(userPos[1].ToString());
                if ((pos.column < 0) || (pos.column >= 8) ||
                (pos.row < 0) || (pos.row >= 8))
                {
                    throw new Exception("Invalid position: " + userPos);
                }
                return pos;
            }
            catch (Exception e)
            {
                throw new Exception("Invalid position: " + userPos);
            }
        }

        void PlayChess(ChessPiece[,] chessboard)
        {
            Console.WriteLine("Enter move (e.h. a2 a3): ");
            string input = Console.ReadLine();
            while (input != "stop")
            {
                try
                {
                    if (input.ToLower() == "stop") { break; }
                    string[] fields = input.Split(' ');
                    Position fromPos = String2Position(fields[0]);
                    Position toPos = String2Position(fields[1]);
                    Console.WriteLine($"move from {fields[0]} to {fields[1]}");
                    Console.WriteLine();
                    DoMove(chessboard, fromPos, toPos);
                    DisplayChessboard(chessboard);
                    Console.WriteLine();
                    Console.WriteLine("Enter move (e.h. a2 a3): ");
                    input = Console.ReadLine();
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message); Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Enter move (e.h. a2 a3): ");
                    input = Console.ReadLine();
                }

            }
        }

        void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {

            CheckMove(chessboard, from, to);

                chessboard[to.row, to.column] = chessboard[from.row, from.column];
                chessboard[from.row, from.column] = null;

        }

        public void CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            // de volgende regel kan een exception veroorzaken (array out of bounds)
            ChessPiece chesspiece1 = chessboard[from.row, from.column];
            ChessPiece chesspiece2 = chessboard[to.row, to.column];
            if (chesspiece1 == null)
                throw new Exception("No chess piece at from-position");
            if (chesspiece2 != null)
            {
                // other piece must be other color
                if (chesspiece1.Color == chesspiece2.Color)
                    throw new Exception("Can not take a chess piece of same color");
            }
            int ver = Math.Abs(from.row - to.row);
            int hor = Math.Abs(from.column - to.column);
            // no move at all?
            if ((ver == 0) && (hor == 0))
                throw new Exception("No movement");
            bool validMove = false;
            switch (chesspiece1.Type)
            {
                case ChessPieceType.Rook:
                    validMove = (hor * ver == 0);
                    break;
                case ChessPieceType.Knight:
                    validMove = (hor * ver == 2);
                    break;
                case ChessPieceType.Bishop:
                    validMove = (hor == ver);
                    break;
                case ChessPieceType.King:
                    validMove = ((hor == 1) || (ver == 1));
                    break;
                case ChessPieceType.Queen: // rook and bishop move combined
                    validMove = ((hor * ver == 0) || (hor == ver));
                    break;
                case ChessPieceType.Pawn:
                    // can go diagonally when taking opponent's chesspiece...
                    if (chesspiece2 != null)
                        validMove = ((hor == 1) && (ver == 1));
                    else
                        validMove = ((hor == 0) && ((ver == 1) || (ver == 2)));
                    break;
                default:
                    validMove = false;
                    break;
            }
            if (!validMove)
            {
                throw new Exception("Invalid move for chess piece " + chesspiece1.Type);
            }
        }
    }
}
