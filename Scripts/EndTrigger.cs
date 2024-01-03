using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

   void OnTriggerEnter2D() {
    gameManager.CompleteLevel();
   }
}
