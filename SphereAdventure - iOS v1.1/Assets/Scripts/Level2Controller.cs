using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Controller : MonoBehaviour
{

    public void NextScene()

    {
		Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
