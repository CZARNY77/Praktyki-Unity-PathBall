using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum stats{
    Play,
    Pause
}

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int allPath = 0;
    public float speed = 3f;
     public bool isMoving = false;
     public bool start = false;
    bool lose = false;
    bool round = true;
    [SerializeField] Canvas canv;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject menu;
    Text[] txt;

    private void Start()
    {
        Button[] btn;
        btn = menu.GetComponentsInChildren<Button>();
        btn[0].onClick.AddListener(Resume);
        btn[1].onClick.AddListener(Exit);
        txt = canv.GetComponentsInChildren<Text>();
        switch_player();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(menu.activeSelf)
                menu.SetActive(false);
            else
                menu.SetActive(true);
        }
    }

    public void win(Players player)
    {
        panel.GetComponentInChildren<Text>().text = "Wygrywa: " + player;
        panel.SetActive(true);
    }

    public void check()
    {
        if (allPath <= 0 && !lose)
        {
            panel.GetComponentInChildren<Text>().text = "REMIS";
            lose = true;
            panel.SetActive(true);
        }
    }

    public void Resume()
    {
        menu.SetActive(false);
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void switch_player()
    {
        if (round)
        {
            txt[0].color = new Color(1, 0, 0);
            txt[1].color = new Color(0, 0, 0);
            round = false;
        }
        else
        {
            txt[0].color = new Color(0, 0, 0);
            txt[1].color = new Color(0, 0, 1);
            round = true;
        }
    }
}
