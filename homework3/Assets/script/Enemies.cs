using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] int Enemy_Speed = 1;
    [SerializeField] Transform Player;
    [SerializeField] int area;
    int heals = 2;


    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void Hurt(int count)
    {
        heals -= count;
        if (heals <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        if ((transform.position - Player.position).magnitude <= area && (transform.position - Player.position).magnitude >= 3f)
        {
            transform.LookAt(Player);
            transform.Translate(transform.forward * Enemy_Speed * 10 * Time.deltaTime);
        }
        print(Vector3.Distance(transform.position, Player.position));
    }

}
    
