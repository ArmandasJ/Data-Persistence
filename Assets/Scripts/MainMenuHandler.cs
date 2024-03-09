using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject p_text;
    private string p_name;
    public void StartNew()
    {
        p_name = p_text.GetComponent<UnityEngine.UI.Text>().text;
        if (p_name == "")
        {
            p_name = "Anonymous";
        }
        PlayerName.Instance.playerName = p_name;
        SceneManager.LoadScene(1);
    }
}
