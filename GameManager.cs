using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;


private int playerScore = 0;
private int enemyScore = 0;
public TextMeshProUGUI textPointsPlayer;
public TextMeshProUGUI textPointsEnemy;
public GameManager gameManager;
public class gameManager
{
    public Transform playerPaddle;
    public Transform enemyPaddle;

    //...
    public void Start()
    {
        ResetGame();
    }
    public void ResetGame()
    {
        playerPaddle.position = new Vector3(-7f, 0f, 0f);

        enemyPaddle.position = new Vector3(7f, 0f, 0f);

        BallController.ResetBall();


        playerScore = 0;
        enemyScore = 0;
        textPointsEnemy.Text = enemyScore.ToString();
        textPointsPlayer.Text = playerScore.ToString();
    }

    public BallController ballController;
    private int playerScore;
    private int enemyScore;
    private object textPointsPlayer;
    private object textPointsEnemy;

    public void ScorePlayer() 
    {
        playerScore++; textPointsPlayer.Text = playerScore.ToString(); 
    }
    public void ScoreEnemy() 
    {
        enemyScore++; textPointsEnemy.Text = enemyScore.ToString();
    }

}
