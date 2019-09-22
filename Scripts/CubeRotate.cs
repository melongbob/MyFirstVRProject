using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float RotationSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));   
    }
}
