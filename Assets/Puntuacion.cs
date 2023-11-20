using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puntuacion : MonoBehaviour
{
    public int puntuacion;
    public TMP_Text puntuaciontexto;
    public int vidas;
    public TMP_Text vidastexto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuaciontexto.text = puntuacion.ToString();
        vidastexto.text = vidas.ToString();
    }
}
