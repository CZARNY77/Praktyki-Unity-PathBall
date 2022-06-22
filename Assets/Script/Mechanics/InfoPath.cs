using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPath : MonoBehaviour
{
    public bool isActive = true;
    public bool isBall = false;
    public Vector3 direction;
    GameManager gameM;

    private void Start()
    {
        gameM = GetComponentInParent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Ball")
        {
            isBall = true;
        }
        gameM.allPath++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Ball")
        {
            isBall = false;
        }
        gameM.allPath = 0;
    }
}
