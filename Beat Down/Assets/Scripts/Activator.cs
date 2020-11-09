using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    GameObject note, gm;
    public bool createMode, missed;
    Color old;
    public GameObject n;
    float current_Attack_Time = 0f;
    int highScore;

    float default_attack_time = 2f;
    void Awake(){
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.Find("GameManager");
        old = sr.color;
        missed = false;
        highscore = PlayerPrefs.GetInt("HighScore");
    }

    //add to score and replace high score if needed
    void AddScore(){
        
        PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+gm.GetComponent<GM>().GetScore());
        if (PlayerPrefs.GetInt("Score")> highScore)
        {
            highScore = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score") + gm.GetComponent<GM>().GetScore());
        }
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
                gm.GetComponent<GM>().addStreak();
                Destroy(note);
                AddScore();
                active=false;
            }
            else if(Input.GetKeyDown(key)&&!active)
            {
                gm.GetComponent<GM>().ResetStreak();
                missed = true;
            }
        }
        if (missed)
        {
            current_Attack_Time += Time.deltaTime;
            if (current_Attack_Time> default_attack_time)
            {
                missed = false;
                current_Attack_Time = 0f;
            }
        }
        

    }

    void OnTriggerEnter2D(Collider2D col){
        active = true;
        if(col.gameObject.tag=="Note")
        {
            active = true;
            note= col.gameObject;
        }
        if(col.gameObject.tag=="WinNote")
        {
            PlayerPrefs.SetString("Win","Yes");
        }    
    }

    void OnTriggerExit2D(Collider2D col){
        active = false;
        //gm.GetComponent<GM>().ResetStreak();
    }

    IEnumerator Pressed(){

        sr.color = Color.grey;
        yield return new WaitForSeconds(0.2f);
        sr.color = old;

    }
}
