using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnHandler : MonoBehaviour
{
    public GameObject inGameMenu;
    public GameObject inGameSettingsMenu;
    public Light gameLightRef;
    public Slider lightSettingsRef;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // gamestart button
    public void GameStart()
    {
        // Load the main game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();
        #endif
    }

    public void CloseMenu()
    {
        inGameMenu.SetActive(false);
        inGameSettingsMenu.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Settings()
    {
        inGameSettingsMenu.SetActive(true);
        inGameMenu.SetActive(false);
    }

    public void BackButton()
    {
        inGameSettingsMenu.SetActive(false);
        inGameMenu.SetActive(true);
    }

    public void LightSettingSliderHandler()
    {
        gameLightRef.intensity = lightSettingsRef.value;
    }
}
