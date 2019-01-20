using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

//Création du niveau
public class LevelCreator : MonoBehaviour
{
    public GameObject prefabBulle;
    public Tilemap tilemap;

    public static Color Black;
    public static Color Silver;
    public static Color Grey;
    public static Color White;
    public static Color Maroon;
    public static Color Red;
    public static Color Purple;
    public static Color Fuchsia;
    public static Color Green;
    public static Color Lime;
    public static Color Yellow;
    public static Color Blue;
    public static Color Cyan;
    public static Dictionary<string, Color> ColorDico;
    public List<Color> SelectedBubbleColor;


    // Start is called before the first frame update
    void Start()
    {
        SelectedBubbleColor = new List<Color>();
        ColorUtility.TryParseHtmlString("#000000", out Black);
        ColorUtility.TryParseHtmlString("#C0C0C0", out Silver);
        ColorUtility.TryParseHtmlString("#808080", out Grey);
        ColorUtility.TryParseHtmlString("#FFFFFF", out White);
        ColorUtility.TryParseHtmlString("#800000", out Maroon);
        ColorUtility.TryParseHtmlString("#FF0000", out Red);
        ColorUtility.TryParseHtmlString("#800080", out Purple);
        ColorUtility.TryParseHtmlString("#FF00FF", out Fuchsia);
        ColorUtility.TryParseHtmlString("#008000", out Green);
        ColorUtility.TryParseHtmlString("#00FF00", out Lime);
        ColorUtility.TryParseHtmlString("#FFFF00", out Yellow);
        ColorUtility.TryParseHtmlString("#0000F0", out Blue);
        ColorUtility.TryParseHtmlString("#00FFFF", out Cyan);
        SelectedBubbleColor.Add(Blue);
        SelectedBubbleColor.Add(Red);
        SelectedBubbleColor.Add(Cyan);
        SelectedBubbleColor.Add(Yellow);
        SelectedBubbleColor.Add(Fuchsia);
        SelectedBubbleColor.Add(Lime);

        //cube.AddComponent<Rigidbody>();
        //Vector3 position = tilemap.GetLayoutCellCenter();
        //j pour l'axe vertical 
        for (int j = 0; j < 7; j++)
        { 
            //i pour l'axe horizontal
            for (int i = 0; i < 17; i++)
            {
                //choix d'une couleur aléatoire
                int randomColor = Random.Range(0, 6);
                prefabBulle.GetComponent<SpriteRenderer>().color = SelectedBubbleColor[randomColor];
                Instantiate(prefabBulle, tilemap.LocalToWorld(tilemap.CellToLocal(new Vector3Int(-17 + i, 19 - j, 0))), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
