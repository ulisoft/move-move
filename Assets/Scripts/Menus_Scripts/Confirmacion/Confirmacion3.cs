using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirmacion3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0)
        {
            transform.position = new Vector3(0, 0, 0);
        }

        if (transform.position.y < -9f)
        {
            transform.position = new Vector3(0, -9f, 0);
        }
    }
}
