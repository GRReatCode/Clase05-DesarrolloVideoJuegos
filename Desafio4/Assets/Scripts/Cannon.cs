using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject[] BalasPrefabs;
    public float TiempoEspera = 3f;
    public float TiempoIntervalo = 2f;
    public bool PuedoDisparar = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisparoSimple();
            Debug.Log("Disparo Simple con Barra");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            DisparoDoble();
            Debug.Log("Disparo Doble con J");
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            DisparoTriple();
            Debug.Log("Disparo Triple con K");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            DisparoCuadruple();
            Debug.Log("Disparo Cuadruple con L");
        }
    }
    private void DisparoSimple()
    {

        if (PuedoDisparar)
        {
            PuedoDisparar = false;
           Instantiate(BalasPrefabs[0], transform);
           Invoke("ResetDisparo", 1f);
        }
    }

    private void DisparoDoble()
    {

        if (PuedoDisparar)
        {
            PuedoDisparar = false;
            Instantiate(BalasPrefabs[0], transform);
            Instantiate(BalasPrefabs[1], transform);
            Invoke("ResetDisparo", 1f);
        }
    }

    private void DisparoTriple()
    {

        if (PuedoDisparar)
        {
            PuedoDisparar = false;
            Instantiate(BalasPrefabs[0], transform);
            Instantiate(BalasPrefabs[1], transform);
            Instantiate(BalasPrefabs[2], transform);
            Invoke("ResetDisparo", 1f);
        }
    }

    private void DisparoCuadruple()
    {

        if (PuedoDisparar)
        {
            PuedoDisparar = false;
            Instantiate(BalasPrefabs[0], transform);
            Instantiate(BalasPrefabs[1], transform);
            Instantiate(BalasPrefabs[2], transform);
            Instantiate(BalasPrefabs[3], transform);
            Invoke("ResetDisparo", 1f);
        }
    }

    private void ResetDisparo()
    {
        PuedoDisparar = true;
    }
}
