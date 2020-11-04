using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    int multiplier=2;
    int streak=0;
    int addnumber=8;
    int basescore=100;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Streak",0);
        PlayerPrefs.SetInt("RockMater",25);
        PlayerPrefs.SetInt("Mult",1);
        PlayerPrefs.SetInt("HighStreak",0);
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.SetString("Win","No");
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
