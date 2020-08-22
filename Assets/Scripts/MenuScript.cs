using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartGame() {
        SceneManager.LoadScene(1);
        ChangeLevel();
    }

    public void Endless() {
        SceneManager.LoadScene(2);
        ChangeLevel();
    }

    public void ExitGame() {
        Application.Quit();
    }
    IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(2);
    }
}
