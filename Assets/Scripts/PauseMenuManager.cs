using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField]private GameObject PauseMenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SwitchPauseMenu();
        }
        
    }
    public void PauseGame(){
        Time.timeScale = 0;
        PauseMenuPanel.SetActive(true);
    }
    public void ResumeGame(){
        Time.timeScale = 1;
        PauseMenuPanel.SetActive(false);
    }
    public void SwitchPauseMenu(){
        if(PauseMenuPanel.activeSelf){
            ResumeGame();
        }
        else{
            PauseGame();
        }
    }
}
