using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_pause : MonoBehaviour
{
    Button btn;
    [SerializeField] GameObject menu;
    [SerializeField] GameManager gameM;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(Pause);
    }

    void Pause()
    {
        menu.SetActive(true);
        gameM._state = State.Pause;
    }
}
