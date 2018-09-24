using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	public AudioSource sound;

	// Use this for initialization
	void Start () {
		sound.GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void BtnSound()
	{
		sound.clip = Resources.Load<AudioClip>("btnClick");
		sound.Play();
	}
	public void btn0()
	{
		sound.clip = Resources.Load<AudioClip> ("Number0");
		sound.Play();
	}

	public void btn1()
	{
		sound.clip = Resources.Load<AudioClip> ("Number1");
		sound.Play();
	}
	public void btn2()
	{
		sound.clip = Resources.Load<AudioClip> ("Number2");
		sound.Play();
	}
	public void btn3()
	{
		sound.clip = Resources.Load<AudioClip> ("Number3");
		sound.Play();
	}
	public void btn4()
	{
		sound.clip = Resources.Load<AudioClip> ("Number4");
		sound.Play();
	}
	public void btn5()
	{
		sound.clip = Resources.Load<AudioClip> ("Number5");
		sound.Play();
	}
	public void btn6()
	{
		sound.clip = Resources.Load<AudioClip> ("Number6");
		sound.Play();
	}
	public void btn7()
	{
		sound.clip = Resources.Load<AudioClip> ("Number7");
		sound.Play();
	}
	public void btn8()
	{
		sound.clip = Resources.Load<AudioClip> ("Number8");
		sound.Play();
	}
	public void btn9()
	{
		sound.clip = Resources.Load<AudioClip> ("Number9");
		sound.Play();
	}
	public void btn10()
	{
		sound.clip = Resources.Load<AudioClip> ("Number10");
		sound.Play();
	}
		


}
