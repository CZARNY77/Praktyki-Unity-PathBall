using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btn_play : MonoBehaviour
{
    Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(load_lvl);
    }

    void load_lvl()
    {
        SceneManager.LoadScene("lvl", LoadSceneMode.Single);
    }
}
