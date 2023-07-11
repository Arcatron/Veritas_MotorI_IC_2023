using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repaso : MonoBehaviour
{

    //Primera Unidad

    //Variables
    int _numeros;
    float _decimales;
    bool _banderas;
    public string _palabras;
    char _caracters;

    //Tipos de Acceso
    public int numeroPublico;
    private int _numeroPrivado;
    protected int _numeroProtegido;

    //Serializacion y Rangos
    [SerializeField] private int _numeroSerializado;
    [Range(-10, 10)] [SerializeField] private int _numeroRango;

    //Segunda Unidad
    //Referenciacion
    [SerializeField] private SpriteRenderer _sprite;

    //Cuarta Unidad
    //Los arreglos son estructuras estaticas por lo que no se puede modificar su tamaño en ejecucion del juego.
    [SerializeField] private SpriteRenderer[] _spriteArreglo;

    //Las listas son estructuras dinamicas por lo que se puede modificar su tamaño en ejecucion del juego.
    [SerializeField] private List<SpriteRenderer> _spriteLista = new List<SpriteRenderer>();

    private GameObject[] objects;


    //Tercera Unidad
    //Awake ejectua el codigo una unica vez antes que este se instancie en la escena.
    private void Awake()
    {
        //GetComponent sirve para buscar un componente en el Inspector de un Objeto en el Editor de Unity
        //y asignarselo a una varible o verifica si este componente existe.
        _sprite = GetComponent<SpriteRenderer>();

        //FindObjectOfType sirve para buscar un componente en algun lado del Editor, si este no existe, retorna null
        //Toma al objeto más nuevo en la escena con ese script
        _sprite = FindObjectOfType<SpriteRenderer>();

        //FindGameObjectWithTag nor sirve para buscar un OBJETO en algun lugar del Editor
        //que tenga la etiqueta que andamos buscando, si este no existe, retornar null.
        _sprite = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();

        //FindOjectsOfType sirve para buscar todos los objetos en el juego que tenga el componente a buscar y retorna
        //un arreglo lleno con todos los componentes encontrados.
        _spriteArreglo = FindObjectsOfType<SpriteRenderer>();

        //FindGameObjectsOfType sirve para buscar todos los objetos en el juego que tengan la misma etiqueta que se este
        //buscando y retorna un arreglo lleno con toros los componentes encontrados.
        objects = GameObject.FindGameObjectsWithTag("Player");
    }

    //Start se ejecuta en el primer frame de juego
    private void Start()
    {
        //El if es una estructura de decision que nos permite revisar una condicion,
        //si esta se cumple, ejecuta su bloque de codigo encerrado entre { }
        //si  esta no se cumple, ejectua un else if o un else si este lo contiene.
        if (_numeroRango > 0)
        {
            Debug.Log("El numero es mayor a cero");
        }
        else if (_numeroRango < 0)
        {
            Debug.Log("El numero es menor a cero");
        }
        else 
        {
            Debug.Log("El numero es igual a cero");
        }

        //El switch es una estructura de decision que nor permite revisar una variable primitiva
        //y verificar el dato dentro de esta, si existe en la lista casos ese dato, entonces ejecutara su codigo
        //sino, revisara si tiene un caso por defecto y ejecutara su codigo, sino lo tiene, no pasa nada.
        switch (_palabras)
        {
            case "gato":
                Debug.Log("La palabra es Gato");
                break;
            case "perro":
                Debug.Log("La palabra es Perro");
                break;
            default:
                Debug.Log("Escriba gato o perro");
                break;
        }

        //Un for me permite ejecutar un codigo una cantidad finita de veces mientras que su contador incrementa
        //o decrementa y la condicion se llegue a cumplir.
        for (int i = 0; i < 10; i++) 
        {
            Debug.Log("Hola Mundo: " + i);
        }

        for (int i = 0; i < _spriteArreglo.Length; i++) 
        {
            _spriteArreglo[i].color = Color.red;
        }

        //Un while me permite ejecutar un codigo infinitamente mientras que su condicion se cumpla, cuando la condicion
        //deja de cumplirse se rompe el ciclo.
        while (numeroPublico > 0) 
        {
            Debug.Log("Ciclo: " + numeroPublico);
            if (numeroPublico > 50) 
            { 
                break;
            }
            numeroPublico++;
        }


        //Un foreach me permite recorrer una lista no por la cantidad de objetos en la lista sino por sus componentes
        //y permite guardarlos en una variable temportal que puedo modificar y manipular.
        foreach (SpriteRenderer sprite in _spriteLista) 
        {
            sprite.color += Color.blue;
        }
    }

    //Update se ejecuta cada vez que pasa un frame de juego
    //y no dejara de repertise hasta que se cierre el juego o se desactive.
    private void Update()
    {

    }

}
