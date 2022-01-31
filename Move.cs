using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Move : MonoBehaviour
{

    public Transform _target; // в инспекторе задаём объект движения
    public float moveSpeed = 0.1f; // скорость движения объекта
    public float verticalSpeed = 0.05f; // скорость подъема объекта (Space/Ctrl)
 
    // Use this for initialization
    void Start()
    {
    }
 
    // Update is called once per frame
    void Update()
    {
        // здесь блок перемещения объекта WSAD + Space/Ctrl
        // не забыть в инпуте назначить Ctrl на отрицательную ось Jump'а !!!
        float forwardMove = Input.GetAxis("Vertical") * moveSpeed;
        float sideMove = Input.GetAxis("Horizontal") * moveSpeed;
        float verticalMove = Input.GetAxis("Jump") * verticalSpeed;
        _target.position += _target.forward * forwardMove + 
                            _target.right * sideMove + 
                            _target.up * verticalMove;
    }
}