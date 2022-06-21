using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Ball : ITickable
{
    GameObject ball;
    GameObject path;

    Vector3 lastPosition;

    public Ball(GameObject Ball)
    {
        ball = Ball;
    }
    public void moveBall(GameObject curretPath)
    {
        curretPath.GetComponentInParent<GameManager>().isMoving = true;
        path = curretPath;
        lastPosition = ball.transform.position;
    }

    public void Tick()
    {
        if (path != null)
        {
            if (path.GetComponentInParent<GameManager>().isMoving)
            {
                ball.transform.position += path.GetComponent<InfoPath>().direction * Time.deltaTime;
                /*if(Vector3.Distance(lastPosition, ball.transform.position) >= 2.5 || Vector3.Distance(lastPosition, ball.transform.position) <= -2.5)
                    path.GetComponentInParent<GameManager>().isMoving = false;*/
            }
            Debug.Log(Vector3.Distance(lastPosition, ball.transform.position));
        }
    }
}