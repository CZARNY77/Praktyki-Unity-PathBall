using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPath : MonoBehaviour
{
    public bool isActive = true;
    public bool isBall = false;
    public List<GameObject> end = new List<GameObject>();
    GameManager gameM;

    private void Start()
    {
        gameM = GetComponentInParent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(this.name);
        if(collision.name == "Ball")
        {
            isBall = true;
        }
        gameM.allPath++;
        if (collision.tag == "Intersection")
        {
            end.Add(collision.gameObject);
        }
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
