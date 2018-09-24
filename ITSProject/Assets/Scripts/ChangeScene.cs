using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

	public GameObject validate;
	public GameObject[] shape;

	public Button[] btn;

	private int next = 1;
	private int prev = 3;

	void Start()
	{
		validate.SetActive (false);
		DisableShape ();
		shape [0].SetActive (true);

	}
	public void ChangingScene(string newScene)
	{
		SceneManager.LoadScene(newScene);
	}

	public void Validation()
	{
		validate.SetActive (true);
		DisableBtn ();
	}
	public void btnNo()
	{
		validate.SetActive (false);
		AbleBtn ();
	}

	public void DisableShape()
	{
		shape[0].SetActive(false);
		shape[1].SetActive(false);
		shape[2].SetActive(false);
		shape[3].SetActive(false);
	}

	public void DisableBtn()
	{
		btn [0].interactable = false;
//		btn [1].interactable = false;
//		btn [2].interactable = false;
//		btn [3].interactable = false;
//		btn [4].interactable = false;
//		btn [5].interactable = false;
	}

	public void AbleBtn()
	{
		btn [0].interactable = true;
//		btn [1].interactable = true;
//		btn [2].interactable = true;
//		btn [3].interactable = true;
//		btn [4].interactable = true;
//		btn [5].interactable = true;
	}

	public void btnNext()
	{
		if(next==1)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(true);
			shape[2].SetActive(false);
			shape[3].SetActive(false);
			Debug.Log ("2");

		}
		else if (next==2)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(true);
			shape[3].SetActive(false);
			Debug.Log ("3");
		}
		else if (next==3)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(false);
			shape[3].SetActive(true);
			Debug.Log ("4");
		}
		else{

			shape[0].SetActive(true);
			shape[1].SetActive(false);
			shape[2].SetActive(false);
			shape[3].SetActive(false);
			next = 0;
			Debug.Log ("1");
		}

		next++;

	}

	public void btnPrev()
	{
		
		if (next==1)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(false);
			shape[3].SetActive(true);
			Debug.Log ("0");
		}
		else if (next==2 || next==-2)
		{
			shape[0].SetActive(true);
			shape[1].SetActive(false);
			shape[2].SetActive(false);
			shape[3].SetActive(false);
			Debug.Log ("1");
		}
		else if (next==3)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(true);
			shape[2].SetActive(false);
			shape[3].SetActive(false);
			Debug.Log ("2");
		}
		else if (next==4)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(true);
			shape[3].SetActive(false);
			Debug.Log ("3");
		}
		else if (next==0)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(true);
			shape[3].SetActive(false);
			next = 4;
			Debug.Log ("Negative");
		}

		next--;

	}
}
