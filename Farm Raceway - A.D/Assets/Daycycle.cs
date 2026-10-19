using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour
{
    public GameObject lightSource;
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
    }
}
