using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace TheOlympian {
public class OlympianVariables : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// Main Character
	public static float CharacterSpeed = 2.0f;
	public static Sprite WalkDown1 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Down1");
	public static Sprite WalkDown2 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Down2");
	public static Sprite WalkDown3 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Down3");
	public static Sprite WalkUp1 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Up1");
	public static Sprite WalkUp2 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Up2");
	public static Sprite WalkUp3 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Up3");
	public static Sprite WalkLeft1 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Left1");
	public static Sprite WalkLeft2 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Left2");
	public static Sprite WalkLeft3 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Left3");
	public static Sprite WalkRight1 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Right1");
	public static Sprite WalkRight2 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Right2");
	public static Sprite WalkRight3 = Resources.Load<Sprite>("Sprites - Demo/Characters/MainCharacter_Right3");

	// Screen Canvas
	public static float CanvasMultiplier = 90.0f;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}
}