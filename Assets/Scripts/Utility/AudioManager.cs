using FMODUnity;
using UnityEngine;

public class AudioManager : Singleton<AudioManager> {

    [EventRef]
    public string audioSource;


    public void PlayAudioSource(Transform sourceTransform=null){
        if(sourceTransform == null){
            sourceTransform = transform;
        }
        RuntimeManager.PlayOneShot(audioSource, sourceTransform.position);
    }

    
}
