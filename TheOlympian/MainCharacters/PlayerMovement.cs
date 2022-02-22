using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace TheOlympian.MainCharacters {
public class PlayerMovement : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public bool IsPlayerMoving;
	public string PlayerFacing;
	public SpriteAnimations spriteAnimations;
	public Vector3 PlayerPosition;

	public float TempleWidthA;
	public float TempleWidthB;
	public float TempleHeightA;
	public float TempleHeightB;

	public Text DateList;
	public List<int> DateSelections = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120};
	public int NextDate;

	public int DateDionysia = 20;
	public int DatePanathenaicA = 40;
	public int DatePanathenaicB = 44;
	public int DateHermaea = 85;
	public int DateAnthesteria = 100;

	public int DateHeroPerseus;
	public int DateHeroHeracles;
	public int DateHeroTheseus;
	public int DateHeroHector;
	public int DateHeroAchilles;
	public int DateHeroJason;
	public int DateHeroOdysseus;
	public int DateHeroAeneas;
	public int DateHeroOrpheus;

	public int DateDisasterCerberus;
	public int DateDisasterTyphon;
	public int DateDisasterVolcano;
	public int DateDisasterCyclops;
	public int DateDisasterScylla;
	public int DateDisasterHydra;
	public int DateDisasterCharybdis;
	public int DateDisasterChimera;
	public int DateDisasterMinotaur;
	public int DateDisasterMedusa;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		IsPlayerMoving = false;
		PlayerFacing = "Down";
		PlayerPosition = spriteAnimations.PlayerFaceDirection.transform.position;
		spriteAnimations.WalkingRotation = 1;
		spriteAnimations.WalkingRotationSpeed = 0.2f;

		RunDateSelection();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		TempleWidthA = 410.0f / OlympianVariables.CanvasMultiplier;
		TempleWidthB = 510.0f / OlympianVariables.CanvasMultiplier;
		TempleHeightA = 210.0f / OlympianVariables.CanvasMultiplier;
		TempleHeightB = 310.0f / OlympianVariables.CanvasMultiplier;
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		PlayerMoving();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void PlayerMoving() {
		if (Input.GetKey(KeyCode.DownArrow)) {
			IsPlayerMoving = true;
			PlayerFacing = "Down";
			PlayerMovingDown();
		}

		else if (Input.GetKey(KeyCode.UpArrow)) {
			IsPlayerMoving = true;
			PlayerFacing = "Up";
			PlayerMovingUp();
		}

		else if (Input.GetKey(KeyCode.LeftArrow)) {
			IsPlayerMoving = true;
			PlayerFacing = "Left";
			PlayerMovingLeft();
		}

		else if (Input.GetKey(KeyCode.RightArrow)) {
			IsPlayerMoving = true;
			PlayerFacing = "Right";
			PlayerMovingRight();
		}

		else {
			IsPlayerMoving = false;
			PlayerStandingStill();
		}

		spriteAnimations.PlayerFaceDirection.transform.position = PlayerPosition;
	}

	public void PlayerMovingDown() {
		PlayerPosition = PlayerPosition + (Vector3.up * -(Time.deltaTime) * OlympianVariables.CharacterSpeed);
		PlayerFootMovement();

		// Sprite Animation
		if (spriteAnimations.WalkingRotation == 1) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkDown1;
		}

		else if (spriteAnimations.WalkingRotation == 2) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkDown2;
		}

		else if (spriteAnimations.WalkingRotation == 3) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkDown1;
		}

		else if (spriteAnimations.WalkingRotation == 4) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkDown3;
		}

		// Border Blocker
		if ((PlayerPosition.y * Screen.width) <= (Screen.width * -4)) {
			PlayerPosition.y = -4;
		}
	}

	public void PlayerMovingUp() {
		PlayerPosition = PlayerPosition + (Vector3.up * (Time.deltaTime) * OlympianVariables.CharacterSpeed);
		PlayerFootMovement();

		// Sprite Animation
		if (spriteAnimations.WalkingRotation == 1) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkUp1;
		}

		else if (spriteAnimations.WalkingRotation == 2) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkUp2;
		}

		else if (spriteAnimations.WalkingRotation == 3) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkUp1;
		}

		else if (spriteAnimations.WalkingRotation == 4) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkUp3;
		}

		// Border Blocker
		if ((PlayerPosition.y * Screen.width) >= (Screen.width * 4)) {
			PlayerPosition.y = 4;
		}
	}

	public void PlayerMovingLeft() {
		PlayerPosition = PlayerPosition + (Vector3.right * -(Time.deltaTime) * OlympianVariables.CharacterSpeed);
		PlayerFootMovement();

		// Sprite Animation
		if (spriteAnimations.WalkingRotation == 1) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkLeft1;
		}

		else if (spriteAnimations.WalkingRotation == 2) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkLeft2;
		}

		else if (spriteAnimations.WalkingRotation == 3) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkLeft1;
		}

		else if (spriteAnimations.WalkingRotation == 4) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkLeft3;
		}

		// Border Blocker
		if ((PlayerPosition.x * Screen.width) <= (Screen.width * -8)) {
			PlayerPosition.x = -8;
		}
	}

	public void PlayerMovingRight() {
		PlayerPosition = PlayerPosition + (Vector3.right * (Time.deltaTime) * OlympianVariables.CharacterSpeed);
		PlayerFootMovement();

		// Sprite Animation
		if (spriteAnimations.WalkingRotation == 1) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkRight1;
		}

		else if (spriteAnimations.WalkingRotation == 2) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkRight2;
		}

		else if (spriteAnimations.WalkingRotation == 3) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkRight1;
		}

		else if (spriteAnimations.WalkingRotation == 4) {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkRight3;
		}

		// Border Blocker
		if ((PlayerPosition.x * Screen.width) >= (Screen.width * 8)) {
			PlayerPosition.x = 8;
		}
	}

	public void PlayerStandingStill() {
		if (PlayerFacing == "Up") {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkUp1;
		}

		else if (PlayerFacing == "Down") {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkDown1;
		}

		else if (PlayerFacing == "Left") {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkLeft1;
		}

		else if (PlayerFacing == "Right") {
			spriteAnimations.PlayerFaceDirection.sprite = OlympianVariables.WalkRight1;
		}
	}

	public void PlayerFootMovement() {
		spriteAnimations.WalkingTimer += Time.deltaTime;

		if (spriteAnimations.WalkingTimer >= spriteAnimations.WalkingRotationSpeed) {
			spriteAnimations.WalkingTimer = 0.0f;

			if (spriteAnimations.WalkingRotation == 1) {
				spriteAnimations.WalkingRotation = 2;
			}

			else if (spriteAnimations.WalkingRotation == 2) {
				spriteAnimations.WalkingRotation = 3;
			}

			else if (spriteAnimations.WalkingRotation == 3) {
				spriteAnimations.WalkingRotation = 4;
			}

			else if (spriteAnimations.WalkingRotation == 4) {
				spriteAnimations.WalkingRotation = 1;
			}
		}
	}

	public void RunDateSelection() {
		NextDate = 0;
		NextDateRandomizer();

		DateSelections.Remove(DateDionysia);
		DateSelections.Remove(DatePanathenaicA + 0);
		DateSelections.Remove(DatePanathenaicA + 1);
		DateSelections.Remove(DatePanathenaicA + 2);
		DateSelections.Remove(DatePanathenaicA + 3);
		DateSelections.Remove(DatePanathenaicB);
		DateSelections.Remove(DateHermaea);
		DateSelections.Remove(DateAnthesteria);

		DateList.text = "Dates:" + "\n" + "Dionysia: " + DateDionysia + "\n" + "Panathenaic Games: " + DatePanathenaicA + "-" + DatePanathenaicB + "\n" + "Hermaea: " + DateHermaea + "\n" + "Athesteria: " + DateAnthesteria + "\n" + "\n" + "Heroes:" + "\n" + "Perseus, the Monster Slayer: Starting " + DateHeroPerseus + "\n" + "Labors of Heracles: " + DateHeroHeracles + "\n" + "Theseus, Hero of Athens: " + DateHeroTheseus + "\n" + "Hector's Leadership: " + DateHeroHector + "\n" + "Immortality of Achilles: " + DateHeroAchilles + "\n" + "Jason and the Argonauts: " + DateHeroJason + "\n" + "Odysseus's Knowledge: " + DateHeroOdysseus + "\n" + "Love for Aeneas: " + DateHeroAeneas + "\n" + "Music of Orpheus: " + DateHeroOrpheus + "\n" + "\n" + "Disasters:" + "\n" + "Bite of Cerberus: " + DateDisasterCerberus + "\n" + "Rage of Typhon: " + DateDisasterTyphon + "\n" + "Volcanic Eruption: " + DateDisasterVolcano + "\n" + "Vision of the Cyclops: " + DateDisasterCyclops + "\n" + "Scylla's Wrath: " + DateDisasterScylla + "\n" + "Flood of the Hydra: " + DateDisasterHydra + "\n" + "Drought of Charybdis: " + DateDisasterCharybdis + "\n" + "Chimera's Gale: " + DateDisasterChimera + "\n" + "Minotaur's Revenge: " + DateDisasterMinotaur + "\n" + "Gaze of Medusa: " + DateDisasterMedusa;
	}

	public void NextDateRandomizer() {
		if (NextDate == 0) {
			DateHeroPerseus = Random.Range(1,121);
			RandomizePerseus();
		}

		else if (NextDate == 1) {
			DateHeroHeracles = Random.Range(1,121);
			RandomizeHeracles();
		}
		
		else if (NextDate == 2) {
			DateHeroTheseus = Random.Range(1,121);
			RandomizeTheseus();
		}

		else if (NextDate == 3) {
			DateDisasterCerberus = Random.Range(1,121);
			RandomizeCerberus();
		}

		else if (NextDate == 4) {
			DateDisasterTyphon = Random.Range(1,121);
			RandomizeTyphon();
		}

		else if (NextDate == 5) {
			DateHeroHector = Random.Range(1,121);
			RandomizeHector();
		}

		else if (NextDate == 6) {
			DateDisasterVolcano = Random.Range(1,121);
			RandomizeVolcano();
		}

		else if (NextDate == 7) {
			DateDisasterCyclops = Random.Range(1,121);
			RandomizeCyclops();
		}

		else if (NextDate == 8) {
			DateDisasterScylla = Random.Range(1,121);
			RandomizeScylla();
		}

		else if (NextDate == 9) {
			DateHeroAchilles = Random.Range(1,121);
			RandomizeAchilles();
		}

		else if (NextDate == 10) {
			DateDisasterHydra = Random.Range(1,121);
			RandomizeHydra();
		}

		else if (NextDate == 11) {
			DateDisasterCharybdis = Random.Range(1,121);
			RandomizeCharybdis();
		}

		else if (NextDate == 12) {
			DateHeroJason = Random.Range(1,121);
			RandomizeJason();
		}

		else if (NextDate == 13) {
			DateHeroOdysseus = Random.Range(1,121);
			RandomizeOdysseus();
		}

		else if (NextDate == 14) {
			DateHeroAeneas = Random.Range(1,121);
			RandomizeAeneas();
		}

		else if (NextDate == 15) {
			DateHeroOrpheus = Random.Range(1,121);
			RandomizeOrpheus();
		}

		else if (NextDate == 16) {
			DateDisasterChimera = Random.Range(1,121);
			RandomizeChimera();
		}

		else if (NextDate == 17) {
			DateDisasterMinotaur = Random.Range(1,121);
			RandomizeMinotaur();
		}

		else if (NextDate == 18) {
			DateDisasterMedusa = Random.Range(1,121);
			RandomizeMedusa();
		}
	}

	public void RandomizePerseus() {
		if (DateSelections.Contains(DateHeroPerseus)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroPerseus);
			NextDate = 1;
			NextDateRandomizer();
		}
	}

	public void RandomizeHeracles() {
		if (DateSelections.Contains(DateHeroHeracles)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroHeracles);
			NextDate = 2;
			NextDateRandomizer();
		}
	}

	public void RandomizeTheseus() {
		if (DateSelections.Contains(DateHeroTheseus)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroTheseus);
			NextDate = 3;
			NextDateRandomizer();
		}
	}

	public void RandomizeCerberus() {
		if (DateSelections.Contains(DateDisasterCerberus)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterCerberus);
			NextDate = 4;
			NextDateRandomizer();
		}
	}

	public void RandomizeTyphon() {
		if (DateSelections.Contains(DateDisasterTyphon)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterTyphon);
			NextDate = 5;
			NextDateRandomizer();
		}
	}

	public void RandomizeHector() {
		if (DateSelections.Contains(DateHeroHector)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroHector);
			NextDate = 6;
			NextDateRandomizer();
		}
	}

	public void RandomizeVolcano() {
		if (DateSelections.Contains(DateDisasterVolcano)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterVolcano);
			NextDate = 7;
			NextDateRandomizer();
		}
	}

	public void RandomizeCyclops() {
		if (DateSelections.Contains(DateDisasterCyclops)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterCyclops);
			NextDate = 8;
			NextDateRandomizer();
		}
	}

	public void RandomizeScylla() {
		if (DateSelections.Contains(DateDisasterScylla)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterScylla);
			NextDate = 9;
			NextDateRandomizer();
		}
	}

	public void RandomizeAchilles() {
		if (DateSelections.Contains(DateHeroAchilles)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroAchilles);
			NextDate = 10;
			NextDateRandomizer();
		}
	}

	public void RandomizeHydra() {
		if (DateSelections.Contains(DateDisasterHydra)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterHydra);
			NextDate = 11;
			NextDateRandomizer();
		}
	}

	public void RandomizeCharybdis() {
		if (DateSelections.Contains(DateDisasterCharybdis)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterCharybdis);
			NextDate = 12;
			NextDateRandomizer();
		}
	}

	public void RandomizeJason() {
		if (DateSelections.Contains(DateHeroJason)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroJason);
			NextDate = 13;
			NextDateRandomizer();
		}
	}

	public void RandomizeOdysseus() {
		if (DateSelections.Contains(DateHeroOdysseus)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroOdysseus);
			NextDate = 14;
			NextDateRandomizer();
		}
	}

	public void RandomizeAeneas() {
		if (DateSelections.Contains(DateHeroAeneas)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroAeneas);
			NextDate = 15;
			NextDateRandomizer();
		}
	}

	public void RandomizeOrpheus() {
		if (DateSelections.Contains(DateHeroOrpheus)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateHeroOrpheus);
			NextDate = 16;
			NextDateRandomizer();
		}
	}

	public void RandomizeChimera() {
		if (DateSelections.Contains(DateDisasterChimera)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterChimera);
			NextDate = 17;
			NextDateRandomizer();
		}
	}

	public void RandomizeMinotaur() {
		if (DateSelections.Contains(DateDisasterMinotaur)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterMinotaur);
			NextDate = 18;
			NextDateRandomizer();
		}
	}

	public void RandomizeMedusa() {
		if (DateSelections.Contains(DateDisasterMedusa)) {
			NextDateRandomizer();
		}

		else {
			DateSelections.Remove(DateDisasterMedusa);
			NextDate = 0;
			NextDateRandomizer();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}
}