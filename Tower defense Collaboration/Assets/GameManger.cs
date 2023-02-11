using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManger : MonoBehaviour
{
    private Grid grid;
    private Tilemap tilemap;
    // Start is called before the first frame update
    void Start()
    {
        grid = (Grid)GameObject.FindObjectOfType(typeof(Grid));

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(string.Format("Co-ords of mouse is [X: {0} Y: {0}]", pos.x, pos.y));
            new TileData tile = world.Tile((int)pos.x, (int)pos.y);

            if (tile != null)
            {
                Debug.Log(string.Format("Tile is: {0}", tile.TileType));
            }
        }
        */
    }
}
