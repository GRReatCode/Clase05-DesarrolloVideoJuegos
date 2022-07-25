using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject BalaPrefab;
    public float TiempoEspera = 3f;
    public float TiempoIntervalo = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", TiempoEspera, TiempoIntervalo);
        Debug.Log("Disparo inicial del cañon");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Disparo()
    {
        Instantiate(BalaPrefab,transform);
    }
}
