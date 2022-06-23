using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class btn_exit : MonoBehaviour
{
    Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(exit);
    }

    void exit()
    {
        Application.Quit();
    }
}
