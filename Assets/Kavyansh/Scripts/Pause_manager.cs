using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_manager : MonoBehaviour
{
    [SerializeField] GameObject _pauseScreen , _pauseButton , _loadingScreen;
    [SerializeField] TextMeshProUGUI _loading_txt;
    [SerializeField] Slider _loader;

    private void Start()
    {
        _pauseScreen.SetActive(false);
        _loadingScreen.SetActive(false);
    }

    public void GamePause()
    {
        Time.timeScale = 0;
        _pauseScreen.SetActive(true);
        _pauseButton.SetActive(false);
    }
    public void Resume()
    {
        Time.timeScale = 1; 
        _pauseScreen.SetActive(false);
        _pauseButton.SetActive(true);
    }
    public void MainMenu(string Level)
    {
        _pauseScreen.SetActive(false);
        _loadingScreen.SetActive(true);
        StartCoroutine(SceneLoader(Level));
    }
    IEnumerator SceneLoader(string Level)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Level);

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            _loader.value = progress;
            _loading_txt.text = (int)progress * 100f + " %";
            yield return null;
        }
    }
}
