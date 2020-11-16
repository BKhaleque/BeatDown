using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float speed;


    void Awake(){
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float ss=speed;
        if(PlayerPrefs.GetInt("Pause")==1)
        {

            gameObject.transform.Translate(0.0f, 0.0f, 0.0f);

        }else if(PlayerPrefs.GetInt("Pause")==0)

        {
            gameObject.transform.Translate(0.0f, -speed, 0.0f);

        }


    }
}
