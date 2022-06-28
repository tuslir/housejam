using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public float gridSize = 1f;
    public float moveSpeed = 1f;
    public float rotateSpeed = 360.0f;

    private Vector3 pos;
    private Transform tr;
    private Quaternion rot;

    private float degree;
    private float angle;

    [Header("Movement Keys")]
    public KeyCode forwardKey = KeyCode.UpArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode backKey = KeyCode.DownArrow;
    public KeyCode rightKey = KeyCode.RightArrow;
    [Space(1)]
    public KeyCode turnLeftKey = KeyCode.Q;
    public KeyCode turnRightKey = KeyCode.E;

    void Start()
    {
        pos = transform.position;
        tr = transform;
        rot = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKey(forwardKey) && tr.position == pos)
        {
            pos += Vector3.forward * gridSize;
        }

        else if (Input.GetKey(leftKey) && tr.position == pos)
        {
            pos += Vector3.left * gridSize;
        }

        else if (Input.GetKey(backKey) && tr.position == pos)
        {
            pos += Vector3.back * gridSize;
        }

        else if (Input.GetKey(rightKey) && tr.position == pos)
        {
            pos += Vector3.right * gridSize;
        }

        else if (Input.GetKey(turnLeftKey) && tr.position == pos && Mathf.Approximately(degree, transform.rotation.eulerAngles.y) == true)
        {
            degree = Mathf.Repeat(degree - 90f, 360f);
        }

        else if (Input.GetKey(turnRightKey) && tr.position == pos && Mathf.Approximately(degree, transform.rotation.eulerAngles.y) == true)
        {
            degree = Mathf.Repeat(degree + 90f, 360f);
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * moveSpeed);
        angle = Mathf.MoveTowardsAngle(transform.rotation.y, degree, Time.deltaTime * 20f);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, degree, 0), Time.deltaTime * rotateSpeed);
    }
}
