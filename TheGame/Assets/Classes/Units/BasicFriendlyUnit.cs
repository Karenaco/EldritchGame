using UnityEngine;
using System.Collections;

public interface BaseFriendlyUnit{

    Vector3 getCurrentTileCoords();
    void setUpBasicStats();
    void move();
    void changeAnimation();
    void attack();


}
