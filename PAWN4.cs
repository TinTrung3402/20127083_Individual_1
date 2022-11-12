using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAWN : Piece
{
    public override List<Vector2Int> SelectAvailiableSquares()
    {
        avaliableMoves.Clear();
        Vector2Int.direction = tem == TeamColor.White ? Vector2Int.up : Vector2Int.down; 
        float range = hasMoved ? 1 : 2;
        for (int i = 0; i <= range ; i++ )
        {
            Vector2Int nextCoords = occupiedSquare + direction * i;
            Piece piece = board.GetPieceOnSquare(nextCoords);
            if(!board.CheckIfCoordinatedAreOnBoard(nextCoords))
                break;
            if(piece == null)
                TryToAddMove(nextCoords);
            else if (piece.IsFromSameTeam(this))
                break;
        }

        Vector2Int[] takeDirections = new Vector2Int[]{new Vector2Int(1,direction.y), new Vector2Int(-1, direction.y) };
        return avaliableMoves;
    } 
}
