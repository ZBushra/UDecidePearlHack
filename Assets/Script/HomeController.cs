using UnityEngine;
using System.Collections;

public class HomeController : MonoBehaviour {

	// Use this for initialization
	public GameObject ScoreBoardPanel;
	public GameObject AboutBoardPanel;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void hideScore()
	{
		ScoreBoardPanel.SetActive (false);
	}
	public void showScore()
	{
		ScoreBoardPanel.SetActive (true);
	}
	public void hideAbout()
	{
		AboutBoardPanel.SetActive (false);
	}
	public void showAbout()
	{
		AboutBoardPanel.SetActive (true);
	}
}
