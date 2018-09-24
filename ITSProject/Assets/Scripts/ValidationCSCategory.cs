using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValidationCSCategory : MonoBehaviour {

	public GameObject validate;
	public Button[] btn;
	public AudioSource backgroundMusic;

	void Start()
	{
		validate.SetActive (false);
		backgroundMusic.Play ();
	}
	public void ChangingScene(string newScene)
	{
		SceneManager.LoadScene(newScene);
	}

	public void Validation()
	{
		validate.SetActive (true);
		DisableBtn();
		backgroundMusic.Pause ();
	}
	public void btnNo()
	{
		validate.SetActive (false);
		AbleBtn ();
		backgroundMusic.Play ();
	}

	public void DisableBtn()
	{
		btn [0].interactable = false;
		btn [1].interactable = false;
		btn [2].interactable = false;
		btn [3].interactable = false;
		btn [4].interactable = false;
		btn [5].interactable = false;
		//btn [6].interactable = false;
//		btn [7].interactable = false;
//		btn [8].interactable = false;
//		btn [9].interactable = false;
//		btn [10].interactable = false;
	}

	public void AbleBtn()
	{
		btn [0].interactable = true;
		btn [1].interactable = true;
		btn [2].interactable = true;
		btn [3].interactable = true;
		btn [4].interactable = true;
		btn [5].interactable = true;
		//btn [6].interactable = true;
//		btn [7].interactable = true;
//		btn [8].interactable = true;
//		btn [9].interactable = true;
//		btn [10].interactable = true;
	}
}
