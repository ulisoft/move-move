using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D objeto)
    {
        if(this.gameObject.tag == "Inmunidad" && objeto.gameObject.tag == "Fire")
        {
            Destroy(objeto);
            print("Destrozado");
        }
        if (this.gameObject.tag == "Inmunidad" && objeto.gameObject.tag == "Asteroide")
        {
            Destroy(objeto);
            print("Destrozado");
        }
        if (this.gameObject.tag == "Inmunidad" && objeto.gameObject.tag == "AsteroideGrande")
        {
            print("Destrozado");
            Destroy(objeto);
        }
        if (this.gameObject.tag == "Inmunidad" && objeto.gameObject.tag == "Robot")
        {
            print("Destrozado");
            Destroy(objeto);
        }
        if(this.gameObject.tag == objeto.gameObject.tag && this.gameObject.tag != "Robot")
        {
            Destroy(objeto);
            Destroy(gameObject);
            print("Destrozado");
        }
    }
}
