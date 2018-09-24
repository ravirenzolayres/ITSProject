using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShapesLevels : MonoBehaviour {

	public Vector3 initialPosition;

	//ANIMATION;
	private Animation star1;
	private Animation star2;
	private Animation star3;

	//AUDIOSOURCE;
	public AudioSource sfx;
	public AudioSource backgroundMusic;

	//VARIABLES;s
	private int whichName;
	private bool paused=false;
	private bool isLevelCompleted = false;
	private bool isClickedRestart = false;

	public Button[] btn;

	//GO BUTTONS AND UIs;
	public GameObject validate;
	public GameObject pauseMenuCanvas;
	public GameObject levelComplete;
	public GameObject tryagain;
	public GameObject yesRestart;
	public GameObject yesMain;
	public GameObject yesLevelSelect;

	//GO SHAPES;

	//GO SHAPESHOLDERS;
	public GameObject circle;
	public GameObject triangle;
	public GameObject square;
	public GameObject rectangle;

	// GO ACTUALSHAPES;
	public GameObject circleShapes;
	public GameObject triangleShapes;
	public GameObject squareShapes;
	public GameObject rectangleShapes;



	void Start()
	{
		star1 = GameObject.Find ("starHolder1").GetComponent<Animation> ();
		star2 = GameObject.Find ("starHolder2").GetComponent<Animation> ();
		star3 = GameObject.Find ("starHolder3").GetComponent<Animation> ();

		levelComplete.SetActive (false);
		tryagain.SetActive (false);
		pauseMenuCanvas.SetActive (false);
		validate.SetActive (false);
		yesRestart.SetActive (false);
		yesMain.SetActive (false);

	
		DisableObj ();

		backgroundMusic.Play ();

		whichName = Random.Range (1, 5);

		switch(whichName)
		{
		//CIRCLE
		case 1: 

			circle.SetActive (true);
			triangle.SetActive (false);
			square.SetActive (false);
			rectangle.SetActive (false);

			initialPosition = circleShapes.transform.position;

			break;

			//TRIANGLE
		case 2:

			circle.SetActive (false);
			triangle.SetActive (true);
			square.SetActive (false);
			rectangle.SetActive (false);

			initialPosition = triangleShapes.transform.position;

			break;

			//SQUARE
		case 3:

			circle.SetActive (false);
			triangle.SetActive (false);
			square.SetActive (true);
			rectangle.SetActive (false);

			initialPosition = squareShapes.transform.position;

			break;

			//RECTANGLE
		case 4:

			circle.SetActive (false);
			triangle.SetActive (false);
			square.SetActive (false);
			rectangle.SetActive (true);


			initialPosition = rectangleShapes.transform.position;

			break;

		}
	}


	public void ChangingScene(string newScene)
	{
		SceneManager.LoadScene(newScene);
	}

	public void Drag()
	{ 
		switch(whichName)
		{
			case 1:
				circleShapes.transform.position = Input.mousePosition;
				break;
			case 2:
				triangleShapes.transform.position = Input.mousePosition;
				break;
			case 3:
				squareShapes.transform.position = Input.mousePosition;
				break;
			case 4:
				rectangleShapes.transform.position = Input.mousePosition;
				break;
		}
	}
	public void Drop()
	{
		
		switch(whichName)
		{
			
		case 1: 
			DisplayCircle();
			break;
		case 2:
			DisplayTriangle();
			break;
		case 3: 
			DisplaySquare();
			break;
		case 4:
			DisplayRectangle();
			break;

		}
	}

	public void DisableObj ()
	{
		circle.SetActive (false);
		triangle.SetActive (false);
		square.SetActive (false);
		rectangle.SetActive (false);
	}


	public void btnPauseGame()
	{
		pauseMenuCanvas.SetActive (true);
		Time.timeScale = 0; 

		//pause music
		backgroundMusic.Pause ();

		switch(whichName)
		{
		case 1:
			circle.SetActive (false);
			break;
		case 2:
			triangle.SetActive (false);
			break;
		case 3:
			square.SetActive (false);
			break;
		case 4:
			rectangle.SetActive (false);
			break;
		}
	}

	public void btnResume()
	{
		pauseMenuCanvas.SetActive (false);
		Time.timeScale = 1;

		//play music
		backgroundMusic.Play ();

		switch(whichName)
		{
		case 1:
			circle.SetActive (true);
			break;
		case 2:
			triangle.SetActive (true);
			break;
		case 3:
			square.SetActive (true);
			break;
		case 4:
			rectangle.SetActive (true);
			break;
		}

	}
	public void ValidationForRestart()
	{
		validate.SetActive (true);
		pauseMenuCanvas.SetActive (false);

		yesRestart.SetActive (true);

		isClickedRestart = false;

		if (isClickedRestart==true)
		{
			yesLevelSelect.SetActive (true);
		}
		else
		{
			yesLevelSelect.SetActive (false);
		}
		 	
	}

	public void ValidationForMainMenu()
	{
		validate.SetActive (true);
		pauseMenuCanvas.SetActive (false);

		yesMain.SetActive (true);
		yesLevelSelect.SetActive (false);

		isClickedRestart = true;

		if (isClickedRestart==true)
		{
			yesLevelSelect.SetActive (true);
		}
		else
		{
			yesLevelSelect.SetActive (false);
		}

	}

	public void ValidationForLevelSelect()
	{
		validate.SetActive (true);
		pauseMenuCanvas.SetActive (false);
	}

	private void PlayStarAnimation()
	{
		star1.Play ();
		star2.Play ();
		star3.Play ();
	}


	public void btnNo()
	{
		validate.SetActive (false);
		AbleBtn ();

		yesRestart.SetActive (false);
		yesMain.SetActive (false);

		isClickedRestart = true;
		yesLevelSelect.SetActive (true);

		DisableObj ();
		backgroundMusic.Play ();

		if (isLevelCompleted==true)
		{

			DisableObj ();
			PlayStarAnimation ();
		
			//yesLevelSelection.SetActive (true);
		}
		else
		{
			switch(whichName)
			{
			case 1:
				circle.SetActive (true);
				break;
			case 2:
				triangle.SetActive (true);
				break;
			case 3:
				square.SetActive (true);
				break;
			case 4:
				rectangle.SetActive (true);
				break;
			}
			
		}


	}

	private void DisableBtn()
	{
		btn [0].interactable = false;
		btn [1].interactable = false;

	}

	private void AbleBtn()
	{
		btn [0].interactable = true;
		btn [1].interactable = true;

	}

	private void DisplayCircle()
	{
		
		GameObject ph1 = GameObject.Find ("correctholder");

		float distance = Vector3.Distance (circleShapes.transform.position, ph1.transform.position);

		if (distance < 25 && ph1.tag == "match") {
			circleShapes.transform.position = ph1.transform.position;
			print ("MATCH");

			//COLLECTION OF SHAPES
			circle.SetActive (false);

			levelComplete.SetActive (true);
			isLevelCompleted = true;

			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("levelComplete");
			sfx.Play ();
		} 
		else {
			circleShapes.transform.position = initialPosition;
			print ("NOT MATCH");

			//COLLECTION OF SHAPES
			circle.SetActive (false);

			tryagain.SetActive (true);
			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("tryAgain");
			sfx.Play ();
		}

	}

	private void DisplayTriangle()
	{

		GameObject ph1 = GameObject.Find ("correctholder");

		float distance = Vector3.Distance (triangleShapes.transform.position, ph1.transform.position);

		if (distance < 50 && ph1.tag == "match") {
			triangleShapes.transform.position = ph1.transform.position;
			print ("MATCH");

			//COLLECTION OF SHAPES
			triangle.SetActive (false);

			levelComplete.SetActive (true);
			isLevelCompleted = true;

			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("levelComplete");
			sfx.Play ();
		} 
		else {
			triangleShapes.transform.position = initialPosition;
			print ("NOT MATCH");

			//COLLECTION OF SHAPES
			triangle.SetActive (false);

			tryagain.SetActive (true);
			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("tryAgain");
			sfx.Play ();
		}

	}

	private void DisplaySquare()
	{

		GameObject ph1 = GameObject.Find ("correctholder");

		float distance = Vector3.Distance (squareShapes.transform.position, ph1.transform.position);

		if (distance < 50 && ph1.tag == "match") {
			squareShapes.transform.position = ph1.transform.position;
			print ("MATCH");

			//COLLECTION OF SHAPES
			square.SetActive (false);

			levelComplete.SetActive (true);
			isLevelCompleted = true;

			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("levelComplete");
			sfx.Play ();
		} 
		else {
			squareShapes.transform.position = initialPosition;
			print ("NOT MATCH");

			//COLLECTION OF SHAPES
			square.SetActive (false);

			tryagain.SetActive (true);
			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("tryAgain");
			sfx.Play ();
		}

	}

	private void DisplayRectangle()
	{

		GameObject ph1 = GameObject.Find ("correctholder");

		float distance = Vector3.Distance (rectangleShapes.transform.position, ph1.transform.position);

		if (distance < 50 && ph1.tag == "match") {
			rectangleShapes.transform.position = ph1.transform.position;
			print ("MATCH");

			//COLLECTION OF SHAPES
			rectangle.SetActive (false);

			levelComplete.SetActive (true);
			isLevelCompleted = true;

			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("levelComplete");
			sfx.Play ();
		} 
		else {
			rectangleShapes.transform.position = initialPosition;
			print ("NOT MATCH");

			//COLLECTION OF SHAPES
			rectangle.SetActive (false);

			tryagain.SetActive (true);
			DisableBtn ();

			//Play SoundEffects;
			sfx.clip = Resources.Load<AudioClip> ("tryAgain");
			sfx.Play ();
		}

	}
}

