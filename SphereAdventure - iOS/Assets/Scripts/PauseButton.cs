using UnityEngine;
using UnityEngine.UI;  
    
	
public class PauseButton : MonoBehaviour {
	
	
	public float SkinNumber;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;
	
	public GameObject ScoreDisplay;
	public GameObject PauseMenu;
	public GameObject PButton;
	public GameObject Map;
	
	public float Skinnumber;
	
	public bool toggleBool = false;
	
	public float GameSpeed;
	
    void Start() {
		
		Skinnumber = PlayerPrefs.GetFloat("SkinSelected");
		
		PauseMenu.SetActive(false);
		
        GetComponent<Button>().onClick.AddListener(TogglePause);
    }
	
        public void TogglePause() {      
			
			toggleBool = !toggleBool;
			
			Map.SetActive(!toggleBool);
			
			
		if(Skinnumber == 1)
		{
			Player1.SetActive(!toggleBool);
		}	
		if(Skinnumber == 2)
		{
			Player2.SetActive(!toggleBool);
		}
		if(Skinnumber == 3)
		{
			Player3.SetActive(!toggleBool);
		}			
			
			PauseMenu.SetActive(toggleBool);
			ScoreDisplay.SetActive(!toggleBool);		
			
    }
	
		void Update ()
		{
			GameSpeed = PlayerPrefs.GetFloat("GameSpeed");
		}	
}