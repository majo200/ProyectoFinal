using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoFinalizado : MonoBehaviour
{
    public GameObject panelBotones;
    public GameObject panelVideo;
    public VideoPlayer playerIntro;

    // Start is called before the first frame update
    void Start()
    {
        playerIntro.loopPointReached += LoadBotones;
    }

    void LoadBotones(VideoPlayer vp)
    {
        panelBotones.SetActive(true);
        panelVideo.SetActive(false);
    }
}
