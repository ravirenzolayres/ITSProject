using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour {

	public void LoadScene (string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
