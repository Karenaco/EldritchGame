﻿using UnityEngine;
using System.Collections;

public class Node {

    public bool walkable;
    public Vector3 WorldPosition;

    public Node(bool _walkable, Vector3 _worldPos)
    {
        walkable = _walkable;
        WorldPosition = _worldPos;
    }
	
}
