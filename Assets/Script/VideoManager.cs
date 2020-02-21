using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer Player;
    public VideoClip itw;
    public VideoClip rein1;
    public VideoClip rein2;
    public VideoClip rein3;

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

    public void ChangeVideo(string name)
    {
        switch (name)
        {
            case "itw":
                Player.clip = itw;
                break;
            case "rein2":
                Player.clip = rein1;
                break;
            case "rein3":
                Player.clip = rein2;
                break;
            case "rein4":
                Player.clip = rein3;
                break;
            default:
                Player.clip = itw;
                break;
        }
            
    }
}
