using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using CustomExtensions;

public class GameBehavior : MonoBehaviour, IManager
{
    private int _itemsCollected = 0;
    private int _playerHP = 1;
    public int MaxItems = 4;
    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;
    public Button WinButton;
    public Button LossButton; 

    private string _state; 
    public string State  
    { 
        get { return _state; } 
        set { _state = value; } 
    }

    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
        Initialize();
    }

    public void Initialize()  
    { 
        _state = "Game Manager initialized..";
        _state.FancyDebug();
        Debug.Log(_state);
    }

    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            ItemText.text = "Items: " + Items;

            if (_itemsCollected >= MaxItems)
            {
                WinButton.gameObject.SetActive(true);
                UpdateScene("You've found all the items!");
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            HealthText.text = "Health: " + HP;
            
            if(_playerHP <= 0) 
            { 
                LossButton.gameObject.SetActive(true); 
                UpdateScene("You want another life with that?");
            } 
            else 
            { 
                ProgressText.text = "Ouch... that's got hurt."; 
            }
        }
    }

    public void UpdateScene(string updatedText)
    {
        ProgressText.text = updatedText;
        Time.timeScale = 0f;
    }
    
    public void RestartScene()
    {
        Utilities.RestartLevel(0);
    }
}