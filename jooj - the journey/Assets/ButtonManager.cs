using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {


    public void PlayGameBtn(string LoadingScene1)
    {

        SceneManager.LoadScene(LoadingScene1);

    }


    void Update()
    {
        OnGUI();
    }

    void OnGUI()
    {

        Scene scene = SceneManager.GetActiveScene();

        if (Event.current.Equals(Event.KeyboardEvent("enter")) && scene.name.Equals("LoadingScene1"))
        {
            StartCoroutine(LoadAsynchronously(2));
        }

        if (Event.current.Equals(Event.KeyboardEvent("escape")) && scene.name.Equals("LoadBackMenu"))
        {
            Application.LoadLevel(3);

            StartCoroutine(LoadAsynchronously(0));
        }

    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            yield return null;
        }
    }


    public void LoadGameBtn(string MainMenuScreen) {

        SceneManager.LoadScene(MainMenuScreen);

    }

    public void OptionsBtn(string MainMenuScreen) {

        SceneManager.LoadScene(MainMenuScreen);

    }


    public void ExitBtn(string MainMenuScreen)
    {

        Application.Quit();

    }

}
