using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackUniversal : MonoBehaviour
{
    public bool is_Player, is_Enemy;
    public GameObject hit_FX;
    public GameObject enemy_exp;
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;
    private bool enemyKilled;
    private GameObject spawner;
    private EnemySpawner enemySpawner;
    //private CharacterAnimation enemyDeath;

    //PlayerAttack playerAttack;

    void Start()
    {

        spawner = GameObject.FindWithTag("EnemySpawner");
        enemySpawner = spawner.GetComponent<EnemySpawner>();
        //enemyDeath = GameObject.FindWithTag(Tags.ENEMY_TAG).GetComponentInChildren<CharacterAnimation>();
    }


    void Update()
    {
        DetectCollision();
        if (enemyKilled)
        {
            enemySpawner.Spawn();
           enemyKilled = false;
        }
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
                if(playerHealth.health <= 0)
                {
                    SceneManager.LoadScene("Highscore");
                }
            }else if(hit[0].gameObject.tag == "Enemy")
            {
                Vector3 hitFX_Pos = hit[0].transform.position;
                hitFX_Pos.y += 2.8f;
                hitFX_Pos.x -= 0.5f;
                Instantiate (hit_FX, hitFX_Pos, Quaternion.identity);

                EnemyHealth enemyHealth = hit[0].gameObject.GetComponent<EnemyHealth>();
                enemyHealth.health -= 2;
                if(enemyHealth.health <= 0)
                {
                    Vector3 enemy_exp_Pos = hit[0].transform.position;
                    enemy_exp_Pos.y += 1.8f;
                    enemy_exp_Pos.x -= 0.5f;
                    Instantiate (enemy_exp, enemy_exp_Pos, Quaternion.identity);
                    Destroy(hit[0].gameObject);
                    enemyKilled = true;


                }
            }
            gameObject.SetActive(false);
        }
    }

}
