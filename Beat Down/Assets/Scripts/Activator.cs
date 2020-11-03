using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    GameObject note;

    Color old;


    void Awake(){
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        old = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key))
            StartCoroutine(Pressed());


        if(Input.GetKeyDown(key) && active){
            Destroy(note);
        }

    }

    void OnTriggerEnter2D(Collider2D col){
        active = true;
        if(col.gameObject.tag=="Note")
            note= col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col){
        active = false;
    }

    IEnumerator Pressed(){

        sr.color = Color.grey;
        yield return new WaitForSeconds(0.2f);
        sr.color = old;

    }
}
