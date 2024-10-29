using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHome : MonoBehaviour
{
    // This function will be called when the button is clicked
    public void LoadHomeScreen()
    {
        // Replace "HomeScreen" with the exact name of your home screen scene
        SceneManager.LoadScene("HomeScreen");
    }
}
