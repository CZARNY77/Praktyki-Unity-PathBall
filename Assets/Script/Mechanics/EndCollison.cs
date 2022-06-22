using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCollison : MonoBehaviour
{
    [SerializeField] GameObject path;
    GameManager gameM;

    void Start()
    {
        gameM = GetComponentInParent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 temp = this.gameObject.transform.up;
        if (this.gameObject.name == "end_1" && collision.gameObject.name == "Ball")
        {
            path.GetComponent<InfoPath>().direction = (-gameM.speed * temp);
            path.GetComponent<InfoPath>().isBall = true;
        }
        else if (this.gameObject.name == "end_2" && collision.gameObject.name == "Ball")
        {
            path.GetComponent<InfoPath>().direction = (gameM.speed * temp);
            path.GetComponent<InfoPath>().isBall = true;
        }
        //path.GetComponentInParent<GameManager>().isMoving = false;

        gameM.allPath++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            path.GetComponent<InfoPath>().isBall = false;
            gameM.allPath = 0;
        }
    }
}
