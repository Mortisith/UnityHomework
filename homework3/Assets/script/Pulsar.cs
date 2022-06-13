using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsar : MonoBehaviour
{
    [SerializeField] int Damage = 2;
   
    [SerializeField] Transform Transform_Pulsar_Spawn;
    [SerializeField] int speed_shoot = 2;
   


    private void OnTriggerEnter(Collider other) 
    {
        var enemy = other.GetComponent<Enemies>();
        enemy.Hurt(Damage);
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            transform.Translate(Vector3.forward * speed_shoot * Time.deltaTime, Space.World);
        }
    }
}
