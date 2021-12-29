using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bntBehavior : MonoBehaviour
{
    public GameManager gameManager;
    public void OnButtonPressed()
    {
        gameManager.StartGame();
    }
}
