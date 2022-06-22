using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Ball : ITickable
{
    GameObject ball;
    GameObject path;

    Vector3 direction;

    public Ball(GameObject Ball)
    {
        ball = Ball;
    }
    public void moveBall(GameObject curretPath, Vector2 mousePos)
    {
        curretPath.GetComponentInParent<GameManager>().isMoving = true;
        path = curretPath;
        direction = new Vector3(mousePos.x, mousePos.y, -0.03f) - ball.transform.position;
        //Debug.Log(direction + "");
    }

    public void Tick()
    {
        if (path != null)
        {
            if (path.GetComponentInParent<GameManager>().isMoving)
            {
                ball.transform.position += direction * Time.deltaTime * 5;
            }
            //Debug.Log(Vector3.Distance(lastPosition, ball.transform.position));   path.GetComponent<InfoPath>().
        }
    }
}