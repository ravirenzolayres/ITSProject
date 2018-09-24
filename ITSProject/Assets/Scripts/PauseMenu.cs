using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour 
{
	private bool paused=false;

	public GameObject pauseMenuCanvas;
	public GameObject validationCanvas;

	public Button btnResume;
	public Button btnRestart;
	public Button btnMainMenu;
	public Button btnQuit;

	void Start()
	{
		pauseMenuCanvas.SetActive (false);
		validationCanvas.SetActive (false);
	}
	void Update()
	{
		PausedGame ();
	}
	public void btnPause()
	{
		PausedGame ();
	}
	void PausedGame()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			paused = !paused;
		}

		if (paused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0; 
		} 
		else if (!paused) 
		{
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1;
		}
	}

	public void Resume()
	{
		paused = false;
	}

	public void MainMenuValidation()
	{
		validationCanvas.SetActive (true);
		btnResume.interactable = false;
		btnRestart.interactable = false;
		btnMainMenu.interactable = false;
		btnQuit.interactable = false;
	}

	public void btnNo()
	{
		validationCanvas.SetActive (false);
		btnResume.interactable = true;
		btnRestart.interactable = true;
		btnMainMenu.interactable = true;
		btnQuit.interactable = true;
	}
}
