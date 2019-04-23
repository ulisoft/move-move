using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirmacion : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0, 0, 0);
        }

        if (transform.position.x < -6f)
        {
            transform.position = new Vector3(-6f, 0, 0);
        }
    }
}
