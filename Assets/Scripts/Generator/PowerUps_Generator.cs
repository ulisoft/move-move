using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps_Generator : MonoBehaviour
{
    public GameObject PowerUps;
    float TiempoDeEspera = 1f;

    void Start()
    {
        TiempoDeEspera = Random.Range(20f, 31f);
        InvokeRepeating("GeneradorDePowerUp", TiempoDeEspera, Random.Range(25f, 41f));
    }

    void GeneradorDePowerUp()
    {
        var selectedPowerUp = GameObject.Find("Inmunidad");
        //El empty GameObj que a partir de ahi se genera el Fire
        var PowerUpGenerator = GameObject.Find("PowerUps_Generator");
        //Al no haber un fire porque selectedFire dio null genera el Fire

        if (selectedPowerUp == null)
        {
            Vector3 PowerUp1= PowerUpGenerator.transform.position + Vector3.right * Random.Range(-2, 3);
            Instantiate(PowerUps, PowerUp1, Quaternion.identity); //Genera el Power Up de inmunidad
        }
    }
}

//Vector3 Generador2 = FireGenerator.transform.position + Vector3.down * Random.Range(-11.0f, 10.0f) + Vector3.right * 1f;
//Vector3 Generador3 = FireGenerator.transform.position + Vector3.down * Random.Range(-11.0f, 10.0f) + Vector3.left * 2f;
//Vector3 Generador4 = FireGenerator.transform.position + Vector3.up * Random.Range(-11.0f, 10.0f) + Vector3.right * 2f;
//Instantiate(PowerUps, Generador2, Quaternion.identity); 
//Instantiate(fire, Generador3, Quaternion.identity);
//Instantiate(fire, Generador4, Quaternion.identity); 
//Instantiate(fire, FireGenerator.transform.position, Quaternion.identity);

