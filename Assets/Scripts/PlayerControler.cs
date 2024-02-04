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
    [SerializeField] private Vector2 directionValue;
    [SerializeField] private float forcePower = 1f;
    void Start()
    {
        gameState = GameState.PreGame;

        actionMap = new CharInputAction();
        actionMap.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        directionValue = actionMap.Player.Movement.ReadValue<Vector2>();
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
}
