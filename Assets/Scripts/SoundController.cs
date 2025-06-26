using UnityEngine;

public class SoundController : MonoBehaviour
{
    AudioSource audioSource;

    public static SoundController Instance { get; private set; }
    private void Awake()
    {
       
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); 
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void PlayChoiseVoice(AudioClip audioClip)
    {
        audioSource.clip =audioClip;
        audioSource.Play();

    }

}
