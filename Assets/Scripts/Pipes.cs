using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    private float LeftEdge;

    private void Start()
    {
        LeftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < LeftEdge)
        {
            Destroy(gameObject);
        }
    }
}