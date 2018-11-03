using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    [SerializeField]
    private string targetSceneName;

	// Use this for initialization
	void Start () {
		
	}
	
    public void SwitchScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
