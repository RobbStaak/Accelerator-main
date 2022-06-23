using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPlayerEnterValueAndClock : MonoBehaviour
{

    private string _Time;
    [SerializeField]
    private TMP_Text Clock;
    private int NextUpdateForClock = 0;
    public int UpdateInterval = 1;


    [SerializeField]
    public TMP_Text PlayerEnterValue;
    private int IncrementValue;
    private int CurrentValue;


    void Start()
    {
        GetSavedPlayerEnterValue();
        IncrementValue = CurrentValue + 1;
        SavePlayerEnterValue();
        SetPlayerEnterValue();

        Debug.Log("Times Started " + (CurrentValue + 1));
    }

    void Update()
    {
        if (Time.time >= NextUpdateForClock)
        {
            NextUpdateForClock = NextUpdateForClock + UpdateInterval;
            SetClock(); // update only once every second.
        }
    }

    private void SetClock()
    {
        _Time = System.DateTime.Now.ToString("HH:mm");
        Clock.text = _Time;
        Debug.Log(_Time); //  = print(time)
    }


    public void SetPlayerEnterValue()
    {
        PlayerEnterValue.text = IncrementValue.ToString();
    }


    public void SavePlayerEnterValue()
    {
        PlayerPrefs.SetInt("PlayerEnterValue", IncrementValue);
    }

    public void GetSavedPlayerEnterValue()
    {
        CurrentValue = PlayerPrefs.GetInt("PlayerEnterValue", 0);
    }

}
