using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int allPath = 0;
    public float speed = 3f;
    public bool isMoving = false;
    bool lose = false;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject menu;

    private void Start()
    {
        /*Button btn = menu.GetComponentInChildren<Button>();
        btn.onClick.AddListener(Resume);
        */
        Button[] btn;
        btn = menu.GetComponentsInChildren<Button>();
        btn[0].onClick.AddListener(Resume);
        btn[1].onClick.AddListener(Exit);
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
        Debug.Log("Exit");
    }
}
