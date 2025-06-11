using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerSingleton : MonoBehaviour
{
    public static AudioManagerSingleton Instance;

    [SerializeField] AudioClip[] musicClips;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectsSource;
    int[] playlist;
    [SerializeField] AudioClip buttonsSound;
    [SerializeField] int currentSong;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        musicSource.Play();
        RandomPlaylist();
        CheckNextSong();
    }
    private void Update()
    {
        if (!musicSource.isPlaying)
        {
            CheckNextSong();
        }
    }

    public void RandomPlaylist()
    {
        playlist = new int[musicClips.Length];
        for(int i = 0; i < playlist.Length; i++)
        {
            playlist[i] = i;
        }

        for (int i = playlist.Length - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            int temp = playlist[i];
            playlist[i] = playlist[j];
            playlist[j] = temp;
        }

        currentSong = 0;
    }


    public void CheckNextSong()
    {
        if (musicClips.Length == 0) return;

        if(currentSong >= playlist.Length)
        {
            RandomPlaylist();
        }

        int clipIndex = playlist[currentSong];
        musicSource.clip = musicClips[clipIndex];
        musicSource.Play();
        currentSong++;
    }

    public void ButtonsSound()
    {
        effectsSource.clip = buttonsSound;
        effectsSource.Play();
    }







}
