using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public Transform earth;
    public float RotationSpeed;
    void Update()
    {
        transform.RotateAround(earth.position, Vector3.up, RotationSpeed* Time.deltaTime);
    }
}
