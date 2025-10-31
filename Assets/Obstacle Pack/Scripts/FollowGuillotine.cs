using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGuillotine : MonoBehaviour
{
    public Transform blade; // arrastra aquí la cuchilla animada

    void Update()
    {
        transform.position = blade.position;
        transform.rotation = blade.rotation;
    }
}
