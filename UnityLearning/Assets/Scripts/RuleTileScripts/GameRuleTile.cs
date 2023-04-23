using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "New Rule Tile", menuName = "GameRuleTile/Rule Tile")]
public class GameRuleTile : RuleTile
{
    public Color Color;

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        base.GetTileData(position, tilemap, ref tileData);
        tileData.color = Color;
        tileData.flags = TileFlags.LockColor;
    }
}
