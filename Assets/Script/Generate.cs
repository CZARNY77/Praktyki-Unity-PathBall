using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject Path;
    public GameObject Intersection;
    int[,] tab = new int[7, 10];
    float distance = 1.3f;
    void Start()
    {
        for (int j = 0; j < 6; j++)
            for (int i = 0; i < 10; i++) tab[j, i] = 0;

        info_path();
    }

    void create_path(Vector2 pos)
    {
        Instantiate(Path, pos, Quaternion.identity, transform);
    }

    void info_path()
    {
        for (int j = 0; j < 6; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    
                }
            }
        }
    }
}
