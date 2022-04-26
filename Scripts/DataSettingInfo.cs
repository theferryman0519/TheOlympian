using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class DataSettingInfo : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Text UpperBarDateText;
	public Text UpperBarTimeText;
	public Text UpperBarLightText;
	public Text UpperBarLocationText;
	public Text LowerBarGEJarText;
	public Text LowerBarCoinsText;

	public float AddingTime = 0.0f;
	public float MinuteIntervals = 6.0f;
	public Scene CurrentLocation;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		CurrentLocation = SceneManager.GetActiveScene();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		SettingDate();
		SettingTime();
		SettingLight();
		SettingLocation();
		SettingGEJar();
		SettingCoins();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void SettingDate() {
		if ((PlayerSaveDataPoints.PlayerDayTracker == 0) || (PlayerSaveDataPoints.PlayerSeasonTracker == 0) || (PlayerSaveDataPoints.PlayerYearTracker == 0)) {
			PlayerSaveDataPoints.PlayerDayTracker = 1;
			PlayerSaveDataPoints.PlayerSeasonTracker = 1;
			PlayerSaveDataPoints.PlayerYearTracker = 1;
		}

		if (PlayerSaveDataPoints.PlayerSeasonTracker == 1) {
			UpperBarDateText.text = "Day " + PlayerSaveDataPoints.PlayerDayTracker.ToString() + ", Spring, Year " + PlayerSaveDataPoints.PlayerYearTracker.ToString();
		}

		else if (PlayerSaveDataPoints.PlayerSeasonTracker == 2) {
			UpperBarDateText.text = "Day " + PlayerSaveDataPoints.PlayerDayTracker.ToString() + ", Summer, Year " + PlayerSaveDataPoints.PlayerYearTracker.ToString();
		}

		else if (PlayerSaveDataPoints.PlayerSeasonTracker == 3) {
			UpperBarDateText.text = "Day " + PlayerSaveDataPoints.PlayerDayTracker.ToString() + ", Autumn, Year " + PlayerSaveDataPoints.PlayerYearTracker.ToString();
		}

		else if (PlayerSaveDataPoints.PlayerSeasonTracker == 4) {
			UpperBarDateText.text = "Day " + PlayerSaveDataPoints.PlayerDayTracker.ToString() + ", Winter, Year " + PlayerSaveDataPoints.PlayerYearTracker.ToString();
		}
	}

	public void SettingNewDay() {
		PlayerSaveDataPoints.PlayerDayTracker = PlayerSaveDataPoints.PlayerDayTracker + 1;

		if (PlayerSaveDataPoints.PlayerDayTracker >= 31) {
			PlayerSaveDataPoints.PlayerSeasonTracker = PlayerSaveDataPoints.PlayerSeasonTracker + 1;
			PlayerSaveDataPoints.PlayerDayTracker = 1;
		}

		if (PlayerSaveDataPoints.PlayerSeasonTracker >= 5) {
			PlayerSaveDataPoints.PlayerYearTracker = PlayerSaveDataPoints.PlayerYearTracker + 1;
			PlayerSaveDataPoints.PlayerSeasonTracker = 1;
			PlayerSaveDataPoints.PlayerDayTracker = 1;
		}

		PlayerSaveDataPoints.PlayerTimeTracker = 0;
		PlayerSaveDataPoints.PlayerTimePaused = true;
	}

	public void SettingTime() {
		if (PlayerSaveDataPoints.PlayerTimePaused == false) {
			if (PlayerSaveDataPoints.PlayerTimeTracker == 0) {
				PlayerSaveDataPoints.PlayerTimeTracker = 1;
			}

			AddingTime = AddingTime + Time.deltaTime;

			if (AddingTime >= MinuteIntervals) {
				PlayerSaveDataPoints.PlayerTimeTracker = PlayerSaveDataPoints.PlayerTimeTracker + 1;
				AddingTime = 0.0f;
			}
		}

		else if (PlayerSaveDataPoints.PlayerTimePaused == true) {
			PlayerSaveDataPoints.PlayerTimeTracker = PlayerSaveDataPoints.PlayerTimeTracker + 0;
		}

		switch (PlayerSaveDataPoints.PlayerTimeTracker) {
		case 1:
			UpperBarTimeText.text = "7:00";
			break;
		case 2:
			UpperBarTimeText.text = "7:15";
			break;
		case 3:
			UpperBarTimeText.text = "7:30";
			break;
		case 4:
			UpperBarTimeText.text = "7:45";
			break;
		case 5:
			UpperBarTimeText.text = "8:00";
			break;
		case 6:
			UpperBarTimeText.text = "8:15";
			break;
		case 7:
			UpperBarTimeText.text = "8:30";
			break;
		case 8:
			UpperBarTimeText.text = "8:45";
			break;
		case 9:
			UpperBarTimeText.text = "9:00";
			break;
		case 10:
			UpperBarTimeText.text = "9:15";
			break;
		case 11:
			UpperBarTimeText.text = "9:30";
			break;
		case 12:
			UpperBarTimeText.text = "9:45";
			break;
		case 13:
			UpperBarTimeText.text = "10:00";
			break;
		case 14:
			UpperBarTimeText.text = "10:15";
			break;
		case 15:
			UpperBarTimeText.text = "10:30";
			break;
		case 16:
			UpperBarTimeText.text = "10:45";
			break;
		case 17:
			UpperBarTimeText.text = "11:00";
			break;
		case 18:
			UpperBarTimeText.text = "11:15";
			break;
		case 19:
			UpperBarTimeText.text = "11:30";
			break;
		case 20:
			UpperBarTimeText.text = "11:45";
			break;
		case 21:
			UpperBarTimeText.text = "12:00";
			break;
		case 22:
			UpperBarTimeText.text = "12:15";
			break;
		case 23:
			UpperBarTimeText.text = "12:30";
			break;
		case 24:
			UpperBarTimeText.text = "12:45";
			break;
		case 25:
			UpperBarTimeText.text = "1:00";
			break;
		case 26:
			UpperBarTimeText.text = "1:15";
			break;
		case 27:
			UpperBarTimeText.text = "1:30";
			break;
		case 28:
			UpperBarTimeText.text = "1:45";
			break;
		case 29:
			UpperBarTimeText.text = "2:00";
			break;
		case 30:
			UpperBarTimeText.text = "2:15";
			break;
		case 31:
			UpperBarTimeText.text = "2:30";
			break;
		case 32:
			UpperBarTimeText.text = "2:45";
			break;
		case 33:
			UpperBarTimeText.text = "3:00";
			break;
		case 34:
			UpperBarTimeText.text = "3:15";
			break;
		case 35:
			UpperBarTimeText.text = "3:30";
			break;
		case 36:
			UpperBarTimeText.text = "3:45";
			break;
		case 37:
			UpperBarTimeText.text = "4:00";
			break;
		case 38:
			UpperBarTimeText.text = "4:15";
			break;
		case 39:
			UpperBarTimeText.text = "4:30";
			break;
		case 40:
			UpperBarTimeText.text = "4:45";
			break;
		case 41:
			UpperBarTimeText.text = "5:00";
			break;
		case 42:
			UpperBarTimeText.text = "5:15";
			break;
		case 43:
			UpperBarTimeText.text = "5:30";
			break;
		case 44:
			UpperBarTimeText.text = "5:45";
			break;
		case 45:
			UpperBarTimeText.text = "6:00";
			break;
		case 46:
			UpperBarTimeText.text = "6:15";
			break;
		case 47:
			UpperBarTimeText.text = "6:30";
			break;
		case 48:
			UpperBarTimeText.text = "6:45";
			break;
		case 49:
			UpperBarTimeText.text = "7:00";
			break;
		case 50:
			UpperBarTimeText.text = "7:15";
			break;
		case 51:
			UpperBarTimeText.text = "7:30";
			break;
		case 52:
			UpperBarTimeText.text = "7:45";
			break;
		case 53:
			UpperBarTimeText.text = "8:00";
			break;
		case 54:
			UpperBarTimeText.text = "8:15";
			break;
		case 55:
			UpperBarTimeText.text = "8:30";
			break;
		case 56:
			UpperBarTimeText.text = "8:45";
			break;
		case 57:
			UpperBarTimeText.text = "9:00";
			break;
		case 58:
			UpperBarTimeText.text = "9:15";
			break;
		case 59:
			UpperBarTimeText.text = "9:30";
			break;
		case 60:
			UpperBarTimeText.text = "9:45";
			break;
		case 61:
			UpperBarTimeText.text = "10:00";
			break;
		case 62:
			UpperBarTimeText.text = "10:15";
			break;
		case 63:
			UpperBarTimeText.text = "10:30";
			break;
		case 64:
			UpperBarTimeText.text = "10:45";
			break;
		case 65:
			UpperBarTimeText.text = "11:00";
			break;
		case 66:
			UpperBarTimeText.text = "11:15";
			break;
		case 67:
			UpperBarTimeText.text = "11:30";
			break;
		case 68:
			UpperBarTimeText.text = "11:45";
			break;
		case 69:
			UpperBarTimeText.text = "12:00";
			break;
		case 70:
			UpperBarTimeText.text = "12:15";
			break;
		case 71:
			UpperBarTimeText.text = "12:30";
			break;
		case 72:
			UpperBarTimeText.text = "12:45";
			break;
		case 73:
			UpperBarTimeText.text = "1:00";
			SettingNewDay();
			PlayerSaveDataPoints.PlayerTimeTracker = 1;
			break;
		}
	}

	public void SettingLight() {
		if ((PlayerSaveDataPoints.PlayerTimeTracker >= 0) && (PlayerSaveDataPoints.PlayerTimeTracker < 9)) {
			PlayerSaveDataPoints.PlayerLightTracker = "Dawn";
		}

		else if ((PlayerSaveDataPoints.PlayerTimeTracker >= 9) && (PlayerSaveDataPoints.PlayerTimeTracker < 41)) {
			PlayerSaveDataPoints.PlayerLightTracker = "Day";
		}

		else if ((PlayerSaveDataPoints.PlayerTimeTracker >= 41) && (PlayerSaveDataPoints.PlayerTimeTracker < 53)) {
			PlayerSaveDataPoints.PlayerLightTracker = "Dusk";
		}

		else if ((PlayerSaveDataPoints.PlayerTimeTracker >= 53) && (PlayerSaveDataPoints.PlayerTimeTracker < 74)) {
			PlayerSaveDataPoints.PlayerLightTracker = "Night";
		}

		UpperBarLightText.text = PlayerSaveDataPoints.PlayerLightTracker;
	}

	public void SettingLocation() {
		if ((CurrentLocation.name == "07DayOneTutorial") || (CurrentLocation.name == "09DayTwoTutorial") || (CurrentLocation.name == "11DayThreeTutorial") || (CurrentLocation.name == "12HomePlains")) {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Home Plains (Spiti)";
		}

		else if (CurrentLocation.name == "13OlympusLake") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Olympus Lake (Spiti)";
		}

		else if (CurrentLocation.name == "14ImmortalForest") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Immortal Forest (Spiti)";
		}

		else if (CurrentLocation.name == "15BoulderQuarry") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Boulder Quarry (Spiti)";
		}

		else if (CurrentLocation.name == "16FertilePlains") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Fertile Plains (Nychta)";
		}

		else if (CurrentLocation.name == "17QuarryOfTheArts") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Quarry of the Arts (Nychta)";
		}

		else if (CurrentLocation.name == "18LakeOfDarkness") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Lake of Darkness (Nychta)";
		}

		else if (CurrentLocation.name == "19EternalForest") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Eternal Forest (Nychta)";
		}

		else if (CurrentLocation.name == "20TidalMountain") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Tidal Mountain (Korfi)";
		}

		else if (CurrentLocation.name == "21SculptorsQuarry") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Sculptor's Quarry (Korfi)";
		}

		else if (CurrentLocation.name == "22WingedMountain") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Winged Mountain (Korfi)";
		}

		else if (CurrentLocation.name == "23RiverCocytus") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "River Cocytus (River System)";
		}

		else if (CurrentLocation.name == "24RiverLethe") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "River Lethe (River System)";
		}

		else if (CurrentLocation.name == "25PlainsOfPlenty") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Plains of Plenty (Korfi)";
		}

		else if (CurrentLocation.name == "26ForestOfTheGods") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Forest of the Gods (Theikos)";
		}

		else if (CurrentLocation.name == "27RiverPhlegethon") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "River Phlegethon (River System)";
		}

		else if (CurrentLocation.name == "28EverlastingPlains") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Everlasting Plains (Theikos)";
		}

		else if (CurrentLocation.name == "29RiverAcheron") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "River Acheron (River System)";
		}

		else if (CurrentLocation.name == "30ThunderMountain") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Thunder Mountain (Theikos)";
		}

		else if (CurrentLocation.name == "31RiverStyx") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "River Styx (River System)";
		}

		else if (CurrentLocation.name == "32MountInferno") {
			PlayerSaveDataPoints.PlayerCurrentLocation = "Mount Inferno (Lyomenos)";
		}

		UpperBarLocationText.text = PlayerSaveDataPoints.PlayerCurrentLocation;
	}

	public void SettingGEJar() {
		SumAllGEJars();
		LowerBarGEJarText.text = "Jar of Good & Evil (" + PlayerSaveDataPoints.PlayerOverallGEJar + ")";
	}

	public void SettingCoins() {
		LowerBarCoinsText.text = PlayerSaveDataPoints.PlayerTotalCoins + " Coins";
	}

	public void SumAllGEJars() {
		if (PlayerSaveDataPoints.PlayerMetAchlys == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAchlys;
		}

		if (PlayerSaveDataPoints.PlayerMetAeolus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAeolus;
		}

		if (PlayerSaveDataPoints.PlayerMetAether == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAether;
		}

		if (PlayerSaveDataPoints.PlayerMetAion == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAion;
		}

		if (PlayerSaveDataPoints.PlayerMetAnanke == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAnanke;
		}

		if (PlayerSaveDataPoints.PlayerMetAphrodite == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAphrodite;
		}

		if (PlayerSaveDataPoints.PlayerMetApollo == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarApollo;
		}

		if (PlayerSaveDataPoints.PlayerMetAres == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAres;
		}

		if (PlayerSaveDataPoints.PlayerMetAriadne == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAriadne;
		}

		if (PlayerSaveDataPoints.PlayerMetArtemis == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarArtemis;
		}

		if (PlayerSaveDataPoints.PlayerMetAsclepius == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAsclepius;
		}

		if (PlayerSaveDataPoints.PlayerMetAsteria == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAsteria;
		}

		if (PlayerSaveDataPoints.PlayerMetAstraeus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAstraeus;
		}

		if (PlayerSaveDataPoints.PlayerMetAthena == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAthena;
		}

		if (PlayerSaveDataPoints.PlayerMetAtlas == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarAtlas;
		}

		if (PlayerSaveDataPoints.PlayerMetBia == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarBia;
		}

		if (PlayerSaveDataPoints.PlayerMetChaos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarChaos;
		}

		if (PlayerSaveDataPoints.PlayerMetChronos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarChronos;
		}

		if (PlayerSaveDataPoints.PlayerMetCoeus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarCoeus;
		}

		if (PlayerSaveDataPoints.PlayerMetCratos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarCratos;
		}

		if (PlayerSaveDataPoints.PlayerMetCrius == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarCrius;
		}

		if (PlayerSaveDataPoints.PlayerMetDeimos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarDeimos;
		}

		if (PlayerSaveDataPoints.PlayerMetDemeter == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarDemeter;
		}

		if (PlayerSaveDataPoints.PlayerMetDione == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarDione;
		}

		if (PlayerSaveDataPoints.PlayerMetDionysus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarDionysus;
		}

		if (PlayerSaveDataPoints.PlayerMetEileithyia == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarEileithyia;
		}

		if (PlayerSaveDataPoints.PlayerMetEnyo == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarEnyo;
		}

		if (PlayerSaveDataPoints.PlayerMetEos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarEos;
		}

		if (PlayerSaveDataPoints.PlayerMetEpimetheus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarEpimetheus;
		}

		if (PlayerSaveDataPoints.PlayerMetErebus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarErebus;
		}

		if (PlayerSaveDataPoints.PlayerMetEris == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarEris;
		}

		if (PlayerSaveDataPoints.PlayerMetEros == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarEros;
		}

		if (PlayerSaveDataPoints.PlayerMetGaia == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarGaia;
		}

		if (PlayerSaveDataPoints.PlayerMetGeras == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarGeras;
		}

		if (PlayerSaveDataPoints.PlayerMetHades == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHades;
		}

		if (PlayerSaveDataPoints.PlayerMetHarmonia == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHarmonia;
		}

		if (PlayerSaveDataPoints.PlayerMetHebe == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHebe;
		}

		if (PlayerSaveDataPoints.PlayerMetHecate == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHecate;
		}

		if (PlayerSaveDataPoints.PlayerMetHelios == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHelios;
		}

		if (PlayerSaveDataPoints.PlayerMetHemera == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHemera;
		}

		if (PlayerSaveDataPoints.PlayerMetHephaestus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHephaestus;
		}

		if (PlayerSaveDataPoints.PlayerMetHera == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHera;
		}

		if (PlayerSaveDataPoints.PlayerMetHermes == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHermes;
		}

		if (PlayerSaveDataPoints.PlayerMetHestia == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHestia;
		}

		if (PlayerSaveDataPoints.PlayerMetHyperion == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHyperion;
		}

		if (PlayerSaveDataPoints.PlayerMetHypnos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarHypnos;
		}

		if (PlayerSaveDataPoints.PlayerMetIapetus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarIapetus;
		}

		if (PlayerSaveDataPoints.PlayerMetIris == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarIris;
		}

		if (PlayerSaveDataPoints.PlayerMetJanus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarJanus;
		}

		if (PlayerSaveDataPoints.PlayerMetKhione == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarKhione;
		}

		if (PlayerSaveDataPoints.PlayerMetLeto == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarLeto;
		}

		if (PlayerSaveDataPoints.PlayerMetMelinoe == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarMelinoe;
		}

		if (PlayerSaveDataPoints.PlayerMetMenoetius == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarMenoetius;
		}

		if (PlayerSaveDataPoints.PlayerMetMetis == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarMetis;
		}

		if (PlayerSaveDataPoints.PlayerMetMnemosyne == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarMnemosyne;
		}

		if (PlayerSaveDataPoints.PlayerMetMomus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarMomus;
		}

		if (PlayerSaveDataPoints.PlayerMetMoros == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarMoros;
		}

		if (PlayerSaveDataPoints.PlayerMetMorpheus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarMorpheus;
		}

		if (PlayerSaveDataPoints.PlayerMetNemesis == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarNemesis;
		}

		if (PlayerSaveDataPoints.PlayerMetNike == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarNike;
		}

		if (PlayerSaveDataPoints.PlayerMetNyx == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarNyx;
		}

		if (PlayerSaveDataPoints.PlayerMetOceanus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarOceanus;
		}

		if (PlayerSaveDataPoints.PlayerMetPallas == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPallas;
		}

		if (PlayerSaveDataPoints.PlayerMetPan == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPan;
		}

		if (PlayerSaveDataPoints.PlayerMetPersephone == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPersephone;
		}

		if (PlayerSaveDataPoints.PlayerMetPerses == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPerses;
		}

		if (PlayerSaveDataPoints.PlayerMetPhanes == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPhanes;
		}

		if (PlayerSaveDataPoints.PlayerMetPhobos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPhobos;
		}

		if (PlayerSaveDataPoints.PlayerMetPhoebe == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPhoebe;
		}

		if (PlayerSaveDataPoints.PlayerMetPontus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPontus;
		}

		if (PlayerSaveDataPoints.PlayerMetPoseidon == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPoseidon;
		}

		if (PlayerSaveDataPoints.PlayerMetPrometheus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPrometheus;
		}

		if (PlayerSaveDataPoints.PlayerMetPsyche == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarPsyche;
		}

		if (PlayerSaveDataPoints.PlayerMetRhea == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarRhea;
		}

		if (PlayerSaveDataPoints.PlayerMetSelene == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarSelene;
		}

		if (PlayerSaveDataPoints.PlayerMetStyx == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarStyx;
		}

		if (PlayerSaveDataPoints.PlayerMetTartarus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarTartarus;
		}

		if (PlayerSaveDataPoints.PlayerMetTethys == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarTethys;
		}

		if (PlayerSaveDataPoints.PlayerMetThalassa == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarThalassa;
		}

		if (PlayerSaveDataPoints.PlayerMetThanatos == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarThanatos;
		}

		if (PlayerSaveDataPoints.PlayerMetTheia == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarTheia;
		}

		if (PlayerSaveDataPoints.PlayerMetThemis == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarThemis;
		}

		if (PlayerSaveDataPoints.PlayerMetTriton == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarTriton;
		}

		if (PlayerSaveDataPoints.PlayerMetTyche == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarTyche;
		}

		if (PlayerSaveDataPoints.PlayerMetUranus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarUranus;
		}

		if (PlayerSaveDataPoints.PlayerMetZelus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarZelus;
		}

		if (PlayerSaveDataPoints.PlayerMetZeus == true) {
			PlayerSaveDataPoints.PlayerOverallGEJar = PlayerSaveDataPoints.PlayerOverallGEJar + PlayerSaveDataPoints.PlayerGEJarZeus;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}