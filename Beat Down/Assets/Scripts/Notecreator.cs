using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Notecreator : MonoBehaviour
{
    public string timelinename;
    public GameObject n;
    int time = 1;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        create();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void create()
    {
        int[] timeline=PlayerPrefsX.GetIntArray(timelinename);
        GameObject newNote = Instantiate(n,transform.position,Quaternion.identity);
        SpriteRenderer sr = newNote.GetComponent<SpriteRenderer>();
        if(i >= timeline.Length)
        {
            return;
        }
        time = timeline[i];
        if(time==1)
        {
            //sr.color=Color.red;
        }
        if(time==2)
        {
            //sr.color=Color.blue;
        }
        if(time==3)
        {
            //sr.color=Color.green;
        }
        i++;
        Invoke("create", time);
    }
}
