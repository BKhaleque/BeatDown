using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnengyBar : MonoBehaviour
{
    float start=1;
    float end=7;
    int RockMaster= 25;

    void Start()
    {
        transform.position = new Vector3((start+(end-start)*RockMaster/100)-12.5f, 5.2f, 0);
    }


    void Update()
    {
        RockMaster=PlayerPrefs.GetInt("RockMater");
        transform.position = new Vector3((start+(end-start)*RockMaster/100)-12.5f, 5.2f,0);
    }
}
