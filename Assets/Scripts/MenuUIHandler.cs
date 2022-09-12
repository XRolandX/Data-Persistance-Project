using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{


    public TextMeshProUGUI BestScoreText; //dont forget that if you change this variable name you need attach canvas object to this script again
    public TextMeshProUGUI InputName;


    private void Start()
    {

        BestScoreText.text = $"Best Score : {SaveManager.Instance.bestPlayerName} : {SaveManager.Instance.bestCurrentScore}";

    }

    public void StartButton()
    {


        SaveManager.Instance.inputName = InputName.text;
        SceneManager.LoadScene(1);


    }

}
