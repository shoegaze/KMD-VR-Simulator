﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorController : MonoBehaviour {
  public Material[] wallMaterial;
  Renderer rend;
  
  // Appears in the Inspector view from where you can assign the textbox
  public TextMeshProUGUI displayText;
  
  // Start is called before the first frame update
  void Start() {
    // Assigns the component's renderer instance
    rend = GetComponent<Renderer>();
    rend.enabled = true;
    displayText.text = "";
  }
  
  // Called when the ball collides with the wall
  private void OnCollisionEnter(Collision col) {
    // Checks if the player ball has collided with the wall.
    if (col.gameObject.name == "Player") {
      displayText.text = "Ouch!";
      rend.sharedMaterial = wallMaterial[0];
    }
  }
   
  // It is called when the ball moves away from the wall
  private void OnCollisionExit(Collision col) {
    if (col.gameObject.name == "Player")
    {
      rend.sharedMaterial = wallMaterial[1];
      displayText.text = "Keep Rolling...";
    }
  }
}