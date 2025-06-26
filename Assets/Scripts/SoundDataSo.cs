using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SoundDataSo", menuName = "ScriptableObjects/SoundDataSo")]

public class SoundDataSo : ScriptableObject
{
   [Header("Sound Settings")]
    public AudioClip correctClip;  
    public float volume = 1.0f;  
    public AudioClip wrongClip;
    public AudioClip passedClip;
}
