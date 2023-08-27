using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField NameInput;
    [SerializeField]
    private TMP_Text ValidationText;
   
    public void LoadMainScene()
    {
        if (GetNameValidation())
        {
            GameManager.Instance.PlayerName = NameInput.name;
            SceneManager.LoadScene(1);        
        }
    }

    private bool GetNameValidation()
    {
        if (string.IsNullOrWhiteSpace(NameInput.text))
        {
            ValidationText.gameObject.SetActive(true);
            return false;
        }

        return true;
    }
}
