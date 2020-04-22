
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    [SerializeField] private AudioSource _click;

    public void PlayClickSound()
    {
        _click.Play();
    }
}
