using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu]
public class audioLineEntry : ScriptableObject
{
    // scriptable object qui sert à construire le discours à la radio et peut aussi servir si on a besoin d'autres sous titres (téléphone, parole ...)
    public string lineTxt;
    public float lineTime;
    public bool lineIsHint;
    //on pourra tjrs rajouter un audio aussi
}
