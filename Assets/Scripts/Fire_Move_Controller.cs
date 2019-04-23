using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Move_Controller : MonoBehaviour {
    private Rigidbody2D RB;
    
    //public float speed;

    void Start()
    {
        if(this.gameObject.tag == "Fire")
        { 
            var velocidad = 1f * Random.Range(-14, -7);
            RB = GetComponent<Rigidbody2D>();
            RB.velocity = new Vector3(0, velocidad, 0);
        }
        if(this.gameObject.tag == "Asteroide")
        {
            RB = GetComponent<Rigidbody2D>();
            RB.velocity = new Vector3(0, -7f, 0);
            print("asteroide");
        }
        if (this.gameObject.tag == "AsteroideGrande")
        {
            RB = GetComponent<Rigidbody2D>();
            print("asteroidegrande");
            RB.velocity = new Vector3(0, -9f, 0);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -9f)
        {
            Destroy(gameObject);
        }

        if (PlayerPrefs.GetFloat("Termino") == 1)
        {
            Destroy(gameObject);
        }

    }

}