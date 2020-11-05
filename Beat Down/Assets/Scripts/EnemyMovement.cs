using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private CharacterAnimation enemyAnim;

    private Rigidbody myBody;
    public float speed = 5f;

    public float attackDistance = 1f;
    private float chase_Player_After_Attack = 1f;

    private float current_Attack_Time;
    private float default_Attack_Time = 2f;

    private bool followPlayer, attackPlayer;

    public Transform playerTarget;

    private void Awake()
    {
        enemyAnim = GetComponentInChildren<CharacterAnimation>();
        myBody = GetComponent<Rigidbody>();

        playerTarget = GameObject.FindWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
      //  StartCoroutine(WaitOnCreation());
        followPlayer = true;
        current_Attack_Time = default_Attack_Time;
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
        Attack();
    }

    void FollowTarget()
    {
        if (!followPlayer)
            return;
        if(Vector3.Distance(transform.position, playerTarget.position) > attackDistance)
        {
            transform.LookAt(playerTarget);
            myBody.velocity = transform.forward * speed;
            if(myBody.velocity.sqrMagnitude != 0)
            {
                enemyAnim.Walk(true);
            }
        }else if (Vector3.Distance(transform.position, playerTarget.position) <= attackDistance)
        {
            myBody.velocity = Vector3.zero;
            enemyAnim.Walk(false);
            followPlayer = false;
            attackPlayer = true;
        }
    }

    void Attack()
    {
        if (!attackPlayer)
            return;
        current_Attack_Time += Time.deltaTime;
        if(current_Attack_Time > default_Attack_Time)
        {
            enemyAnim.EnemyAttack(Random.Range(0, 3));
            current_Attack_Time = 0f;
        }
        if(Vector3.Distance(transform.position, playerTarget.position) > attackDistance + chase_Player_After_Attack)
        {
            attackPlayer = false;
            followPlayer = true;
        }
    }

    //IEnumerator WaitOnCreation() {
    //  yield return new WaitForSecondRealtime(2);
    //}

}
