using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI killsText;
	public TextMeshProUGUI ultText;


    // instance
    public static GameUI instance;

    void Awake ()
    {
        instance = this;
    }

    public void UpdateGoldText (int gold)
    {
        goldText.text = "<b>Gold:</b> " + gold;
    }
	
	public void UpdateKillsText (int kills)
    {
        killsText.text = "<b>Kills:</b> " + kills;
    }
	public void ActivateUltText (bool state)
    {
        ultText.gameObject.SetActive(state);
    }
}