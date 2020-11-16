using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public const int STATE_MAINMENU = 0;

	public const int STATE_STARTGAME = 1;

	public const int STATE_OPTION = 2;

	public const int STATE_HELP = 3;

	public const int STATE_EXIT = 4;


	public GUISkin mySkin;

	public Texture textureBG;

	public Texture tex_startInfo;

	public Texture tex_helpInfo;

	public AudioSource music;

	private int gameState;

	void Start ()
	{
		gameState = STATE_MAINMENU;
	}

	void OnGUI()
	{

		switch(gameState)
		{
			case STATE_MAINMENU:
				RenderMainMenu();
			break;
			case STATE_STARTGAME:
				SceneManager.LoadScene("start");
				//RenderStart();
				break;
			case STATE_OPTION:
				RenderOption();
			break;
			case STATE_HELP:
				RenderHelp();
			break;
			case STATE_EXIT:
			break;
		}


	}

	void RenderMainMenu()
	{
		GUI.skin = mySkin;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),textureBG);
		if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.2f, Screen.width * 0.3f, Screen.height * 0.1f),"","start"))
		{
			gameState = STATE_STARTGAME;
		}
		if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.4f, Screen.width * 0.3f, Screen.height * 0.1f),"","option"))
		{
			gameState = STATE_OPTION;
		}
		if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.6f, Screen.width * 0.3f, Screen.height * 0.1f),"","help"))
		{
			gameState = STATE_HELP;
		}
		if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.8f, Screen.width * 0.3f, Screen.height * 0.1f),"","exit"))
		{
			Application.Quit();
		}
	}

	void RenderStart()
	{
		GUI.skin = mySkin;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),tex_startInfo);
		if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.4f, Screen.width * 0.3f, Screen.height * 0.1f),"","back"))
		{
			gameState = STATE_MAINMENU;
		}
	}

	void RenderHelp()
	{
		GUI.skin = mySkin;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),tex_helpInfo);
		if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.8f, Screen.width * 0.3f, Screen.height * 0.1f),"","back"))
		{
			gameState = STATE_MAINMENU;
		}
	}

	void RenderOption()
	{
		GUI.skin = mySkin;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),textureBG);
		// if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.4f, Screen.width * 0.3f, Screen.height * 0.1f),"","music_on"))
		// {
		// 	if (!music.isPlaying)
		// 	{
        //         music.Play();
        //     }

		// }

		// if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.4f, Screen.width * 0.3f, Screen.height * 0.1f),"","music_off"))
		// {
		// 	music.Stop();
		// }
		if(GUI.Button(new Rect (Screen.width * 0.35f, Screen.height * 0.4f, Screen.width * 0.3f, Screen.height * 0.1f),"","back"))
		{
			gameState = STATE_MAINMENU;
		}
	}
}
