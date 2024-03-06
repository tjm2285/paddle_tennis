using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Ball ball;

    [SerializeField]
    Paddle bottomPaddle, topPaddle;

    void Awake() => ball.StartNewGame();

    void Update()
    {
        ball.Move();
        ball.UpdateVisualization();
    }
}
