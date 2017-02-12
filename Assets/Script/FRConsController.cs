using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class FRConsController : MonoBehaviour {

	// Use this for initialization
	public GameObject Panel1;
	public GameObject Panel2;
	public GameObject ResultPanel;
	public GameObject ResultPanel2;
	public GameObject ResultPanel3;
	void Start () {
		init ();
		PlayerPrefs.SetString("continueLevel",Application.loadedLevelName);
		Panel2.SetActive (false);
	}
	private void init()
	{
		Panel2.SetActive(false);
		ResultPanel.SetActive(false);
		ResultPanel2.SetActive(false);
		ResultPanel3.SetActive(false);

	}
	public void showPanel2()
	{
		Panel1.SetActive(false);
		Panel2.SetActive (true);
	}
	public void showPanel1()
	{
		Panel1.SetActive(true);
		Panel2.SetActive (false);
	}
	public void resultPanel()
	{
		Panel1.SetActive(false);
		Panel2.SetActive (false);
		ResultPanel.SetActive (true);
	}
	public void resultPanel2()
	{
		Panel1.SetActive(false);
		Panel2.SetActive (false);
		ResultPanel.SetActive (false);
		ResultPanel2.SetActive (true);
	}
	public void resultPanel3()
	{
		Panel1.SetActive(false);
		Panel2.SetActive (false);
		ResultPanel.SetActive (false);
		ResultPanel2.SetActive (false);
		ResultPanel3.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}
}
