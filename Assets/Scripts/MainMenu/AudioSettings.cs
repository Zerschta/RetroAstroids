using UnityEngine;

using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private const string MASTER_VOLUME_KEY = "MasterVolume";

    void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat(MASTER_VOLUME_KEY, 1f);
        slider.value = savedVolume;
        AudioListener.volume = savedVolume;

        slider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        AudioListener.volume = value;
        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, value);
    }
}
