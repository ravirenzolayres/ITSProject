using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonChangeScene : MonoBehaviour {

	public GameObject[] shape;
	public Button[] btn;
	public AudioSource shapesSounds;

	private int next = 1;
	private int prev = 3;

	void Start()
	{
		DisableShape ();
		shape [0].SetActive (true);

		//CIRCLE;
		CircleSounds ();
	}
	public void ChangingScene(string newScene)
	{
		SceneManager.LoadScene(newScene);
	}

	public void DisableShape()
	{
		shape[0].SetActive(false);
		shape[1].SetActive(false);
		shape[2].SetActive(false);
		shape[3].SetActive(false);
	}

	public void CircleSounds()
	{
		//PLAY SQUARE SOUNDS
		shapesSounds.clip = Resources.Load<AudioClip>("Circle");
		shapesSounds.Play();
	}
	public void SquareSounds()
	{
		//PLAY SQUARE SOUNDS
		shapesSounds.clip = Resources.Load<AudioClip>("Square");
		shapesSounds.Play();
	}
	public void RectangleSounds()
	{
		//PLAY SQUARE SOUNDS
		shapesSounds.clip = Resources.Load<AudioClip>("Rectangle");
		shapesSounds.Play();
	}

	public void TriangleSounds()
	{
		//PLAY SQUARE SOUNDS
		shapesSounds.clip = Resources.Load<AudioClip>("Triangle");
		shapesSounds.Play();
	}

	public void ReplayMusic()
	{
		if (next == 1) 
		{
			CircleSounds ();
		}
		else if (next == 2) 
		{
			SquareSounds ();
		} 
		else if (next == 3) 
		{
			RectangleSounds ();
		} 
		else if (next == 4 || next==0) 
		{
			TriangleSounds ();
		}
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

			SquareSounds ();


		}
		else if (next==2)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(true);
			shape[3].SetActive(false);
			Debug.Log ("3");

			RectangleSounds ();
		}
		else if (next==3)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(false);
			shape[3].SetActive(true);
			Debug.Log ("4");

			TriangleSounds ();
		}
		else{

			shape[0].SetActive(true);
			shape[1].SetActive(false);
			shape[2].SetActive(false);
			shape[3].SetActive(false);
			next = 0;
			Debug.Log ("1");

			CircleSounds ();
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

			TriangleSounds ();
		}
		else if (next==2 || next==-2)
		{
			shape[0].SetActive(true);
			shape[1].SetActive(false);
			shape[2].SetActive(false);
			shape[3].SetActive(false);
			Debug.Log ("1");

			CircleSounds ();
		}
		else if (next==3)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(true);
			shape[2].SetActive(false);
			shape[3].SetActive(false);
			Debug.Log ("2");

			SquareSounds ();
		}
		else if (next==4)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(true);
			shape[3].SetActive(false);
			Debug.Log ("3");

			RectangleSounds ();
		}
		else if (next==0)
		{
			shape[0].SetActive(false);
			shape[1].SetActive(false);
			shape[2].SetActive(true);
			shape[3].SetActive(false);
			next = 4;
			Debug.Log ("Negative");

			RectangleSounds();
		}

		next--;

	}
}
