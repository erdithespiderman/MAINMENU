using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void TheLastOfUs()
    {
        SceneManager.LoadScene(1);
    }

    public void LeftBehind()
    {
        SceneManager.LoadScene(2);
    }

    public void Options()
    {
        SceneManager.LoadScene(3);
    }

    public void ComeBack()
    {
        SceneManager.LoadScene(0);
    }

    public void ComeBackOptions()
    {
        SceneManager.LoadScene(3);
    }

    public void GameOptions()
    {
        SceneManager.LoadScene(4);
    }

    public void SoundOptions()
    {
        SceneManager.LoadScene(5);
    }
    public void ExitGame()
    {
        Application.Quit();
        print("oyundan cikildi");
    }
}
