using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaccourciVolume : MonoBehaviour
{

    public Button m_volume;

    public Sprite m_soundOn;
    public Sprite m_soundOff;

    private bool m_mooveMenuPrincipal = false;
    private float smoothTime = 0.3F;
    private float yVelocity = 0.0F;



    void Start()
    {
        m_volume.onClick.AddListener(OnClickVolume);
        m_volume.image.sprite = m_soundOn;
    }

    void OnClickVolume()
    {
        if(m_volume.image.sprite == m_soundOn)
        {
            m_volume.image.sprite = m_soundOff;
        }
        else
        {
            m_volume.image.sprite = m_soundOn;
        }

    }

    void OnClickParametres()
    {
        m_mooveMenuPrincipal = true;
    }

    void OnClickQuitter()
    {
        Debug.Log("Au revoid");
    }





    // Update is called once per frame
    void Update()
    {

        if (m_mooveMenuPrincipal)
        {
            //m_menuPrincpal.transform.Translate(new Vector2(0, 16));
            //if (m_menuPrincpal.transform.position.y >= 900)
               // m_mooveMenuPrincipal = false; 
        }
    }
}
