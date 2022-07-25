using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour

    
{

    public Vector3 direction = new Vector3(0f, 0.3f, 1f);
    public float speed = 30f;
    public int Damage = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
