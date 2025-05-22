using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class AudioClipRefsSO : ScriptableObject
{
    public AudioClip[] chop;
    public AudioClip[] deliveryFailed;
    public AudioClip[] deliverySuccess;

    public AudioClip[] footstep;

    public AudioClip[] objectDrop;

    public AudioClip[] objectPickup;

    public AudioClip StoveSizzle;

    public AudioClip[] trash;

    public AudioClip[] warning;
}
