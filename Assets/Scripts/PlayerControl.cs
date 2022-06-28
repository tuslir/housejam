using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public PlayerMove playerMove;
    public PlayerRotate playerRotate;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerMove.MoveLeft();
            playerRotate.RotateLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerMove.MoveRight();
            playerRotate.RotateRight();

        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerMove.MoveForward();
            playerRotate.RotateForward();

        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerMove.MoveBackward();
            playerRotate.RotateBackward();

        }


    }
}
