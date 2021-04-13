using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingOutFire : MonoBehaviour
{
    [SerializeField] float fireRate;
    [SerializeField] GameObject fire;
    [SerializeField] GameObject Flamethrower;
    [SerializeField] GameObject alarmaEvacuacion;

    
    private float nextFire;
    //private AudioSource ExtinguisherAudio;
    private AudioSource audioAlarmaEvacuacion;

    private void Awake()
    {
        audioAlarmaEvacuacion = alarmaEvacuacion.GetComponent<AudioSource>();
        nextFire = 0f;
    }
    
    private void OutFire()
    {
        fire.SetActive(false);
        //ExtinguisherAudio.Stop();
    }
    private void AlarmaEvacuacion()
    {
        Debug.Log("Se invoco la funcion");
        audioAlarmaEvacuacion.Stop();
    }

    void Update()
    {
        if (Input.GetButton("FireExtinguisher") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;            //Controla el delay de disparo.
            Flamethrower.SetActive(true);

            Invoke("OutFire", 21f);
            Invoke("AlarmaEvacuacion", 25f);
        }
    }
}
