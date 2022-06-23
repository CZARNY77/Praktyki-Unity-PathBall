using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Ball : ITickable
{
    GameObject ball;
    GameManager gameM;

    Vector3 direction;

    public Ball(GameObject Ball)
    {
        ball = Ball;
    }
    public void moveBall(GameObject curretPath)
    {
        gameM = curretPath.GetComponentInParent<GameManager>();
        gameM.isMoving = true;

        if (curretPath.GetComponent<InfoPath>().end[0].transform.position == ball.transform.position)
        {
            Debug.Log("jej");
            direction = curretPath.GetComponent<InfoPath>().end[1].transform.position;
        }
        else if (curretPath.GetComponent<InfoPath>().end[1].transform.position == ball.transform.position)
        {
            Debug.Log("jej");
            direction = curretPath.GetComponent<InfoPath>().end[0].transform.position;
        }
        Debug.Log(direction);
    }

    public void Tick()
    {
        if (gameM != null)
        {
            //if (gameM.isMoving)
            {
                ball.transform.position = Vector3.MoveTowards(ball.transform.position, direction, gameM.speed * Time.deltaTime);
            }
        }
    }
}