using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnengyBar : MonoBehaviour
{
    float start=1;
    float end=7;
    int RockMaster=25;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector3(start+(end-start)*RockMaster/100,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        RockMaster=PlayerPrefs.GetInt("RockMater");
        transform.position=new Vector3(start+(end-start)*RockMaster/100,1,0);
    }
}
