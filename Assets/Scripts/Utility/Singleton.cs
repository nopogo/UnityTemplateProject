using UnityEngine;

public class Singleton<Instance> : MonoBehaviour where Instance : Singleton<Instance> {
    public static Instance instance;
    public bool isPersistent;

    public virtual void Awake() {
        if(isPersistent) {
            if(!instance) {
                instance = this as Instance;
            }  else {
                Debug.LogError("WE ARE DUPLICATE DUMMY: "+ this);
                Destroy(gameObject);
            }
            DontDestroyOnLoad(gameObject);
        } else {
            instance = this as Instance;
        }
    }
}