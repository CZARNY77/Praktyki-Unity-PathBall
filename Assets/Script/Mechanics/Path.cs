using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Path
{
    // Te if z isActive dublikuja sie z if w PlayerController
    public void HoverOnPath(GameObject path)
    {
        if(path.GetComponent<InfoPath>().isActive)
        path.GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
    }
    public void GetOutOnPath(GameObject path)
    {
        if(path.GetComponent<InfoPath>().isActive)
        path.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.67f);
    }
    public void DeactivationPath(GameObject path)
    {
        if (path.GetComponent<InfoPath>().isActive)
        {
            path.GetComponent<InfoPath>().isActive = false;
            path.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
            path.SetActive(false);
        }
    }
}
