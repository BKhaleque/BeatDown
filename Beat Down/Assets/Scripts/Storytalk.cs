using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Description : MonoBehaviour
{
    private string[] story1={"Egnever woke up from the darkness, his memory was blurred and his thinking was confused. There was only one thought in his mind: revenge. ",
        "But he deeply felt his own powerlessness, not even the strength to crawl out of this pit. At this time he touched the idol beside him. He grasped it tightly and prayed.",
		"Egnever: Goddess, please give me the power of revenge, I am willing to give everything for it.",
        "He prayed in his heart over and over again.",
        "Muse: Don't bother me. I am just a god of music and dance. In this chaotic world, people have forgotten art.",
        "Egnever: well. . . but. . .",
        "Muse (monologue): But after all I am a merciful goddess. I decided to help this person definitely not because I was afraid of being completely forgotten by people.",
        "Muse: I decided to give you strength, but you must spread my name.",
        "Muse: Follow your inner music.",
        "In Egnever's doubts, the goddess disappeared. He just felt that there were notes in him ready to come out.",
        "end"};
	//index of talk
	private int index=0;
	//
	public Texture mTalkIcon;

	private bool isTalk=false;

    public Transform parent;

    public Font newFont;

    int stageNmuber=0;

    public GameObject text;

    
    // Start is called before the first frame update
    void Start()
    {
        stageNmuber=PlayerPrefs.GetInt("StageNmuber");
        stageNmuber=0;
    }

    // Update is called once per frame
    void Update()
    {
        string[] story=story1;
        if(PlayerPrefs.GetInt("StageNmuber")==0)
        {
            story=story1;
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(story[index]=="end")
            {

            }
            else
            {
                if(index<story.Length)
                {
                text.GetComponent<Text>().text=story[index];
                index=index+1;
                }else
                {
                    index=0;
                    text.GetComponent<Text>().text=story[index];	 
                }
            }
        }
    }
}

