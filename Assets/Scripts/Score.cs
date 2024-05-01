using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Player.position.x.ToString("00") ;
    }
}
