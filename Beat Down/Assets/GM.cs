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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addStreak(){
        streak++;
        multiplier=streak/addnumber+1;
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
        streak=0;
        multiplier=1;
        updateGUI();
    }
}
