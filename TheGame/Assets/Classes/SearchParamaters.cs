using UnityEngine;
using System.Collections;

public class SearchParamaters
{

    public class SearchParameters
    {
        public Tile StartLocation { get; set; }
        public Tile EndLocation { get; set; }
        public bool[,] Map { get; set; }
    }

}
