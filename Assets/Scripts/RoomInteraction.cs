using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Normal.Realtime;

public class RoomInteraction : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public GameObject currentRoom;

    private void OnTriggerEnter(Collider other)
    {
        textField.text = other.transform.name;
        currentRoom = other.gameObject;
    }

    public void OuterWallsToggle()
    {
        currentRoom.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = !currentRoom.transform.GetChild(1).GetComponent<MeshRenderer>().enabled;
        currentRoom.transform.GetChild(1).GetComponent<RoomSync>().SetState(currentRoom.transform.GetChild(1).GetComponent<MeshRenderer>().enabled);
    }

    public void InnerWallsToggle()
    {
        currentRoom.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = !currentRoom.transform.GetChild(1).GetComponent<MeshRenderer>().enabled;
        currentRoom.transform.GetChild(0).GetComponent<RoomSync>().SetState(currentRoom.transform.GetChild(1).GetComponent<MeshRenderer>().enabled);
    }
}
