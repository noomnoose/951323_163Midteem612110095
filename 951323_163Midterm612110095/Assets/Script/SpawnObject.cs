using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Transform[] points;
    public float InvokeRate = 1.0f;
    public GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PickPoint", 1.0f, InvokeRate);
    }

    // Update is called once per frame
    void PickPoint()
    {
        int IndexNumber = Random.Range(0, points.Length);
        Instantiate(Sphere, points[IndexNumber].position, Sphere.transform.rotation);

    }
}
