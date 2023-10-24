using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [SerializeField]private int powerBaseFrappe = 10;
    [SerializeField]private int multiplicateur = 1;
    [SerializeField]private int gold = 100;//changer en float ou double?
    [SerializeField]private int lvEnclume=1;
    [SerializeField]private int lvTenaille = 1;
    [SerializeField]private int lvMarteaux = 1;
    [SerializeField]private int autoClick = 0;
    [SerializeField]private int chaleur = 100;//A mettre possiblement dans un autre script
    [SerializeField]private static int nbMateriaux = 100;//Je comprend pas pourquoi static est nécéssaire ici
    [SerializeField]private int[] materiauxDispo = new int[nbMateriaux];// A Remplacer peut etre par une liste

    void Start()
    {

    }

    void Update()
    {

    }
}
