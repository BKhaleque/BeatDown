using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    private CharacterAnimation player_Anim;

    private Rigidbody myBody;
    
    public float walk_Speed = 3f;
    public float z_Speed = 1.5f;

    private float rotation_Y = -90f;
    private float rotation_Speed = 15f;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        player_Anim = GetComponentInChildren<CharacterAnimation>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        AnimatePlayerWalk();
        RotatePlayer();
    }

    private void FixedUpdate()
    {
        DetectMoveMent();
   
    }


    void DetectMoveMent()
    {
        myBody.velocity = new Vector3(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) * walk_Speed, myBody.velocity.y, Input.GetAxisRaw(Axis.VERTICAL_AXIS) * z_Speed);
    }

    void RotatePlayer()
    {
        if(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS)>0)
        {
            transform.rotation = Quaternion.Euler(0f, -Mathf.Abs(rotation_Y), 0);
        }else if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotation_Y), 0);
        }
    }


    void AnimatePlayerWalk()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) != 0 || Input.GetAxisRaw(Axis.VERTICAL_AXIS) != 0)
        {
            player_Anim.Walk(true);
        }
        else
        {
            player_Anim.Walk(false);
        }
    }





}
