using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SharePictureController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString("continueLevel",Application.loadedLevelName);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

}
