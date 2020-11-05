using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private CharacterAnimation player_Anim;

    private void Awake()
    {

        player_Anim = GetComponentInChildren<CharacterAnimation>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ComboAttacks();
    }

    void ComboAttacks()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            player_Anim.Punch_1();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            player_Anim.Punch_2();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            player_Anim.Punch_3();
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            player_Anim.Kick_1();
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            player_Anim.Kick_2();
        }

    }

}
