using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAWN : Piece
{
    public override List<Vector2Int> SelectAvailiableSquares()
    {
        avaliableMoves.Clear();
        Vector2Int.direction = tem == TeamColor.White ? Vector2Int.up : Vector2Int.down; 
        return avaliableMoves;
    } 
}
