using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManagerSingleton : MonoBehaviour
{
    public static AudioManagerSingleton Instance;

    [SerializeField] AudioClip[] musicClips;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectsSource;
    int[] playlist;
    [SerializeField] AudioClip buttonsSound;
    [SerializeField] AudioClip introMusic;
    [SerializeField] int currentSong;
    string sceneName;
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
    private void OnEnable()
    {
        SceneManager.activeSceneChanged += OnSceneChanged;
    }
    private void OnDisable()
    {
        SceneManager.activeSceneChanged -= OnSceneChanged;
    }
    private void OnSceneChanged(Scene current, Scene next)
    {
        PlayMusic(next);
    }
    private void PlayMusic(Scene current)
    {
        Debug.Log($"{current.name} : build index {current.buildIndex}");
        if (current.buildIndex == 0)
        {
            musicSource.clip = introMusic;
        }
        else
        {
            RandomPlaylist();
            musicSource.clip = musicClips[currentSong];
        }
        musicSource.Play();
    }
    public void RandomPlaylist()
    {
        currentSong = Random.Range(0, musicClips.Length-1);
    }


    public void CheckNextSong()
    {
        if (musicClips.Length == 0) return;

        if (currentSong >= playlist.Length)
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
