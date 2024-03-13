using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float reduction = 10f;
    // Update is called once per frame
    void Update()
    {
        Vector3 go = new Vector3(Input.GetAxis("Vertical")/reduction, 0, -Input.GetAxis("Horizontal")/reduction);
        transform.SetPositionAndRotation(transform.position + go, transform.rotation);
    }
}
