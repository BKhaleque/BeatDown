using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notecreator : MonoBehaviour
{
    int[] timeline={1,1,1};
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
        Instantiate(n,transform.position,Quaternion.identity);
        if(i >= timeline.Length)
        {
            return;
        }
        time = timeline[i];
        i++;
        Invoke("create", time);
    }
}
