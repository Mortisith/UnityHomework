using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCreator : MonoBehaviour
{
    [SerializeField] GameObject GameObject_Slug;
    [SerializeField] Transform Transform_Slug_Spawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(GameObject_Slug, Transform_Slug_Spawn.position, Transform_Slug_Spawn.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
