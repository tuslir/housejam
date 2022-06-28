using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{

    public GameObject cube;

    void Update()
    {

        if (cube.transform.position.x >= 8) cube.transform.position = new Vector3(8, cube.transform.position.y, cube.transform.position.z);
        if (cube.transform.position.x <= -8) cube.transform.position = new Vector3(-8, cube.transform.position.y, cube.transform.position.z);

        if (cube.transform.position.z >= 8) cube.transform.position = new Vector3(cube.transform.position.x, cube.transform.position.y, 8);
        if (cube.transform.position.z <= -8) cube.transform.position = new Vector3(cube.transform.position.x, cube.transform.position.y, -8);


    }
}
