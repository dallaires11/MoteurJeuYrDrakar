using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    public void NextScene()
    {
        Debug.Log("Test");
        SceneManager.LoadScene(0);
    }
}
