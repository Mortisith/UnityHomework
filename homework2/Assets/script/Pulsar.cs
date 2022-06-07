using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsar : MonoBehaviour
{
    [SerializeField] int Damage = 1;


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
        
    }
}
