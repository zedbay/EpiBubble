using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelManager : MonoBehaviour
{

    public Tilemap tilemap;
    public GameObject prefabBulle;
    public Application.Board board = new Application.Board();
    private Color color;

    public Transform firePoint;
    public GameObject projectile1;
    public GameObject nextProjectileUI;
    private int currentShoot;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        this.color = new Color();
        this.CreateLevel();
        this.currentShoot = 0;
        UnityEngine.Color randomColor = color.GetRandomColor();
        projectile1.GetComponent<SpriteRenderer>().color = randomColor;
        nextProjectileUI.GetComponent<SpriteRenderer>().color = randomColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Debug.Log("hello");
        currentShoot++;
        if (currentShoot % 6 == 0)
        {
            MooveBottom();
            GenerateLine();
        }
        Instantiate(projectile1, firePoint.position, firePoint.rotation);
        UnityEngine.Color randomColor = color.GetRandomColor();
        projectile1.GetComponent<SpriteRenderer>().color = randomColor;
        nextProjectileUI.GetComponent<SpriteRenderer>().color = randomColor;
    }

    private void CreateLevel()
    {
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 17; i++)
            {
                prefabBulle.GetComponent<SpriteRenderer>().color = color.GetRandomColor();
                GameObject tmp =  Instantiate(prefabBulle, tilemap.LocalToWorld(tilemap.CellToLocal(new Vector3Int(-17 + i, 19 - j, 0))), Quaternion.identity);
                board.SetEmplacement(-17 + i, 19 - j, tmp);
            }
        }
    }

    private void GenerateLine()
    {
        for (int i = 0; i < 17; i++)
        {
            prefabBulle.GetComponent<SpriteRenderer>().color = color.GetRandomColor();
            GameObject tmp = Instantiate(prefabBulle, tilemap.LocalToWorld(tilemap.CellToLocal(new Vector3Int(-17 + i, 19, 0))), Quaternion.identity);
            board.SetEmplacement(-17 + i, 19, tmp);
        }
    }

    private void MooveBottom()
    {
        for(int i = 0; i < board.tabBoard.Count; i++)
        {
            float x = board.tabBoard[i].x;
            float y = board.tabBoard[i].y;
            board.tabBoard[i].bulle.transform.position = tilemap.LocalToWorld(tilemap.CellToLocal(new Vector3Int((int) x, (int) y - 1, 0)));
            board.tabBoard[i].y--;
        }
        GenerateLine();
    }

    private void RemoveEmplacement(int x, int y)
    {
        Destroy(board.GetEmplacement(x, y).bulle);
        board.RemoveEmplacement(x, y);
    }
}
