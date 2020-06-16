﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private Player player;
    private Timer timer;
    
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
        player = Player.instance;
        timer = Timer.instance;
    }
    
    void Update() {
        if(player.IsPlayerMadeOneMove() && !timer.IsTimeStarted()) timer.StartTime(); 
    }
}