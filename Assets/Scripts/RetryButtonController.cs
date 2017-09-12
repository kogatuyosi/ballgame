using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class RetryButtonController : MonoBehaviour 
{
	// UIController を参照する
	public UIController UIController;

	public void OnClick() 
	{
		Debug.Log("Button click!");
		gameObject.SetActive(false);
		SceneManager.LoadScene ("Game");
	}
}