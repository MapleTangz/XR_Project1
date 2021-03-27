﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference website : https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html?_ga=2.266262607.1952254344.1616490663-554022353.1614679359

public enum GameState {
    TALKING,
    SCENE1,
    SCENE2,
    SCENE3,
    SCENE4,
    OTHER,
    DISABLE
}

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    // default display time
    public float dis_time;

    private static GameState stage_state; 
    public static GameState current_state;
    private void Awake() {
        DontDestroyOnLoad(gameObject);
        set_scene(GameState.SCENE1);
    }
    // Start is called before the first frame update
    void Start()
    {
        GM = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameState get_state(){
        return current_state;
    }

    public void set_scene(GameState next_state){
        switch (next_state)
        {
            case GameState.OTHER:
                current_state = stage_state;
                Debug.Log("Set up scene back to : " + current_state);
                break;
            default:
                stage_state = next_state;
                current_state = next_state;
                Debug.Log("Change scene to : " + current_state);
                break;
        }
    }

    public void set_talking(){
        current_state = GameState.TALKING;
        Debug.Log("Change to : " + current_state);
    }
}
