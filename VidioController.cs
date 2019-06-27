using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

[RequireComponent(typeof(VideoPlayer))]

[RequireComponent(typeof(AudioSource))]
public class VidioController : MonoBehaviour,
    ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    private AudioSource sound;

    private VideoPlayer videoPlayer;

    void Start()

    {

        videoPlayer = GetComponent<VideoPlayer>();

        sound = GetComponent<AudioSource>();

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)

        {

            mTrackableBehaviour.RegisterTrackableEventHandler(this);

        }

        videoPlayer.playOnAwake = false;

        sound.playOnAwake = false;



    }

    public void OnTrackableStateChanged(

      TrackableBehaviour.Status previousStatus,

      TrackableBehaviour.Status newStatus)

    {

        if (newStatus == TrackableBehaviour.Status.DETECTED ||

         newStatus == TrackableBehaviour.Status.TRACKED ||

         newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED

        )

        {

            // Play audio when target is found

            videoPlayer.Play();

            sound.Play();

        }

        else

        {

            // Stop audio when target is lost

            videoPlayer.Stop();

            sound.Stop();

        }

    }

}