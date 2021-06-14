using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class AvatarStorage : MonoBehaviour
{
    public RealtimeAvatarManager avatarManager;
    public List<GameObject> avatars = new List<GameObject>();

    public bool isOn;

    void Awake()
    {
        if(isOn == true)
        {
            avatarManager.localAvatarPrefab = avatars[Random.Range(0, avatars.Count)];
        }
    }
}
