using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MousePoint : MonoBehaviour
{
    public GameObject circleCursor;
    public Sprite HighlightSprite;
    public Sprite RegularSprite;
    Tile TileUnderMouse;
    Tile SelectedTile;
    GameObject TileUnderMouseGO;
    GameObject SelectedTileGO;
    List<GameObject> rookies;

    GameObject[,] walkableTiles;
    Tile[,] surroundingTiles;

    public PlayerMovement playerMovement;
    RaycastHit hit;
    GameObject rookie;
    public AssetManager am;
    public WorldController wc;
    void Start()
    {
        rookie = wc.rookie_go;
    }


    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //TileUnderMouse.GetComponent<SpriteRenderer>().sprite = RegularSprite

        if (Physics.Raycast(ray, out hit, 1000))
        {

            Debug.Log(Mathf.RoundToInt(hit.point.x) + " " + Mathf.RoundToInt(hit.point.z));

            TileUnderMouse = wc.GetTileAt(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.z));
            if(TileUnderMouse != null)
            {
                TileUnderMouseGO = GameObject.Find("Tile_" + Mathf.RoundToInt(hit.point.x) + "_" + Mathf.RoundToInt(hit.point.z));
            }
            
            if(TileUnderMouseGO != null)
            {
                circleCursor.transform.position = TileUnderMouseGO.transform.position;
                rookies = wc.listRookies();
                rookies[0].transform.position = TileUnderMouseGO.transform.position;
            }
            

            if (Input.GetMouseButton(0))
            {
                if (SelectedTile == null && TileUnderMouse != null)
                {
                    SelectedTile = TileUnderMouse;
                    SelectedTileGO = TileUnderMouseGO;
                    SelectedTileGO.GetComponent<SpriteRenderer>().sprite = am.getHighlightTileSprite(SelectedTile);
                    
                }
                else if (SelectedTile != TileUnderMouse && TileUnderMouse != null)
                {

                    SelectedTileGO.GetComponent<SpriteRenderer>().sprite = am.getTileSprite(SelectedTile);
                    SelectedTile = TileUnderMouse;
                    SelectedTileGO = TileUnderMouseGO;
                    SelectedTileGO.GetComponent<SpriteRenderer>().sprite = am.getHighlightTileSprite(SelectedTile);
                }

                /*if (Input.GetMouseButton(1))
                {
                    SelectedTile = TileUnderMouse;
                    SelectedTileGO = TileUnderMouseGO;
                    surroundingTiles = wc.GetSurroundingTiles(SelectedTile);
                    for (int x = 0; x < surroundingTiles.GetLength(0); x++)
                    {
                        for (int z = 0; z < surroundingTiles.GetLength(1); z++)
                        {
                            walkableTiles[x,z] = GameObject.Find("Tile_" + Mathf.RoundToInt(surroundingTiles[x,z].X) + "_" + Mathf.RoundToInt(surroundingTiles[x,z].Z));
                            Debug.Log("I am here");
                            walkableTiles[x,z].GetComponent<SpriteRenderer>().sprite = am.getHighlightTileSprite(SelectedTile);
                        }
                    }
                       
                    
                   

                    SelectedTileGO.GetComponent<SpriteRenderer>().sprite = am.getTileSprite(SelectedTile);
                    SelectedTile = TileUnderMouse;
                    SelectedTileGO = TileUnderMouseGO;
                    SelectedTileGO.GetComponent<SpriteRenderer>().sprite = am.getHighlightTileSprite(SelectedTile);
                }*/

                if (Input.GetMouseButton(1))
                {
                    float step = 5 * Time.deltaTime;
                    rookie.transform.position = Vector3.MoveTowards(wc.rookie_go.transform.position, SelectedTileGO.transform.position, step);
                    playerMovement = rookie.GetComponent<PlayerMovement>();
                          
                }

            }
            else
            {
                //Tile = null;
            }
         
           


            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.yellow);
        }
    }
}
