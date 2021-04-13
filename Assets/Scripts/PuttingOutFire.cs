using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingOutFire : MonoBehaviour
{
    [SerializeField] GameObject fire;
    [SerializeField] GameObject fireExtinguisher;
    [SerializeField] GameObject alarmaEvacuacion;

    private AudioSource ExtinguisherAudio;
    private AudioSource audioAlarmaEvacuacion;

    private void Awake()
    {
        ExtinguisherAudio = fireExtinguisher.GetComponent<AudioSource>();
        audioAlarmaEvacuacion = alarmaEvacuacion.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ExtinguisherAudio.Play();
            Invoke("OutFire", 4.0f);
            Invoke("AlarmaEvacuacion", 8.0f);
        }
    }

    private void OutFire()
    {
        fire.SetActive(false);
        ExtinguisherAudio.Stop();
    }
    private void AlarmaEvacuacion()
    {
        Debug.Log("Se invoco la funcion");
        audioAlarmaEvacuacion.Stop();
    }
}
