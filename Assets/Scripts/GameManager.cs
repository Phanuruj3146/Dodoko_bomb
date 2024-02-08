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
    void Start()
    {
        // gameState = GameState.PreGame;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        gameState = GameState.Gameplay;
        Debug.Log(gameState);
    }
}
