using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverTextScript : MonoBehaviour
{
    Text finalScore;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "Final Score: " + ScoreScript.scoreValue;
    }
}
