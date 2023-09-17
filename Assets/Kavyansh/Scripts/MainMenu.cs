using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject _creditsScreen , _mainmenuScreen , _loadingScreen;
    [SerializeField] Slider _loader;
    [SerializeField] TextMeshProUGUI _loading_txt;

    #region Main menu
    public void Play(string Level)
    {
        _mainmenuScreen.SetActive(false);
        _loadingScreen.SetActive(true);
        StartCoroutine(SceneLoader(Level));
    }
    public void PlayLevel(string Level)
    {
        SceneManager.LoadScene(Level);
    }

    public void Credits()
    {
        _mainmenuScreen.SetActive(false);
        _creditsScreen.SetActive(true);
    }
    public void Back_Button()
    {
        _creditsScreen.SetActive(false);
        _mainmenuScreen.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    IEnumerator SceneLoader(string Level)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Level);

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            _loader.value = progress;
            _loading_txt.text  = (int)progress * 100f + " %";
            yield return null;
        }
    }
    #endregion
}
