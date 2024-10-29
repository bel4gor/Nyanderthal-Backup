using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class PlayGame : MonoBehaviour
{
    // Sceneload variable made public to point to the scene being opened from unity
    public string SceneLoad;
    // Start is called before the first frame update

    public void LoadScene()
    {
        // loads the scene embedded from the inspector
        SceneManager.LoadScene(SceneLoad);
    }

}
