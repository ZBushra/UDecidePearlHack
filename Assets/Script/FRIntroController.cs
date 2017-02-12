using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class FRIntroController : MonoBehaviour {

	// Use this for initialization
	public GameObject Panel1;
	public GameObject Panel2;
	public GameObject Panel3;
	public GameObject Panel4;
	public GameObject Panel5;

	public GameObject ResultPanel;
	int flag;
	void Start () {
		flag = 1;
		init ();
	//	PlayerPrefs.SetInt("Score", GameStatus.GetScore());
		PlayerPrefs.SetString("continueLevel",Application.loadedLevelName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void init()
	{
		Panel2.SetActive(false);
		Panel3.SetActive(false);
		Panel4.SetActive(false);
		Panel5.SetActive(false);

		ResultPanel.SetActive(false);
	}
	public void showPanel1()
	{
		flag = 1;
		Panel1.SetActive (true);
		Panel2.SetActive(false);
		Panel3.SetActive(false);
		Panel4.SetActive(false);
		Panel5.SetActive(false);
	}
	public void showPanel2()
	{
		flag = 2;
		Panel1.SetActive (false);
		Panel2.SetActive (true);
		Panel3.SetActive(false);
		Panel4.SetActive(false);
		Panel5.SetActive(false);
	}
	public void showPanel3()
	{
		flag = 3;
		Panel1.SetActive (false);
		Panel2.SetActive (false);
		Panel3.SetActive (true);
		Panel4.SetActive(false);
		Panel5.SetActive(false);
	}
	public void showPanel4()
	{
		flag = 4;
		Panel1.SetActive (false);
		Panel2.SetActive (false);
		Panel3.SetActive (false);
		Panel4.SetActive(true);
		Panel5.SetActive(false);
	}
	public void showPanel5()
	{
		flag = 5;
		Panel1.SetActive (false);
		Panel2.SetActive (false);
		Panel3.SetActive (false);
		Panel4.SetActive(false);
		Panel5.SetActive(true);
	}

	public void showPrev()
	{
		switch (flag-1) {
		case 1:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel1 (); //when flag == 1 then it is panel1
				break;
			}
		case 2:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel2 (); //when flag == 2 then it is contained inside pwpanel2, and next panel will be pwpanel3 and so on
				break;
			}
		case 3:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel3 ();
				break;
			}
		case 4:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel4 (); //when flag == 1 then it is panel1
				break;
			}
		case 5:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel5 (); //when flag == 2 then it is contained inside pwpanel2, and next panel will be pwpanel3 and so on
				break;
			}
		
		}
	}
	public void showNext()
	{

		switch (flag) {
		case 1:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel2 (); //when flag == 1 then it is in panel1
				break;
			}
		case 2:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel3 (); //when flag == 2 then it is contained inside pwpanel2, and next panel will be pwpanel3 and so on
				break;
			}
		case 3:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel4 ();
				break;
			}
		case 4:
			{
				Debug.Log ("flag  " + flag.ToString ());
				showPanel5 (); //when flag == 1 then it is panel1
				break;
			}
		}
	}

	public void showResultPanel()
	{
		GameStatus.AddScore (60);
		PlayerPrefs.SetInt ("Score",GameStatus.GetScore());
		GameStatus.unlockL2Score = 40;
		PlayerPrefs.SetInt ("unlockL2Score", GameStatus.unlockL2Score);
		ResultPanel.SetActive (true);
	}
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

}
