using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public enum Fade{ In, Out };

public class Splash : MonoBehaviour {
	public float fadeTime = 1.0f ;
	public int nextScene ;


	// Use this for initialization
	void Start () {
		StartCoroutine ("coroutine");
	}

	IEnumerator coroutine(){
		transform.GetComponent<RawImage>().color = new Vector4( 1.0f, 1.0f, 1.0f, 0.0f );
		
		yield return new WaitForSeconds(0.2f);

		yield return StartCoroutine (FadeGUITexture(fadeTime, Fade.In));

		yield return new WaitForSeconds(0.8f);

		//yield return StartCoroutine (FadeGUITexture(fadeTime, Fade.Out));

		//yield return new WaitForSeconds(0.1f);
		
		SceneManager.LoadScene("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	IEnumerator FadeGUITexture (float timer, Fade fadeType) {
		
		float start = 0 ;
		float end = 0 ;

		if ( fadeType == Fade.In ){
			start = 0.0f ;
			end = 1.2f ;
		}else if ( fadeType == Fade.Out ){
			start = 1.0f ;
			end = 0.0f ;
		}

		float i = 0.0f;
		
		float step = 1.0f/timer;
		
		while (i < 1.0) {
			
			i += step * Time.deltaTime;

			// Debug.Log( i );

			float a = Mathf.Lerp(start, end, i)*.5f;
			// Debug.Log( a );
			transform.GetComponent<RawImage>().color = new Vector4( 1.0f, 1.0f, 1.0f, a );

			yield return new WaitForEndOfFrame();
			
		}
	}
}

