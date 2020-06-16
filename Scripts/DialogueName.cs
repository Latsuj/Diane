﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueName : MonoBehaviour
{
    public static DialogueName instance = null;
    private TextMeshProUGUI tmp;
    
    void Awake() {
        if(instance == null) {
            instance = this;
            return;
        }
        if(instance != this) {
            Destroy(gameObject);
            return;
        }
    }
    
    void Start() {
        tmp = GetComponent<TextMeshProUGUI>();
    }
    
    public void SetText(string text) {
        tmp.text=text;
    }
}
