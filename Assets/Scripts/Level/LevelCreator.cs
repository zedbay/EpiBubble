using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

//Création du niveau
public class LevelCreator : MonoBehaviour
{
    public GameObject prefabBulle;
    public Tilemap tilemap;
    private Color color;


    // Start is called before the first frame update
    void Start()
    {
        color = new Color();
        //j pour l'axe vertical 
        for (int j = 0; j < 7; j++)
        { 
            //i pour l'axe horizontal
            for (int i = 0; i < 17; i++)
            {
                //choix d'une couleur aléatoire
                prefabBulle.GetComponent<SpriteRenderer>().color = color.GetRandomColor();
                Instantiate(prefabBulle, tilemap.LocalToWorld(tilemap.CellToLocal(new Vector3Int(-17 + i, 19 - j, 0))), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
