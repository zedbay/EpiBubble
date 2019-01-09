using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MooveMenu : MonoBehaviour
{

    public Button m_resume;
    public Button m_settings;
    public Button m_return_left;
    public Button m_return_right;

    public GameObject m_menu;
    public GameObject m_menu_settings;
    public GameObject m_menu_resume;


    private bool moove_left = false;
    private bool moove_right = false;
    private bool return_right = false;
    private bool return_left = false;

    private 

    // Start is called before the first frame update
    void Start()
    {
        m_resume.onClick.AddListener(ShowResume);
        m_settings.onClick.AddListener(ShowSettings);
        m_return_left.onClick.AddListener(ShowMenu);
        m_return_right.onClick.AddListener(ShowMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ShowMenu()
    {
        m_menu_settings.SetActive(false);
        m_menu.SetActive(true);
        m_menu_resume.SetActive(false);
    }

    private void ShowSettings()
    {
        m_menu_settings.SetActive(true);
        m_menu.SetActive(false);
    }

    private void ShowResume()
    {
        m_menu.SetActive(false);
        m_menu_resume.SetActive(true);
    }


}
