using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btn_play : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel_play;
    Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(next_page);
    }

    void next_page()
    {
        if (panel.activeSelf)
        {
            panel.SetActive(false);
            panel_play.SetActive(true);
        }
        else
        {
            panel.SetActive(true);
            panel_play.SetActive(false);
        }
    }
}
