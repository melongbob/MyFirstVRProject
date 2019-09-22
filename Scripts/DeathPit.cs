using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPit : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            Debug.Log("GAME OVER!");
        }
    }

    public float x = 0.01f;
    public float y = 0.01f;
    public float z = 0.01f;

    private int count = 0;
    private bool isContracting = false;
    void Update()
    {
        count++;
        if (count == 50)
        {
            isContracting = !isContracting;
            count = 0;
        }

        if (isContracting)
            transform.localScale -= new Vector3(x, y, z);
        else
            transform.localScale += new Vector3(x, y, z);
    }
}
