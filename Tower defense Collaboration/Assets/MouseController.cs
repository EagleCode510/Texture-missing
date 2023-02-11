using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    public MapMaker mapMaker;
    private Vector3 curPos;
    private Vector3 prevPos = new Vector3(0.0f, 0.0f, 0.0f);
    private SpriteRenderer spriteRend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        spriteRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        curPos = GetMouseGridPosition();
        Vector3Int cellLocation = (mapMaker.tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
        int x = cellLocation.x;
        int y = cellLocation.y;
        if (curPos != prevPos && x >= 0 && x < mapMaker.gameTiles.GetLength(0) && y >=0 && y < mapMaker.gameTiles.GetLength(1))
        {   if (mapMaker.gameTiles[cellLocation.x, cellLocation.y].buildable == true)
            {
                spriteRend.color = new Color(1f, 1f, 1f, .3f);

            }
            else
            {
                spriteRend.color = new Color(1f, 0f, 0f, .3f);
            }
            transform.position = curPos;
            prevPos = curPos;
        }
    }


    Vector3 GetMouseGridPosition()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;
        mouseWorldPos.y = Mathf.Round(mouseWorldPos.y - 0.5f) + .5f;
        mouseWorldPos.x = Mathf.Round(mouseWorldPos.x - 0.5f) + .5f;
        return mouseWorldPos;
    }
}
