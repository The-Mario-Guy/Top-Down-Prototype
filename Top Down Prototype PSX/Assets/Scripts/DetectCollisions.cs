using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
   // public TextMeshProUGUI scoreText;
  //  public int Score;
    void Start()
    {
       // Score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       // Score = Score + 1;
       // setScoreText();
        Destroy(gameObject);
        Destroy(other.gameObject);
        
    }
   /* void setScoreText()
    {
        scoreText.text = Score.ToString();
    }*/
}
