using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NoteCatcher : MonoBehaviour
{
    Activator[] acts;

    GameObject[] activators;

    // Start is called before the first frame update
    void Start()
    {
        activators = GameObject.FindGameObjectsWithTag("Activator");
        acts = new Activator[activators.Length];
        for (int i = 0; i < activators.Length; i++)
        {
            acts[i] = activators[i].GetComponent<Activator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

      if(other.gameObject.tag == "Note")
        {
            acts[0].missed = true;
        //    acts[1].missed = true;
        //    acts[2].missed = true;
        //    acts[3].missed = true;
        }
        Destroy(other.gameObject);
        UnityEngine.Debug.Log("Caught Note");
    }
}
