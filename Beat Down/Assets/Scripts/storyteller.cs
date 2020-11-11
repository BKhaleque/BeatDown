using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class storyteller : MonoBehaviour
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
    private string[] icon_story1={"","","1","","2","1","2","2","2","",""};
	//index of talk
	private int index=0;
	//
	private bool isTalk=false;

    public Font newFont;

    public int stageNmuber;

    public GameObject text,Icon,Iconmuse;

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
        string[] icon=icon_story1;
        if(PlayerPrefs.GetInt("StageNmuber")==0)
        {
            story=story1;
            icon=icon_story1;
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(story[index]=="end")
            {
                SceneManager.LoadScene("Scene2");
            }
            else
            {
                if(index<story.Length)
                {
                    index=index+1;
                }else
                {
                    index=0;
                }
                text.GetComponent<Text>().text=story[index];
                if(icon[index]=="")
                {
                    hidePicture(Icon.GetComponent<RawImage>());
                    hidePicture(Iconmuse.GetComponent<RawImage>());
                }
                else if(icon[index]=="1"){
                    presentPicture(Icon.GetComponent<RawImage>());
                    hidePicture(Iconmuse.GetComponent<RawImage>());
                }else if(icon[index]=="2"){
                    presentPicture(Iconmuse.GetComponent<RawImage>());
                    hidePicture(Icon.GetComponent<RawImage>());
                }
            }
        }
    }

    void hidePicture(RawImage image)
    {
        var r = image.color.r;
　　　　var g = image.color.g;
　　　　var b = image.color.b;
　　　　var alpha = 0;
　　　　image.color = new Color(r, g, b, alpha);
    }

    void presentPicture(RawImage image)
    {
        var r = image.color.r;
　　　　var g = image.color.g;
　　　　var b = image.color.b;
　　　　var alpha = 255;
　　　　image.color = new Color(r, g, b, alpha);
    }
}

