using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonSettings : MonoBehaviour {
	public static int releasedLevelStatic = 1;
	public int releasedLevel;
	public string nextLevel;
	public string levelselection;


	void Awake()
	{
		if (PlayerPrefs.HasKey ("Level")) {
			releasedLevelStatic = PlayerPrefs.GetInt ("Level", releasedLevelStatic);

		}
	}

	public void ButtonNextLevel()
	{
		SceneManager.LoadScene (nextLevel);
		if(releasedLevelStatic <= releasedLevel){
			releasedLevelStatic = releasedLevel;
			PlayerPrefs.SetInt ("Level", releasedLevelStatic);

	}
   }
	public void ButtonLevelSelection()
	{
		SceneManager.LoadScene (levelselection);
		if (releasedLevelStatic <= releasedLevel) {
			releasedLevelStatic = releasedLevel;
			PlayerPrefs.SetInt ("Level", releasedLevelStatic);
		}
	}
}
