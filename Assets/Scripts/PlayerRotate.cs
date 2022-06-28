using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{

    public GameObject cube;
    int rotateAmount = 90;
    Vector3 rotateEulerAngles, resetEulerAngles;
    float yRotation;
    float xRotation;


    private void Update()
    {
    }

    public void RotateForward()
    {
        rotateEulerAngles += new Vector3(rotateAmount, 0, 0);
        cube.transform.localEulerAngles = rotateEulerAngles;
    }


    public void RotateBackward()
    {

        rotateEulerAngles += new Vector3(-rotateAmount, 0, 0);
        cube.transform.localEulerAngles = rotateEulerAngles;

    }

    public void RotateLeft()
    {

        rotateEulerAngles += new Vector3(0, 0, rotateAmount);
        cube.transform.localEulerAngles = rotateEulerAngles;
    }

    public void RotateRight()
    {

        rotateEulerAngles += new Vector3(0, 0, -rotateAmount);
        cube.transform.localEulerAngles = rotateEulerAngles;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(this.transform.position, Vector3.forward*10);

        Gizmos.DrawLine(this.transform.position, Vector3.left * 10);
        Gizmos.DrawLine(this.transform.position, Vector3.back * 10);

        Gizmos.DrawLine(this.transform.position, Vector3.right * 10);


    }

}
