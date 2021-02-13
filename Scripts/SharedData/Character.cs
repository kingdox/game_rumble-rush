﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Aquí se posee toda la información
/// referente a los Characters de cada uno.
/// </summary>
/// 
public class CharacterData
{
    [HideInInspector]
    public static CharacterData cD = new CharacterData();

    public readonly CharacterType[] characters =
    {
        CharacterType.Monk,
        CharacterType.Paladin,
        CharacterType.Hunter,
        CharacterType.Brutus,
    };

    public readonly TKey[] charKeys =
    {
        TKey.CHAR_Monk,
        TKey.CHAR_Paladin,
        TKey.CHAR_Hunter,
        TKey.CHAR_Brutus
    };
    public readonly TKey[] powKeys =
    {

        TKey.POW_Monk,
        TKey.POW_Paladin,
        TKey.POW_Hunter,
        TKey.POW_Brutus
    };
    //-> velocidad de los objetos que vendrán (min 10, )
    public readonly float[] speed = { 9, 13, 15, 20 };
    //-> vida del personaje  (min 10)
    public readonly float[] energy = { 18, 30, 20, 25 };
    //-> fuerza del salto (min 10)
    public readonly float[] jump = { 8, 10, 12, 9 };
    //-> Cooldown de la habilidad
    public readonly float[] cooldown = { 15.0f, 20.0f, 10.0f, 15.0f};
    //-> Costo para usarlo
    public readonly int[] cost = { 0, 300, 250, 150};

    // -> duración para que pueda ser usado otra vez el ataque
    public readonly float[] weaponCooldown = { 4.0f, 6.0f, 4.5f, 4.75f };

}

/// <summary>
/// Modelo con los parametros del personaje y  adición de sus datos.
/// </summary>
[System.Serializable]
public struct Character
{
    public CharacterType type;
    public TKey keyName;
    public TKey keyPower;


    public float speed;
    public float energy;
    public float jump;
    public float cooldown;
    public int cost;

    /// <summary>
    /// Establece el tipo que posee el personaje
    /// basado en los tipos de personajes que hay,
    /// carga al tipo en caso de que no se le indique un indice
    /// </summary>
    public void SetType(int index = -1)
    {
        int i = index == -1 ? (int)type : index;
        type = CharacterData.cD.characters[i];
        keyName = CharacterData.cD.charKeys[i];
        speed = CharacterData.cD.speed[i];
        energy = CharacterData.cD.energy[i];
        jump = CharacterData.cD.jump[i];
        cooldown = CharacterData.cD.cooldown[i];
        cost = CharacterData.cD.cost[i];
        keyPower = CharacterData.cD.powKeys[i];
    }
}

/// <summary>
/// Enumeramos los tipos de personajes
/// Con el indice tomaremos la información correspondiente
/// </summary>
public enum CharacterType
{
    Monk,
    Paladin,
    Hunter,
    Brutus
}