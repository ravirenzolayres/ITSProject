using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level5 : MonoBehaviour {

	//AudioSource;
	public AudioSource sfx;
	public AudioSource backgroundMusic;


	// variables;
	private int whichName;
	//Question Object Holder;
	private Text txtNameObject;

	// gameObject Holder;
	public GameObject crayon;
	public GameObject sharpener;
	public GameObject notebook;
	public GameObject paper;
	public GameObject scissors;

	public GameObject validate;
	public GameObject pauseMenuCanvas;
	public GameObject levelComplete;
	public GameObject tryagain;
	public GameObject yesRestart;
	public GameObject yesMain;

	public Button[] btn;
	// Use this for initialization
	void Start () {

		levelComplete.SetActive (false);
		tryagain.SetActive (false);
		pauseMenuCanvas.SetActive (false);
		validate.SetActive (false);
		yesRestart.SetActive (false);
		yesMain.SetActive (false);

		DisableObj ();
		backgroundMusic.Play ();

		txtNameObject = GameObject.Find ("txtObject").GetComponent<Text>();

		whichName = Random.Range (1, 6);


		switch(whichName)
		{

		case 1: 

			txtNameObject.text = "Crayons";

			crayon.SetActive (true);
			sharpener.SetActive (false);
			notebook.SetActive (false);
			paper.SetActive (false);
			scissors.SetActive (false);

			break;
		case 2:

			txtNameObject.text = "Sharpener";

			crayon.SetActive (false);
			sharpener.SetActive (true);
			notebook.SetActive (false);
			paper.SetActive (false);
			scissors.SetActive (false);

			break;

		case 3:

			txtNameObject.text = "Notebooks";

			crayon.SetActive (false);
			sharpener.SetActive (false);
			notebook.SetActive (true);
			paper.SetActive (false);
			scissors.SetActive (false);

			break;

		case 4:

			txtNameObject.text = "Papers";

			crayon.SetActive (false);
			sharpener.SetActive (false);
			notebook.SetActive (false);
			paper.SetActive (true);
			scissors.SetActive (false);

			break;

		case 5:

			txtNameObject.text = "Scissors";

			crayon.SetActive (false);
			sharpener.SetActive (false);
			notebook.SetActive (false);
			paper.SetActive (false);
			scissors.SetActive (true);

			break;

		}

	}

	public void DisableObj ()
	{
		crayon.SetActive (false);
		sharpener.SetActive (false);
		notebook.SetActive (false);
		paper.SetActive (false);
		scissors.SetActive (false);
	}

	public void btnPauseGame()
	{
		pauseMenuCanvas.SetActive (true);
		DisableBtn ();
		Time.timeScale = 0; 

		//pause music
		backgroundMusic.Pause ();

		switch(whichName)
		{
		case 1:
			crayon.SetActive (false);
			break;
		case 2:
			sharpener.SetActive (false);
			break;
		case 3:
			notebook.SetActive (false);
			break;
		case 4:
			paper.SetActive (false);
			break;
		case 5:
			scissors.SetActive (false);
			break;
		}
	}

	public void btnResume()
	{
		pauseMenuCanvas.SetActive (false);
		AbleBtn ();
		Time.timeScale = 1;

		//play music
		backgroundMusic.Play ();

		switch(whichName)
		{
		case 1:
			crayon.SetActive (true);
			break;
		case 2:
			sharpener.SetActive (true);
			break;
		case 3:
			notebook.SetActive (true);
			break;
		case 4:
			paper.SetActive (true);
			break;
		case 5:
			scissors.SetActive (true);
			break;
		}

	}
	public void ValidationForRestart()
	{
		validate.SetActive (true);
		pauseMenuCanvas.SetActive (false);

		yesRestart.SetActive (true);
	}

	public void ValidationForMainMenu()
	{
		validate.SetActive (true);
		pauseMenuCanvas.SetActive (false);

		yesMain.SetActive (true);
	}


	public void btnNo()
	{
		validate.SetActive (false);
		AbleBtn ();

		DisableObj ();
		backgroundMusic.Play ();

		switch(whichName)
		{
		case 1:
			crayon.SetActive (true);
			break;
		case 2:
			sharpener.SetActive (true);
			break;
		case 3:
			notebook.SetActive (true);
			break;
		case 4:
			paper.SetActive (true);
			break;
		case 5:
			scissors.SetActive (true);
			break;
		}
	}

	public void AbleBtn()
	{
		btn[0].interactable = true;
		btn[1].interactable = true;
		btn[2].interactable = true;
		btn[3].interactable = true;
		btn[4].interactable = true;
		btn[5].interactable = true;
		btn[6].interactable = true;
		btn[7].interactable = true;
		btn[8].interactable = true;
		btn[9].interactable = true;
		btn[10].interactable = true;
		btn[11].interactable = true;

	}

	public void DisableBtn()
	{
		btn[0].interactable = false;
		btn[1].interactable = false;
		btn[2].interactable = false;
		btn[3].interactable = false;
		btn[4].interactable = false;
		btn[5].interactable = false;
		btn[6].interactable = false;
		btn[7].interactable = false;
		btn[8].interactable = false;
		btn[9].interactable = false;
		btn[10].interactable = false;
		btn[11].interactable = false;
	}
	public void  Btn4()
	{
		if (whichName == 1) 
		{
			levelComplete.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("levelComplete");
			sfx.Play();

			//Disable Buttons and Object;
			DisableBtn ();
			DisableObj ();
		}
		else{
			tryagain.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("tryAgain");
			sfx.Play();

			DisableBtn ();
			DisableObj();
		}
	}

	public void  Btn7()
	{
		if (whichName == 2) 
		{
			levelComplete.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("levelComplete");
			sfx.Play();

			DisableBtn ();
			DisableObj ();
		}
		else{
			tryagain.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("tryAgain");
			sfx.Play();

			DisableBtn ();
			DisableObj();
		}
	}

	public void  Btn6()
	{
		if (whichName == 3) 
		{
			levelComplete.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("levelComplete");
			sfx.Play();

			DisableBtn ();
			DisableObj ();
		}
		else{
			tryagain.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("tryAgain");
			sfx.Play();

			DisableBtn ();
			DisableObj();
		}
	}

	public void  Btn8()
	{
		if (whichName == 4) 
		{
			levelComplete.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("levelComplete");
			sfx.Play();

			DisableBtn ();
			DisableObj ();
		}
		else{
			tryagain.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("tryAgain");
			sfx.Play();

			DisableBtn ();
			DisableObj();
		}
	}

	public void Btn5()
	{
		if (whichName == 5) 
		{
			levelComplete.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("levelComplete");
			sfx.Play();

			DisableBtn ();
			DisableObj ();
		}
		else{
			tryagain.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("tryAgain");
			sfx.Play();

			DisableBtn ();
			DisableObj();
		}
	}


	public void OtherBtn()
	{
		if (whichName != 1 || whichName !=2 || whichName !=3 ||whichName !=4 || whichName !=5) 
		{
			tryagain.SetActive (true);

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip>("tryAgain");
			sfx.Play();

			DisableBtn ();
			DisableObj();
		}
	}

	public void ChangeScene(string newScene)
	{
		SceneManager.LoadScene (newScene);
	}
}
