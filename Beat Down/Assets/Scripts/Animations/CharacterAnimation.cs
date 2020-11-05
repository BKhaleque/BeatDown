using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk(bool move)
    {
        anim.SetBool(Animation_Tag.MOVEMENT, move);
    }

    public void Punch_1()
    {
        anim.SetTrigger(Animation_Tag.PUNCH_1_TRIGGER);
    }
    public void Punch_2()
    {
        anim.SetTrigger(Animation_Tag.PUNCH_2_TRIGGER);
    }

    public void Punch_3()
    {
        anim.SetTrigger(Animation_Tag.PUNCH_3_TRIGGER);
    }

    public void Kick_1()
    {
        anim.SetTrigger(Animation_Tag.KICK_1_TRIGGER);
    }

    public void Kick_2()
    {
        anim.SetTrigger(Animation_Tag.KICK_2_TRIGGER);
    }


    //Enemy Charecter Animaion

    public void EnemyAttack(int attack)
    {
        if(attack == 0)
        {
            anim.SetTrigger(Animation_Tag.ATTACK_1_TRIGGER);
        }
        if (attack == 1)
        {
            anim.SetTrigger(Animation_Tag.ATTACK_2_TRIGGER);
        }

        if (attack == 2)
        {
            anim.SetTrigger(Animation_Tag.ATTACK_3_TRIGGER);
        }
    }

    public void Play_IdleAnimation()
    {
        anim.Play(Animation_Tag.IDLE_ANIMATION);
    }
    public void KnockDown()
    {
        anim.SetTrigger(Animation_Tag.KNOCK_DOWN_TRIGGER);
    }
    public void StandUp()
    {
        anim.SetTrigger(Animation_Tag.STANT_UP_TRIGGER);
    }

    public void Hit()
    {
        anim.SetTrigger(Animation_Tag.HIT_TRIGGER);
    }

    public void Death()
    {
        anim.SetTrigger(Animation_Tag.DEATH_TRIGGER);
    }

}
