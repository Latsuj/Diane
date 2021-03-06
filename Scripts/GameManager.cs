﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    [SerializeField] private bool playerHasLeft=true;
    [SerializeField] private bool playerHasRight=true;
    [SerializeField] private bool playerHasJump=false;
    [SerializeField] private bool playerHasLiliputian=false;
    [SerializeField] private bool playerHasBenediction=false;
    
    private Player player;
    private Timer timer;
    private Transitions transitions;
    
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
        transitions = Transitions.instance;
        
        transitions.StartAnimations();
    }
    
    void Update() {
        if(player.IsPlayerMadeOneMove() && !timer.IsTimeStarted()) timer.StartTime(); 
    }
    
    public void ActionBenediction(GameObject obj) {
        if(obj.layer== LayerMask.NameToLayer("LoadingNewLevel")) transitions.EndAnimations();
        if(obj.layer== LayerMask.NameToLayer("Teleportation")) transitions.EndAnimations();
    }
    
    // GETTER
    
    public bool isPlayerHasLeft () {
        return playerHasLeft;
    }
    
    public bool isPlayerHasRight () {
        return playerHasRight;
    }
    
    public bool isPlayerHasJump () {
        return playerHasJump;
    }
    
    public bool isPlayerHasLiliputian () {
        return playerHasLiliputian;
    }
    
    public bool isPlayerHasBenediction () {
        return playerHasBenediction;
    }
}
