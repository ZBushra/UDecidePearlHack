using UnityEngine;
using System.Collections;

public class StartLevel2 : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	public GameObject Quest2;
	void Start () {
		Debug.Log ("here ");
		UnlockQuest2();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void UnlockQuest2()
	{

		Debug.Log ("here inside UnlockQuest2() "+ GameStatus.unlockL2Score);
		
		if(GameStatus.unlockL2Score >= 40  && Quest2.activeInHierarchy == false) 
		{
			Debug.Log ("here insideif  UnlockQuest2() ");
			Quest2.SetActive (true);
		}
	}
}
