using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPText : MonoBehaviour
{
    public string name;
    ParticleSystem system;
    public int prevMult;
    // Start is called before the first frame update
    void Start()
    {
        system = GetComponentInChildren<ParticleSystem>();
        prevMult = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(name) + "";

    }

    public void playAnim(){
        if (name == "Mult"){

                system.Play();

        }
    }
}
