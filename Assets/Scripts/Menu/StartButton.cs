using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public int sceneIndex;

    public void OnBtnClick()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
