using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class WorldController : MonoBehaviour
{
    public GameObject player;
    World world;
    public Sprite FloorSprite;
    public Sprite HighlightSprite;
    Plane groundCollisionPlane = new Plane();
    public GameObject rookie_go;
    // Use this for initialization
    void Start()
    {
        
        world = new World();
        // Create a GameObject for each of our tiles, so they show visually.
        // Unity only draws Gameobjects to screen
        for (int x = 0; x < world.Width; x++)
        {
            for (int y = 0; y < world.Height; y++)
            {
                Tile tile_data = world.GetTileAt(x, y);
                tile_data.walkable = true;
                tile_data.Type = Tile.TileType.Floor;
                GameObject tile_go = new GameObject();
                tile_go.name = "Tile_" + x + "_" + y;
                tile_go.transform.position = new Vector3(tile_data.X, 0, tile_data.Z);
                tile_go.transform.eulerAngles = new Vector3(90, 0, 0);
                tile_go.transform.SetParent(this.transform, true);
                tile_go.AddComponent<SpriteRenderer>();
                tile_go.GetComponent<SpriteRenderer>().sprite = FloorSprite;
                tile_go.tag = "Ground";         
                //Using a lambda function to convert the tile to a tile and Gameobject function
                //This is done to seperate the data layer(tile class etc) from the view layer (The actual drawable game objects)
                tile_data.RegisterTileTypeChangedCallback((tile) => { OnTileTypeChanged(tile, tile_go); });
            }
        }
        groundCollisionPlane.Set3Points(new Vector3(0, 0, 0), new Vector3(0, 0, world.Width), new Vector3(world.Height, 0, 0));
        foreach(Rookie rook in world.rookies)
        {
            rookie_go = (GameObject)Instantiate(player, rook.position, Quaternion.Euler(new Vector3(0,45,0)));
            rookie_go.name = rook.name;
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTileTypeChanged(Tile tile_data, GameObject tile_go)
    {
        if (tile_data.Type == Tile.TileType.Floor)
        {
            tile_go.GetComponent<SpriteRenderer>().sprite = FloorSprite;
        }
        else if (tile_data.Type == Tile.TileType.Empty)
        {
            tile_go.GetComponent<SpriteRenderer>().sprite = null;
        }
        else
        {
            Debug.LogError("Unrecognized tile type.");

        }
    }

    public Tile GetTileAt(int x, int z)
    { 
        return world.GetTileAt(x, z);
    }

    /*public Tile[] GetSurroundingTiles(int x, int z)
    {
        Tile[] surrounding = new Tile[8];

        surrounding[0] = GetTileAt(x - 1, z + 1);
        surrounding[1] = GetTileAt(x, z + 1);
        surrounding[2] = GetTileAt(x + 1, z + 1);
        surrounding[3] = GetTileAt(x - 1, z);
        surrounding[4] = GetTileAt(x + 1, z);
        surrounding[5] = GetTileAt(x - 1, z - 1);
        surrounding[6] = GetTileAt(x, z - 1);
        surrounding[7] = GetTileAt(x + 1, z - 1);

        return surrounding;
    }

    public Tile[,] GetSurroundingTiles(Tile tile)
    {
        Tile[,] surrounding = new Tile[3,3];

        surrounding[0,2] = GetTileAt(tile.X - 1, tile.Z + 1);
        surrounding[1,2] = GetTileAt(tile.X, tile.Z + 1);
        surrounding[2,2] = GetTileAt(tile.X + 1, tile.Z + 1);
        surrounding[1,0] = GetTileAt(tile.X - 1, tile.Z);
        surrounding[1,1] = tile;
        surrounding[1,2] = GetTileAt(tile.X + 1, tile.Z);
        surrounding[0,0] = GetTileAt(tile.X - 1, tile.Z - 1);
        surrounding[0,1] = GetTileAt(tile.X, tile.Z - 1);
        surrounding[0,2] = GetTileAt(tile.X + 1, tile.Z - 1);

        return surrounding;
    }*/

}
