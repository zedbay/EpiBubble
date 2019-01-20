using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile1;
    public List<Color> SelectedBubbleColor;
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

    public GameObject nextProjectileUI;

    private void Start()
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
        //choix d'une couleur aléatoire pour la prochaine bulles lancé 
        int randomColor = Random.Range(0, 6);
        projectile1.GetComponent<SpriteRenderer>().color = SelectedBubbleColor[randomColor];
        nextProjectileUI.GetComponent<SpriteRenderer>().color = SelectedBubbleColor[randomColor];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Création de l'objet
        Instantiate(projectile1, firePoint.position, firePoint.rotation);
        int randomColor = Random.Range(0, 6);
        projectile1.GetComponent<SpriteRenderer>().color = SelectedBubbleColor[randomColor];
        nextProjectileUI.GetComponent<SpriteRenderer>().color = SelectedBubbleColor[randomColor];
    }
}
