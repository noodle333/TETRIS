using System;
using System.Collections.Generic;

public class PieceHandler
{
    private Piece[] pieceArr;
    // 4x1 = I : 2x2 = O : RED = S : GREEN = Z : L = L : J = J : T = T
    public PieceHandler()
    {
        pieceArr = new Piece[] {
            //ADD ALL TETRIS PIECES TO AN ARRAY.
            new Piece{
                type = "I",
                height = 4,
                width = 1,
                dots = new int[,]
                {
                    {1},
                    {1},
                    {1},
                    {1}
                }
            },
            new Piece{
                type = "O",
                height = 2,
                width = 2,
                dots = new int[,]
                {
                    {1, 1},
                    {1, 1}
                }
            },
            new Piece{
                type = "S",
                height = 2,
                width = 3,
                dots = new int[,]
                {
                    {0, 1, 1},
                    {1, 1, 0}
                }
            },
            new Piece{
                type = "S",
                height = 2,
                width = 3,
                dots = new int[,]
                {
                    {1, 1, 0},
                    {0, 1, 1}
                }
            },
            new Piece{
                type = "L"
            }
            new Piece{
                type = "J"
            }
            new Piece{
                type = "T"
            }

        };

    }
}
