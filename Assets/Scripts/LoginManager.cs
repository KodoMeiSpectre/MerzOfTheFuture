using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.UI;
using TMPro;

public class LoginManager : MonoBehaviour
{
    private bool roomNameSet = false;
    public string roomName = "";
    public Realtime realtime;
    public TMP_InputField roomNameInput;

    public void SetRoomName()
    {
        roomName = roomNameInput.text;
        roomNameSet = true;
    }

    public void ConnectToRealtime()
    {
        if (roomNameSet)
        {
            realtime.Connect(roomName);
        }
    }
}
