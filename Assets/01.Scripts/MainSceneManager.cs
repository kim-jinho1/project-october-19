using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private GameObject _panel;

    private void Awake()
    {
        _inputReader.OnKey += NextScene();
    }

    private Action NextScene()
    {
        _panel.SetActive(false);
        
        return null;
    }


    private void Update()
    {
        
    }
    
}
