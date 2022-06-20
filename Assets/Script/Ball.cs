using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Ball
{
    GameObject ball;

    public Ball(GameObject Ball)
    {
        ball = Ball;
    }
    public void moveBall(GameObject curretPath)
    {
        //ball.transform.position += (2.45f * temp);
        curretPath.GetComponent<InfoPath>().isMoving = true;
    }
    
}
