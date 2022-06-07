using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float player_speed;
    private Vector3 Vector3_player_Direction = Vector3.zero;
    float timer = 0;
    
    
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3_player_Direction * player_speed * 10 * Time.deltaTime);
    }
    
    void Update()
    {
        Vector3_player_Direction.x = Input.GetAxis("Horizontal"); 
        Vector3_player_Direction.z = Input.GetAxis("Vertical");

        

    }


}
