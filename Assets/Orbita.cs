using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{
    GameObject sol;
    public Transform center;
    public Vector3 axis = Vector3.up;
    public Vector3 desiredPosition;
    public float radius;
    public float radiusSpeed = 0.5f;
    public float rotationSpeed = 80.0f;
    // Start is called before the first frame update
    void Start()
    {
        sol = GameObject.FindWithTag("sol");
        center = sol.transform;
        transform.position = (transform.position - center.position).normalized * radius + center.position;
        // radius = 5.0f;



    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.position, axis, rotationSpeed * Time.deltaTime);
        desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
    }
}
