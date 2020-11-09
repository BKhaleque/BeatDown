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

    private bool enemyKilled;
    private GameObject spawner;
    private EnemySpawner enemySpawner;
    // Start is called before the first frame update
    void Start()
    {
        enemyKilled = false;
        spawner = GameObject.FindWithTag("EnemySpawner");
        enemySpawner = spawner.GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
        if (enemyKilled) // then spawn another enemy 
        {
            enemySpawner.Spawn();
           enemyKilled = false;
        }
    }

    //Check collision with player or enemy and take away health accordingly

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
                if(playerHealth.health <= 0)
                {
                    //end the game
                }
            }else if(hit[0].gameObject.tag == "Enemy")
            {
                EnemyHealth enemyHealth = hit[0].gameObject.GetComponent<EnemyHealth>();
                enemyHealth.health -= 2;
                if(enemyHealth.health <= 0)
                {
                    Destroy(hit[0].gameObject);
                    enemyKilled = true;
                }
            }
            gameObject.SetActive(false);
        }
    }

}
