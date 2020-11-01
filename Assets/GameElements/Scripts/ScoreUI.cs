using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour
{

    public int scorePlayerRight;

    public int scorePlayerLeft;

    public GUIStyle style;

    public int winningScore = 10;

    private void OnGUI()
    {
        float x = Screen.width / 2f;
        float y = 30f;
        float width = 250f;
        float height = 20f;
        string text = scorePlayerLeft + " / " + scorePlayerRight;

        GUI.Label(new Rect(x - (width / 2f), y, width, height), text, style);

        if (scorePlayerLeft >= winningScore || scorePlayerRight >= winningScore)
        {
            GameObject esfera = GameObject.Find("Esfera");
            if(esfera != null)
            {
                esfera.SetActive(false);
            }

            if(scorePlayerRight >= winningScore)
            {
                SceneManager.LoadScene("Ganar");
            } else
            {
                SceneManager.LoadScene("Perdiste");

            }
        }
    }
}
