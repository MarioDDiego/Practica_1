using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{

	//numeros enteros exclusivamente
	int contar;
	//numeros decimales, para darles un valor hay que poner al final una f
	float decimales = 0.1f;
	//un interruptor de verdaderos y falsos
	bool bolleana;

	public Text puntuacion;
	public Button soyBoton;

	private void Awake()
	{
		//Se ejecuta en el primer frame cuando le das a play
	}

	// Start is called before the first frame update
	void Start()
    {
		contar = 3;
		Debug.Log("hola mundo");
		Debug.Log(contar);
		puntuacion.text = "puntuación es: " + contar;
		bolleana = true;
	}

    // Update is called once per frame
    void Update()
    {
        //mover hacia delante
        transform.Translate(Vector3.forward * Time.deltaTime * 30);
		contar = 5;
		if (contar == 5)
		{
			bolleana = true;
		}
	}

	private void LateUpdate()
	{
		//Se ejecuta en el último frame
	}

	private void FixedUpdate()
	{
		//Aquí se ponen las físicas
	}

	void MiMetodo()
	{
		bolleana = true;
		int contar2;
		contar2 = 4;

		
	}
}
