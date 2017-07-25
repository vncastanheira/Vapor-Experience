using UnityEngine;

public class AudioController : MonoBehaviour {

				AudioSource audioSource;

				private void Start()
				{
								audioSource = GetComponent<AudioSource>();
				}

				public void PlayMusic(AudioClip clip)
				{
								audioSource.Stop();
								audioSource.PlayOneShot(clip);
				}
}
