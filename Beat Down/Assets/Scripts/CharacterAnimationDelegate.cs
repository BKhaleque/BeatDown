using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{

    public GameObject left_Arm_Attack, right_Arm_Attack, left_Leg_Attack_Point, right_Leg_Attack_Point;

    void Left_Arm_Attack_On()
    {
        left_Arm_Attack.SetActive(true);
    }

    void Left_Arm_Attack_Off()
    {
        if (left_Arm_Attack.activeInHierarchy)
        {
            left_Arm_Attack.SetActive(false);
        }
    }

    void Right_Arm_Attack_On()
    {
        right_Arm_Attack.SetActive(true);
    }

    void Right_Arm_Attack_Off()
    {
        if (right_Arm_Attack.activeInHierarchy)
        {
            right_Arm_Attack.SetActive(false);
        }
    }

    void Left_Leg_Attack_On()
    {
        left_Leg_Attack_Point.SetActive(true);
    }

    void Left_Leg_Attack_Off()
    {
        if (left_Leg_Attack_Point.activeInHierarchy)
        {
            left_Leg_Attack_Point.SetActive(false);
        }
   
    }

    void Right_Leg_Attack_On()
    {
          right_Leg_Attack_Point.SetActive(true);

    }

    void Right_Leg_Attack_Off()
    {
        if (right_Leg_Attack_Point.activeInHierarchy)
        {
            right_Leg_Attack_Point.SetActive(false);
        }

    }
}
