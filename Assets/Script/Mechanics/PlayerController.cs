using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerController : IInitializable ,ITickable
{
    [Inject] Path _path;
    [Inject] Ball _ball;
    GameObject LastPath;

    public void Initialize()
    {

    }

    public void Tick()
    {
        //przerób na ³adny kod

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        LayerMask mask = LayerMask.GetMask("Path");
        RaycastHit2D hit = Physics2D.Raycast(mousePos, -Vector2.zero, mask);
       
        if(hit && hit.collider.gameObject.layer == 9)
        {
            GameObject CurrentPath = hit.collider.gameObject;
            GameManager gameM = CurrentPath.GetComponentInParent<GameManager>();
            InfoPath infoP = CurrentPath.GetComponentInParent<InfoPath>();

            if (infoP.isBall && infoP.isActive && !gameM.isMoving && gameM._state == State.Play)
            {
                if ((LastPath) && (LastPath != CurrentPath)) _path.GetOutOnPath(LastPath);
                if (CurrentPath)
                {
                    _path.HoverOnPath(CurrentPath, gameM);
                    LastPath = CurrentPath;

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        _path.DeactivationPath(CurrentPath);
                        _ball.moveBall(CurrentPath);

                        gameM.start = true; // <- to to poprawy 
                        gameM.switch_player();

                        
                    }

                }
            }
        }
        else
        {
            if (LastPath)   _path.GetOutOnPath(LastPath);
        }

    }
}
