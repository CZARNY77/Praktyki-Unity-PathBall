using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCollison : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject path;
    public Vector3 newPosition;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 temp = this.gameObject.transform.up;
        if (this.gameObject.name == "end_1" && collision.gameObject.name == "Ball" && path.GetComponent<InfoPath>().isMoving)
        {
            newPosition = ball.transform.position - (2.45f * temp);
        }
        else if (this.gameObject.name == "end_2" && collision.gameObject.name == "Ball" && path.GetComponent<InfoPath>().isMoving)
        {
            newPosition = ball.transform.position + (2.45f * temp);
        }
        path.GetComponent<InfoPath>().isMoving = false;
    }
}
