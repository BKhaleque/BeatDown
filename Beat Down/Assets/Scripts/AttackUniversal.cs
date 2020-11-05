using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{
    public bool is_Player, is_Enemy;
    public GameObject hit_FX;
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }

    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);
        if(hit.Length > 0)
        {
            print("We Hit The " + hit[0].gameObject.name);
           if(hit[0].gameObject.name == "Player")
            {
                PlayerHealth playerHealth = hit[0].gameObject.GetComponent<PlayerHealth>();
                playerHealth.health -= 2;
            }
            gameObject.SetActive(false);
        }
    }

}
