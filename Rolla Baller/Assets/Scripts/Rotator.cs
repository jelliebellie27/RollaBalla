using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public static float speed = 1f;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * speed * Time.deltaTime);

    }
}
