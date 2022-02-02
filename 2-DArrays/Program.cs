using System;

namespace _2_DArrays
{
    class Program
    {
        
        struct Counters
        {
            public int whiteCounters;
            public int blackCounters;
        }

        struct Position
        {
            public int xPos;
            public int yPos;
        }

        static void Main(string[] args)
        {

            int[,] b = { { 1,1,1,1,1,1,1,1}, 
                         { 1,1,1,1,1,1,1,1}, 
                         { 0,0,0,0,0,0,0,0}, 
                         { 0,0,0,0,0,0,0,0}, 
                         { 0,0,0,0,0,0,0,0}, 
                         { 0,0,0,0,0,0,0,0}, 
                         { 2,2,2,2,2,2,2,2}, 
                         { 2,2,2,2,2,2,2,2}};

            Position[] coOrds = new Position[2];
            coOrds[0].xPos = 0;
            coOrds[0].yPos = 0;
            coOrds[1].xPos = 3;
            coOrds[1].yPos = 3;
            Counters x;

            printBoard(b);
            b =  move(coOrds, b);
            printBoard(b);

            x = countPieces(b);
            // Print out how many pieces are left.

        }


        // Complete the subroutine below
        // it should count the amount of white counters a draft
        // a black counter is represented by a 1
        // a white counter is represented by a 2
        static Counters countPieces(int[,] board)
        {
            Counters boardStatus;
            boardStatus.whiteCounters = 0;
            boardStatus.blackCounters = 0;





            return boardStatus; ;
        }

        // Write a subroutine that prints out the board
        // B - shoukld be printed out for a black counter
        // W - should be printed out for a white counter.
        // ' ' - should be printed out for an emty space
        //e.g
        // BBBBBBBB
        //       WB
        //     B  W
        static void printBoard(int[,] board)
        {


        }

        // Write a subroutine that takes the board and two co-ordinate records
        // MoveFRom and MoveTo
        // If a piece is at the first set of co-ordinates move it to the 2nd set of co-ordinates
        // return the new board if the move is siccesssfull and null if it is not successfull
        static int[,] move(Position[] moveCoOrdinates, int[,] board)
        {



            return board;
        }


        // If first co-ordinate and second co-ordinate contain pieces of opposite colour 
        // and move is valid piece at first co-ordinate takes the piece at the 2nd co-ordinate.
        static int[,]  takePiece(Position[] moveCords, int[,] b)
        {

            return b;
        }


    }
}
