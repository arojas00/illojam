using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject mainPanel;

    [SerializeField]
    GameObject settingsPanel;

    [SerializeField]
    GameObject creditsPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame() {  
        //SceneManager.LoadScene("Gamescene");  
    }

    public void DisplaySettings() {  
        Invoke(nameof(DisplaySettingsWaitStamp), 0.25f);
    }

    public void DisplaySettingsWaitStamp() {  
        settingsPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void DisplayCredits() {  
        Invoke(nameof(DisplayCreditsWaitStamp), 0.25f);
    }

    public void DisplayCreditsWaitStamp() {  
        creditsPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void GoBack() {  
        Invoke(nameof(GoBackWaitStamp), 0.25f);
    }

    public void GoBackWaitStamp() {  
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void QuitGame() {  
        Application.Quit(); 
    }
}
