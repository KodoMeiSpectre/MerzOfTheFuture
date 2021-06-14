using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIpanelSwitch : MonoBehaviour
{
    public CanvasGroup panel1;
    public CanvasGroup panel2;
    public CanvasGroup panel3;

    public void SwitchToOne()
    {
        panel1.interactable = true;
        panel1.blocksRaycasts = true;
        panel1.alpha = 1;

        panel2.interactable = false;
        panel2.blocksRaycasts = false;
        panel2.alpha = 0;

        panel3.interactable = false;
        panel3.blocksRaycasts = false;
        panel3.alpha = 0;
    }

    public void SwitchToTwo()
    {
        panel2.interactable = true;
        panel2.blocksRaycasts = true;
        panel2.alpha = 1;

        panel1.interactable = false;
        panel1.blocksRaycasts = false;
        panel1.alpha = 0;

        panel3.interactable = false;
        panel3.blocksRaycasts = false;
        panel3.alpha = 0;
    }

    public void SwitchToThree()
    {
        panel3.interactable = true;
        panel3.blocksRaycasts = true;
        panel3.alpha = 1;

        panel2.interactable = false;
        panel2.blocksRaycasts = false;
        panel2.alpha = 0;

        panel1.interactable = false;
        panel1.blocksRaycasts = false;
        panel1.alpha = 0;
    }
}
