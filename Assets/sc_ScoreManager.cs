using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_ScoreManager : MonoBehaviour
{
    //This is our main singleton to modify score across the game.
    public static sc_ScoreManager townScore;
    public int playerScore = 0;
    public string playerMsg = "Hello"; 


    public void AddScore(int ScoreValue)
    {
        playerScore += ScoreValue;

        GameObject scoreText  = GameObject.Find("ScoreText");
        scoreText.GetComponent<TextMesh>().text = playerScore.ToString(); 
    }

    public void NotifyPlayer(string NotificationText)
    {
        GameObject scoreText = GameObject.Find("ScoreText");
        scoreText.GetComponent<TextMesh>().text = NotificationText;
    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Score Reset To " + playerScore.ToString());
        if (!townScore) townScore = this;

        GameObject scoreText = GameObject.Find("ScoreText");
        scoreText.GetComponent<TextMesh>().text = playerScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
