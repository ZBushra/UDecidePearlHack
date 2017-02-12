using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameStatus : MonoBehaviour {

	// Use this for initialization

	static public int Score = 0;
	static public int unlockL2Score = 0;
	void Start () {
		Score = PlayerPrefs.GetInt("Score");
		Debug.Log ("   ->" +GameStatus.GetScore());
		unlockL2Score = PlayerPrefs.GetInt("unlockL2Score");
	}

	// Update is called once per frame
	void Update () {
			}
	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
	}
	public void ResetScore()
	{
		Score = 0;
		unlockL2Score = 0;
		PlayerPrefs.SetInt("Score", Score);
		PlayerPrefs.SetInt("unlockL2Score", unlockL2Score);
	}
	public void ResetLevel() //for new game reset score and level status
	{
		ResetScore ();
		PlayerPrefs.SetString("continueLevel","FriendRequestQuestIntro1");
	}
	static public void AddScore(int s)
	{
		Score += s;
	}
	static public int GetScore()
	{
		return Score;
	}
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

	public void loadCurrentScene()
	{
		SceneManager.LoadScene(PlayerPrefs.GetString("continueLevel"));
	}

	public void GameExit()
	{
		Debug.Log ("inside gameExit()");
		Application.Quit ();
	}
}
