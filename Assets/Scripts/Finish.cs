using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool levelCompeled = false;
    private int correctAnswer = 0;

    public GameObject questionPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompeled)
        {
            questionPanel.SetActive(true);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CorrectAnswer ()
    {
        correctAnswer++;
        levelCompeled = true;
        Invoke("CompleteLevel", 2f);
    }

}
