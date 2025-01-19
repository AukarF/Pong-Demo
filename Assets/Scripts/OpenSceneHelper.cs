using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class OpenSceneHelper : MonoBehaviour
{
    public string sceneToOpen;
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneToOpen);
    }
}
