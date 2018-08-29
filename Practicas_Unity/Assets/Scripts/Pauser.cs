using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour {
	private bool paused = false;
    public GameObject pausePanel;
   // public AudioSource audioSource;
    public GameObject audioSource;
    bool soundToggle = true;



    // Update is called once per frame
   
    void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{
			paused = !paused;
            pausePanel.SetActive(value: paused);
		}

		if(paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
        
    }
    public void ContinueGame()
    {
        Debug.Log("Continuar");
        paused = false;
        pausePanel.SetActive(value: paused);
    }
    public void ResetGame()
    {
        Debug.Log("Reset");
        SceneManager.LoadScene(0);

    }
    public void MuteMusic()
    {
        soundToggle = !soundToggle;
        if (soundToggle)
        {
            audioSource.SetActive(true);          
        }
        else
        {
            audioSource.SetActive(false);          
        }
        Debug.Log("Mute");
    }
}
