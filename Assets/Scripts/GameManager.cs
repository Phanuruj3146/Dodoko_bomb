using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Core;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameState gameState;
    public GameObject startBtn;
    void Start()
    {
        // gameState = GameState.PreGame;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(gameState);
    }
    public void StartGame()
    {
        gameState = GameState.Gameplay;
        Debug.Log("click");
        startBtn.SetActive(false);
    }

    public GameState GetGameState()
    {
        return gameState;
    }
}
