using UnityEngine;
using System.Collections;

public class AssetManager : MonoBehaviour
{

    public Sprite floorSprite;
    public Sprite floorHighlightSprite;
    public Sprite pathSprite;


    public Sprite getTileSprite(Tile tile)
    {
        if(tile.Type == Tile.TileType.Floor)
        {
            return floorSprite;
        }

        else if(tile.Type == Tile.TileType.Path)
        {
            return pathSprite; 
        }
        return null;
    }

    public Sprite getHighlightTileSprite(Tile tile)
    {
        if(tile.Type == Tile.TileType.Floor)
        { 
            return floorHighlightSprite;
        }

        return null;
    }



	
}
