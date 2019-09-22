using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPit : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("You WIN!");
        }
    }
}
