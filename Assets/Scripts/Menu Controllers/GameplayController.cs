using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
    /** 
        Loads the main menu scene
    */
    public void QuitGame(){
        SceneManager.LoadScene("MainMenu");
    }
}
