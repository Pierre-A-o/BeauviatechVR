using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer Player;

    // Start is called before the first frame update
    void Start()
    {
        Player.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayPause()
    {
        if (Player.isPlaying) { Player.Pause(); } else { Player.Play(); }
    }

    public void Reset()
    {
        Player.Stop();
    }
}
