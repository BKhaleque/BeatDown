using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    int multiplier=2;
    int streak=0;
    int addnumber=8;
    int basescore=100;


    void Awake(){
      if(PlayerPrefs.GetInt("Pause") == 0){
        PlayerPrefs.SetInt("Pause", 1);
      }
    }
    // Start is called before the first frame update
    void Start()
    {
      QualitySettings.vSyncCount = 0;
      Application.targetFrameRate = 60;

        PlayerPrefs.SetInt("Streak",0);
        PlayerPrefs.SetInt("RockMater",25);
        PlayerPrefs.SetInt("Mult",1);
        PlayerPrefs.SetInt("HighStreak",0);
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.SetString("Win","No");
        int[] timeline1={1,2,3,2,2,1,1,1,2,1,1,2,3,2,2,1,1,1,2,1,1,3,1,2,2,1,1,1,2,1,1,3,1,2,2,1,1,1,2,1,4,1,3,2,2,4,4,1,3,2,2,4,1,2,2,1,4,1,3,2,2,4,1,2,2,1,1,2,3,2,2,1,1,1,2,1,1,1,2,1,1,2,1};
        PlayerPrefsX.SetIntArray("timeline1",timeline1);
        int[] timeline2={3,3,4,2,2,1,1,1,2,1,1,3,4,2,2,1,1,1,2,1,1,3,4,2,2,1,1,1,2,1,1,3,4,2,2,1,1,1,2,1,4,1,3,2,2,4,1,2,3,2,2,1,1,1,2,1,1,2,3,2,2,1,1,1,2,1,1,3,1,2,2,1,1,1,2,1,1,1,2,1,1,2,1};
        PlayerPrefsX.SetIntArray("timeline2",timeline2);
        int[] timeline3={1,3,1,2,2,1,1,1,2,1,1,3,1,2,2,1,1,1,2,1,4,1,3,2,2,4,1,2,2,1,4,1,3,2,2,4,1,2,2,1,4,1,3,2,2,4,1,3,1,2,2,1,1,1,2,1,1,3,1,2,2,1,1,1,2,1,4,1,3,2,2,4,1,2,2,1,2,2,1,1,2,1,1};
        PlayerPrefsX.SetIntArray("timeline3",timeline3);
        int[] timeline4={4,1,3,2,2,4,1,2,2,1,4,1,3,2,2,4,1,2,2,1,1,2,3,2,2,1,1,1,2,1,1,2,3,2,2,1,1,1,2,1,4,1,3,2,2,4,3,3,4,2,2,1,1,1,2,1,1,3,4,2,2,1,1,1,2,1,1,3,4,2,2,1,1,1,2,1,1,1,2,1,1,2,1};
        PlayerPrefsX.SetIntArray("timeline4",timeline4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addStreak(){
        if(PlayerPrefs.GetInt("RockMater")<100){
            PlayerPrefs.SetInt("RockMater", PlayerPrefs.GetInt("RockMater")+1);
        }
        streak++;
        multiplier=streak/addnumber+1;
        GameObject canvas = GameObject.Find("Canvas");
        PPText ppText = canvas.GetComponentInChildren<PPText>();
        ppText.playAnim();

        if(streak>PlayerPrefs.GetInt("HighStreak"))
        {
            PlayerPrefs.SetInt("HighStreak",streak);
        }

        updateGUI();
    }

    public int GetScore(){
        return basescore*multiplier;
    }

    void updateGUI(){
        PlayerPrefs.SetInt("Streak",streak);
        PlayerPrefs.SetInt("Mult",multiplier);
    }

    public void ResetStreak()
    {
        if(PlayerPrefs.GetInt("RockMater")>=2){
            PlayerPrefs.SetInt("RockMater", PlayerPrefs.GetInt("RockMater")-2);
        }
        else
        {
            PlayerPrefs.SetInt("RockMater", 0);
        }
        streak=0;
        multiplier=1;
        updateGUI();
        print("reset!");
    }

    public void win()
    {
        print("you win");
    }

}
