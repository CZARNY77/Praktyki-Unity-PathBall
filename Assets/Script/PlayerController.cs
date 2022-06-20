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
        //---------------------------Zmina koloru po najechaniu---------------------

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        LayerMask mask = LayerMask.GetMask("Path");
        RaycastHit2D hit = Physics2D.Raycast(mousePos, -Vector2.zero, mask);
       
        if(hit && hit.collider.gameObject.layer == 9)
        {
            GameObject CurrentPath = hit.collider.gameObject;
            if ((LastPath) && (LastPath != CurrentPath)) _path.GetOutOnPath(LastPath);
            if (CurrentPath)
            {
                _path.HoverOnPath(CurrentPath);
                LastPath = CurrentPath;

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    _path.DeactivationPath(CurrentPath);
                    //CurrentPath.GetComponent<InfoPath>().isMoving = true;
                    _ball.moveBall(CurrentPath);
                }
            }
            
        }
        else
        {
            if (LastPath) _path.GetOutOnPath(LastPath);
        }

    }
}
