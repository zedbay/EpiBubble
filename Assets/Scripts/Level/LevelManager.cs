using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelManager : MonoBehaviour
{

    public Tilemap tilemap;
    public GameObject prefabBulle;
    public Application.Board board;
    private Color color;

    // Start is called before the first frame update
    void Start()
    {
        this.color = new Color();
        this.CreateLevel();
        board = new Application.Board();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateLevel()
    {
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 17; i++)
            {
                prefabBulle.GetComponent<SpriteRenderer>().color = color.GetRandomColor();
                GameObject tmp =  Instantiate(prefabBulle, tilemap.LocalToWorld(tilemap.CellToLocal(new Vector3Int(-17 + i, 19 - j, 0))), Quaternion.identity);
                board.SetEmplacement(i, j, tmp);
            }
        }
    }
}
