using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip audioWin;
    [SerializeField] AudioClip audioWinDouble;
    public Text scoreText;
    int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        audioSource = GetComponent<AudioSource>();
        
    }

    public void AddPoint()
    {
        
        score++;
        scoreText.text = "Score: " + score;
        if (!audioSource.isPlaying){audioSource.PlayOneShot(audioWin);}
    }

    public void AddDoublePoints()
    {   
        score = score + 2;
        scoreText.text = "Score: " + score;
        if (!audioSource.isPlaying){audioSource.PlayOneShot(audioWinDouble);}
        
    }
}
