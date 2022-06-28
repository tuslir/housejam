using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSide : MonoBehaviour
{
    public GameObject cube;
    public static Side currentSide;
    public Side option;
    public bool one, two, three, four, five, six;

    public enum Side
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six
    }

    private void Start()
    {
        currentSide = Side.Six;
    }

    Side CheckingSide(Side side)
    {
        if (cube.transform.rotation.x == -90) side = Side.One;
        if (cube.transform.rotation.x == 90) side = Side.Two;

        if (cube.transform.rotation.z == -90) side = Side.Three;
        if (cube.transform.rotation.z == 90) side = Side.Four;

        if (cube.transform.rotation.x == 180
            || cube.transform.rotation.x == -180
            || cube.transform.rotation.z == 180
            || cube.transform.rotation.z == -180) side = Side.Five;

        if (cube.transform.rotation.x == 0) side = Side.Six;

        return side;
    }

    private void Update()
    {


    }


}
