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
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(mousePos);
        LayerMask mask = LayerMask.GetMask("Path");
        RaycastHit2D hit = Physics2D.Raycast(mousePos, -Vector2.zero, mask);
       
        if(hit && hit.collider.gameObject.layer == 9)
        {
            GameObject CurrentPath = hit.collider.gameObject;
            if(CurrentPath.GetComponent<InfoPath>().isBall && CurrentPath.GetComponent<InfoPath>().isActive)
            {
                if ((LastPath) && (LastPath != CurrentPath)) _path.GetOutOnPath(LastPath);
                if (CurrentPath)
                {
                    _path.HoverOnPath(CurrentPath);
                    LastPath = CurrentPath;

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        _path.DeactivationPath(CurrentPath);
                        _ball.moveBall(CurrentPath, mousePos);

                        CurrentPath.GetComponentInParent<GameManager>().start = true; // <- to to poprawy 
                        CurrentPath.GetComponentInParent<GameManager>().switch_player();
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
