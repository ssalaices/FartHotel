using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class Fly : MonoBehaviour
{

    [SerializeField] GameObject cube;
    Vector3 cubePosition;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = cube.GetComponent<Rigidbody>();
    }

    void Update()
    {
        cubePosition = cube.transform.position;
        UnityEngine.Debug.Log(cubePosition);
        rb.AddForce(10, 1, 0);
    }
}
