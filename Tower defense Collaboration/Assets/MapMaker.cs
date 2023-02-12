using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class MapMaker : MonoBehaviour
{
    public Tilemap tilemap;
    public Tilemap tilemapOverlay;
    public Grid grid;
    public int width;
    public int height;
    public GameTile[,] gameTiles;


    private void Awake()
    {
        gameTiles = new GameTile[width, height];
    }

    // Start is called before the first frame update
    void Start()
    {
        
        SetInitialMap();
        Debug.Log(gameTiles[0, 0].spriteName);
        Debug.Log(gameTiles[0, 0].spriteType);

    }

    void SetInitialMap()
    {

        tilemapOverlay.origin = new Vector3Int(0, 0, 0);
        Debug.Log("tmx: " + tilemapOverlay.origin.x + " tmy: " + tilemapOverlay.origin.y);
        for (int x = 0 ; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
 

                gameTiles[x, y] = new GameTile();
                
                
                //Debug.Log("x: " + x + " y: " + y);
               // Debug.Log(tilemapOverlay.HasTile(new Vector3Int(x - tilemapOverlay.origin.x, y, 0)));
                
                // Debug.Log(gameTiles[x, y].spriteName);
                // Debug.Log(gameTiles[x, y].spriteType);
                if (tilemapOverlay.HasTile(new Vector3Int(x, y, 0)))
                {
                    Debug.Log(tilemapOverlay.GetSprite(new Vector3Int(x, y, 0)).name);
                    gameTiles[x, y].spriteName = tilemapOverlay.GetSprite(new Vector3Int(x, y, 0)).name;
                    gameTiles[x, y].spriteType = tilemapOverlay.GetSprite(new Vector3Int(x, y, 0)).name.ToString()[0..^3];
                }
                else {
                    gameTiles[x, y].spriteName = tilemap.GetSprite(new Vector3Int(x, y, 0)).name;
                    gameTiles[x, y].spriteType = tilemap.GetSprite(new Vector3Int(x, y, 0)).name.ToString()[0..^3];
                }
                if (gameTiles[x, y].spriteType == "mountain" || gameTiles[x, y].spriteType == "road")
                {
                    gameTiles[x, y].buildable = false;
                }

            }
        }
    }


}
