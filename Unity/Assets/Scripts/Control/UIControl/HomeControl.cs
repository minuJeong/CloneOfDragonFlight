using UnityEngine;
using System.Collections;

public class HomeControl : MonoBehaviour {
	public void GoScene (string SceneName)
	{
		Application.LoadLevel (SceneName);
	}
}