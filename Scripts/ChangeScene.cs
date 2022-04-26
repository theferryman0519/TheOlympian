using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// List of Scenes - Main Scenes
    public static string Scene00 = "00FerrymanLogo";
	public static string Scene01 = "01MainLogo";
	public static string Scene02 = "02HomeScreen";
	public static string Scene03 = "03LoadGame";
	public static string Scene04 = "04NoSavedGames";
	public static string Scene05 = "05NewGameSetup";

	// List of Scenes - Tutorial Scenes
    public static string Scene06 = "06OpeningPrologue";
	public static string Scene07 = "07DayOneTutorial";
	public static string Scene08 = "08NightOneTutorial";
	public static string Scene09 = "09DayTwoTutorial";
	public static string Scene10 = "10NightTwoTutorial";
	public static string Scene11 = "11DayThreeTutorial";

	// List of Scenes - Gameplay Scenes
    public static string Scene12 = "12HomePlains";
	public static string Scene13 = "13OlympusLake";
	public static string Scene14 = "14ImmortalForest";
	public static string Scene15 = "15BoulderQuarry";
	public static string Scene16 = "16FertilePlains";
	public static string Scene17 = "17QuarryOfTheArts";
	public static string Scene18 = "18LakeOfDarkness";
	public static string Scene19 = "19EternalForest";
	public static string Scene20 = "20TidalMountain";
	public static string Scene21 = "21SculptorsQuarry";
	public static string Scene22 = "22WingedMountain";
	public static string Scene23 = "23RiverCocytus";
	public static string Scene24 = "24RiverLethe";
	public static string Scene25 = "25PlainsOfPlenty";
	public static string Scene26 = "26ForestOfTheGods";
	public static string Scene27 = "27RiverPhlegethon";
	public static string Scene28 = "28EverlastingPlains";
	public static string Scene29 = "29RiverAcheron";
	public static string Scene30 = "30ThunderMountain";
	public static string Scene31 = "31RiverStyx";
	public static string Scene32 = "32MountInferno";
	public static string Scene33 = "33EndOfDay";

	// List of Scenes - Extra Scenes
	public static string SceneAA = "AACredits";
	public static string SceneAB = "ABContact";
	
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
    public void Scene00Load() {
        SceneManager.LoadScene(Scene00);
    }

	public void Scene01Load() {
        SceneManager.LoadScene(Scene01);
    }

	public void Scene02Load() {
        SceneManager.LoadScene(Scene02);
    }

	public void Scene03Load() {
        SceneManager.LoadScene(Scene03);
    }

	public void Scene04Load() {
        SceneManager.LoadScene(Scene04);
    }

	public void Scene05Load() {
        SceneManager.LoadScene(Scene05);
    }

	public void Scene06Load() {
        SceneManager.LoadScene(Scene06);
    }

	public void Scene07Load() {
        SceneManager.LoadScene(Scene07);
    }

	public void Scene08Load() {
        SceneManager.LoadScene(Scene08);
    }

	public void Scene09Load() {
        SceneManager.LoadScene(Scene09);
    }

	public void Scene10Load() {
        SceneManager.LoadScene(Scene10);
    }

	public void Scene11Load() {
        SceneManager.LoadScene(Scene11);
    }

	public void Scene12Load() {
        SceneManager.LoadScene(Scene12);
    }

	public void Scene13Load() {
        SceneManager.LoadScene(Scene13);
    }

	public void Scene14Load() {
        SceneManager.LoadScene(Scene14);
    }

	public void Scene15Load() {
        SceneManager.LoadScene(Scene15);
    }

	public void Scene16Load() {
        SceneManager.LoadScene(Scene16);
    }

	public void Scene17Load() {
        SceneManager.LoadScene(Scene17);
    }

	public void Scene18Load() {
        SceneManager.LoadScene(Scene18);
    }

	public void Scene19Load() {
        SceneManager.LoadScene(Scene19);
    }

	public void Scene20Load() {
        SceneManager.LoadScene(Scene20);
    }

	public void Scene21Load() {
        SceneManager.LoadScene(Scene21);
    }

	public void Scene22Load() {
        SceneManager.LoadScene(Scene22);
    }

	public void Scene23Load() {
        SceneManager.LoadScene(Scene23);
    }

	public void Scene24Load() {
        SceneManager.LoadScene(Scene24);
    }

	public void Scene25Load() {
        SceneManager.LoadScene(Scene25);
    }

	public void Scene26Load() {
        SceneManager.LoadScene(Scene26);
    }

	public void Scene27Load() {
        SceneManager.LoadScene(Scene27);
    }

	public void Scene28Load() {
        SceneManager.LoadScene(Scene28);
    }

	public void Scene29Load() {
        SceneManager.LoadScene(Scene29);
    }

	public void Scene30Load() {
        SceneManager.LoadScene(Scene30);
    }

	public void Scene31Load() {
        SceneManager.LoadScene(Scene31);
    }

	public void Scene32Load() {
        SceneManager.LoadScene(Scene32);
    }

	public void SceneAALoad() {
        SceneManager.LoadScene(SceneAA);
    }

	public void SceneABLoad() {
        SceneManager.LoadScene(SceneAB);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}