using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour 
{
    public Color color;
    public Color defd;
    public GameObject infoPanel;
    private bool isPlayerInside = false;
    public float rotationSpeed = 3f;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        

        if(Input.GetKeyDown(KeyCode.L) && isPlayerInside)
        {
            Debug.Log("El jugador recogio la pelota");
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("El jugador entro 1");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Se encontro jugador");
            gameObject.GetComponent<Renderer>().material.color = color;
            infoPanel.SetActive(true);
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("El jugador salio");
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
            isPlayerInside = false;
            gameObject.GetComponent<Renderer>().material.color = defd;

        }
    }
}
