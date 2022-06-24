using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Players{
    Player_1,
    Player_2
}

public class Gate : MonoBehaviour
{
    public Players player;
    GameManager gameM;
    void Start()
    {
        gameM = GetComponentInParent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            gameM.isMoving = false;
            gameM._state = State.Pause;
            if (player == Players.Player_1) gameM.win(player);
            else if (player == Players.Player_2) gameM.win(player);
        }
    }
}
