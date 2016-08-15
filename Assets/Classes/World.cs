using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class World
{

    Tile[,] tiles;

    int width;
    int height;
    public List<Rookie> rookies;
    public int numOfRookies;
    public int Width
    {
        get
        {
            return width;
        }

        set
        {
            width = value;
        }
    }

    public int Height
    {
        get
        {
            return height;
        }

        set
        {
            height = value;
        }
    }

    public World(int width = 100, int height = 100)
    {
        this.width = width;
        this.height = height;
        rookies = new List<Rookie>();
        tiles = new Tile[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                tiles[x, z] = new Tile(this, x, z);
            }
        }
        //Rookie rookie = new Rookie("ADAMMOTHERFUCKINGBOYD", "Hard lad fre ballymoney", Rookie.Race.NornIrish, new Vector3(1, 0, 1));
        rookies.Add(new Rookie("ADAMMOTHERFUCKINGBOYD", "Hard lad fre ballymoney", Rookie.Race.NornIrish, new Vector3(2, 0, 2), this));
        numOfRookies++;
    }


    public Tile GetTileAt(int x, int z)
    {
        Debug.Log("Getting a tile");
        if (x >= width || x < 0 || z >= height || z < 0)
        {
            return null;
        }
        return tiles[x, z];
    }

    public Vector3 GetLocation(Vector3 position)
    {
        Vector3 location;
        location = position;
        location.x = Mathf.Round(position.x);
        location.z = Mathf.Round(position.z);
        return location;
    }

}
