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
        if (collision.gameObject.name == "Ball")
        {
            gameM.check();
            gameM.isMoving = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Stoje");
        if(!gameM.isMoving)
            ball.transform.position = Vector3.MoveTowards(ball.transform.position, this.transform.position, 6 * Time.deltaTime);
    }
}
