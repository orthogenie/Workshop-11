using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField] GameObject rootMenu;
    [SerializeField] GameObject instructions;
    
    public void OnClickPlay() {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToInstructions() {
        rootMenu.SetActive(false);
        instructions.SetActive(true);
    }

    public void GoToRootMenu() {
        instructions.SetActive(false);
        rootMenu.SetActive(true);
    }
    
}
