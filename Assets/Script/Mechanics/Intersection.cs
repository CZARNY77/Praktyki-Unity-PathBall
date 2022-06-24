using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intersection : MonoBehaviour
{
    GameManager gameM;
    [SerializeField] GameObject ball;

    private void Start()
    {
        gameM = GetComponentInParent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball" && gameM.start)
        {
            gameM.check();
            //gameM.isMoving = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(!gameM.isMoving && collision.name == "Ball" && !gameM.start)
            ball.transform.position = Vector3.MoveTowards(ball.transform.position, this.transform.position, gameM.speed * Time.deltaTime);
        if (gameM && ball.transform.position == transform.position)
            gameM.isMoving = false;
    }
}
