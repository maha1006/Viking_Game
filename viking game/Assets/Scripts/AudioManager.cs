using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip defaultAmbience;
    public AudioClip defaultAmbienceIce;
    private AudioSource track01, track02;
    private bool isPlayingTrack01;
    public static AudioManager instance;
    public float audioVolumeDefault;
    public float audioVolumeShanty;

    public UpgradeBoatBrecher upgradeBoatBrecher;


    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        track01 = gameObject.AddComponent<AudioSource>();
        track02 = gameObject.AddComponent<AudioSource>();
        track01.loop = true;
        track02.loop = true;
        isPlayingTrack01 = true;
        SwapTrack(defaultAmbience);
        track01.volume = audioVolumeDefault;
        track02.volume = audioVolumeShanty;
    }
    public void SwapTrack(AudioClip newClip)
    {
        StopAllCoroutines();

        StartCoroutine(FadeTrack(newClip));

        isPlayingTrack01 = !isPlayingTrack01;
    }

    public void ReturnToDefault()
    {
        if (upgradeBoatBrecher.UpgradeActive)
        {
            SwapTrack(defaultAmbienceIce);
        }
        else
        {
            SwapTrack(defaultAmbience);
        }
    }

    private IEnumerator FadeTrack(AudioClip newClip)
    {
        float timeToFade = 0.4f;
        float timeElapsed = 0;

        if (isPlayingTrack01)
        {
            track02.clip = newClip;
            track02.Play();

            while(timeElapsed < timeToFade)
            {
                track02.volume = Mathf.Lerp(0, 0.5f, timeElapsed / timeToFade);
                track01.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }

            track01.Stop();
        }
        else
        {
            track01.clip = newClip;
            track01.Play();

            while (timeElapsed < timeToFade)
            {
                track01.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                track02.volume = Mathf.Lerp(0.5f, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }

            track02.Stop();
        }
    }
}
