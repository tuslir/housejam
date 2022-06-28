using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public void MoveForward()
    {
            transform.position += Vector3.forward;
    }

    public void MoveBackward()
    {
            transform.position += Vector3.back;
    }

    public void MoveLeft()
    {
            transform.position += Vector3.left;
    }

    public void MoveRight()
    {
            transform.position += Vector3.right;
    }

}

