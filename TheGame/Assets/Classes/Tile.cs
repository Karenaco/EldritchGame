using UnityEngine;
using System.Collections;
using System;


public class Tile
{

    public enum TileType { Empty, Floor , Path};
    TileType type = TileType.Empty;
    Action<Tile> cbTileTypeChanged;
    public Boolean walkable = true;
    int movementCost = 1;
    public TileType Type
    {
        get
        {
            return type;
        }

        set
        {
            TileType oldType = type;
            type = value;
            //Call back the function in world Controller, this will save us on computation time as the sprite is only updated when the tile type changes
            if (cbTileTypeChanged != null && oldType != type)
                cbTileTypeChanged(this);

        }
    }

    public int X
    {
        get
        {
            return x;
        }

    }

    public int Z
    {
        get
        {
            return z;
        }


    }

    LooseObject looseObject;
    InstalledObject installedObject;

    World world;

    //Due to our 3d world we must refer to x and z to draw the ojects flat on the ground, y is height in our world
    int x;
    int z;

    public Tile(World world, int x, int z)
    {
        this.world = world;
        this.x = x;
        this.z = z;
    }

    public void RegisterTileTypeChangedCallback(Action<Tile> callback)
    {
        cbTileTypeChanged = callback;
    }

}
