using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform player;

    public TextMeshProUGUI score;

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.x.ToString("0");
    }
}
