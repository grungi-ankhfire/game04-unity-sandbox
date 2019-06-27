using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame() {
        SceneManager.LoadScene("AnimationTest");
    }

    public void DisplaySliderValue(float value) {
        Debug.Log("Slider value : " + value.ToString());
    }

}
