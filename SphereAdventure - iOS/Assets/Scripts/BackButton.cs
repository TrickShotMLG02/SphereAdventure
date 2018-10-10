using UnityEngine;
using UnityEngine.UI;  
    
	
public class BackButton : MonoBehaviour {
	
	
	public GameObject PauseMenu;
	public GameObject SettingsMenu;
	public GameObject PauseMenuToDisable;
	public GameObject SettingsMenuToDisable;
	public GameObject Button;
	public GameObject Button2;
	
	public bool toggleBool = false;
	public bool toggleBool2 = false;
	
	
    void Start() {
		
		//PauseMenu.SetActive(false);
		
        
    }
        public void TogglePause1() {      
			
			toggleBool = !toggleBool;
			SettingsMenu.SetActive(toggleBool);
			
			PauseMenuToDisable.SetActive(!toggleBool);
			
			toggleBool = !toggleBool;
    }
	
	
	 public void TogglePause2() {      
			
			toggleBool2 = !toggleBool2;
			Debug.Log("Pausemenu" + toggleBool2);
			PauseMenu.SetActive(toggleBool2);
			
			Debug.Log("Settingsmenu" + !toggleBool2);
			SettingsMenuToDisable.SetActive(!toggleBool2);
			
			toggleBool2 = false;
    }
	
		void Update ()
		{
			Button.GetComponent<Button>().onClick.AddListener(TogglePause1);
			Button2.GetComponent<Button>().onClick.AddListener(TogglePause2);
		}	
}