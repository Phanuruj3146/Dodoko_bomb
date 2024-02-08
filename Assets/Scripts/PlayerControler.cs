using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameState gameState;
    public Rigidbody rigid;
    public CharInputAction actionMap;
    public GameObject bomb;
    public GameObject newBomb;
    public GameObject gameManager;
    [SerializeField] private Vector2 directionValue;
    [SerializeField] private float dropBomb;
    [SerializeField] private float forcePower = 1f;
    void Start()
    {
        // gameState = GameState.PreGame;

        actionMap = new CharInputAction();
        actionMap.Enable();
        newBomb = Instantiate(bomb);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(gameState);
        // GameState manager = gameManager.GetComponent<GameManager>().GetGameState();
        gameState = gameManager.GetComponent<GameManager>().gameState;
        if (gameState == GameState.Gameplay)
        {
            //Debug.Log("yayy");
            directionValue = actionMap.Player.Movement.ReadValue<Vector2>();
            dropBomb = actionMap.Player.Bomb.ReadValue<float>();
            if (dropBomb == 1)
            {
                Attack();
            }
        }
    }

    private void FixedUpdate()
    {
        ApplyForce();
    }

    void ApplyForce() 
    {
        Vector3 applyingForce = directionValue * forcePower;
        rigid.AddForce(applyingForce, ForceMode.Impulse);
    }

    void Attack()
    {
        newBomb.transform.position = this.transform.position;
        newBomb.GetComponent<Renderer>().enabled = true;
        newBomb.SetActive(true);
        newBomb.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
