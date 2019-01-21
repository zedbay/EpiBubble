using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MooveMenu : MonoBehaviour
{

    public Button m_resume;
    public Button m_settings;
    public Button m_return_left;
    public Button m_return_right;
    public Button m_leave;
    public Button m_not_leave;
    public Button m_go_leave;
    public Button m_start;
    

    public GameObject m_menu;
    public GameObject m_menu_settings;
    public GameObject m_menu_resume;
    public GameObject m_menu_leave;




    private 

    // Start is called before the first frame update
    void Start()
    {
        m_resume.onClick.AddListener(ShowResume);
        m_settings.onClick.AddListener(ShowSettings);
        m_return_left.onClick.AddListener(ShowMenu);
        m_return_right.onClick.AddListener(ShowMenu);
        m_leave.onClick.AddListener(ShowLeave);
        m_not_leave.onClick.AddListener(ShowMenu);
        m_go_leave.onClick.AddListener(Leave);
        m_start.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void StartGame()
    {
        SceneManager.LoadScene("GameScren");
    }

    private void Leave()
    {
        UnityEngine.Application.Quit();
    }

    private void ShowLeave()
    {
        m_menu_leave.SetActive(true);
        m_menu.SetActive(false);
    }

    private void ShowMenu()
    {
        m_menu_settings.SetActive(false);
        m_menu.SetActive(true);
        m_menu_resume.SetActive(false);
        m_menu_leave.SetActive(false);
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
