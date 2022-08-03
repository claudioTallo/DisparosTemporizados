using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject munition;
    public GameObject munition2;
    public float waitingTime = 0.5f;
    public float repetitionTime = 0.5f;


    void Start()
    {
        InvokeRepeating("Shoot", waitingTime, repetitionTime);
        //                Método        Espera    Tiempo de Repetición
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Shoot()
    {   
        Debug.Log("DISPARAR");

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(munition2, transform.position, transform.rotation);
        }

        Instantiate(munition, transform.position, transform.rotation);
    }
}
