using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    GameObject note, gm;
    public bool createMode;
    Color old;
    public GameObject n;
    void Awake(){
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.Find("GameManager");
        old = sr.color;
    }

    void AddScore(){
        PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+gm.GetComponent<GM>().GetScore());
    }

    // Update is called once per frame
    void Update()
    {
        if(createMode){
            if(Input.GetKeyDown(key)){
                Instantiate(n,transform.position,Quaternion.identity);
            }
        }
        else
        {
            
            if(Input.GetKeyDown(key)){
                StartCoroutine(Pressed());
            }
            if(Input.GetKeyDown(key)&&active){
                Destroy(note);
                AddScore();
                active=false;
            }
            else if(Input.GetKeyDown(key)&&!active)
            {
                gm.GetComponent<GM>().ResetStreak();
            }
        }

    }

    void OnTriggerEnter2D(Collider2D col){
        active = true;
        if(col.gameObject.tag=="Note")
            note= col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col){
        active = false;
        gm.GetComponent<GM>().ResetStreak();
    }

    IEnumerator Pressed(){

        sr.color = Color.grey;
        yield return new WaitForSeconds(0.2f);
        sr.color = old;

    }
}
