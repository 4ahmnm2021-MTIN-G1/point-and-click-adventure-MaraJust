using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
   // Klasse   -> Bauplan
   //Klasse    -> Jäger

   // Variablen sind ein Container -> Werte oder Referenzen
   // Variable die Werte speichern

   //public             -> access modifier
   // string            -> Type of variable
   // nameOfCharacter   -> identifier (name of variable)
   // ;                 -> end of Statement
   public string nameOfCharacter; // Deklaration einer Variable   (Instanzvariable)
   public int ageOfCharacter;    //                               (Instanzvariable)
   public float sizeOfCharacter; //                               (Instanzvariable)
   public bool isWearingGlasses;

   // Referenztyp Variablen (Verweis)
   public GameObject newGameObject;
   public BoxCollider bc;
   public SpriteRenderer sr;

   public Hunter buddy;

   //public    -> access modifier
   // void     -> return type (wird ein wert zurückgegeben)
   // Start    -> Name der Funktion
   // ()       -> Parameterliste (in diesem Fall leer)
   // {}       -> Scope / Wirkungsbereich (Was alles Teil der Funktion ist)
  
   // Deklaration einer Funktion
   public void Start ()
   {
      buddy.isWearingGlasses = false;
      // Hier wird etwas ausgeführt
   }

   public void ZweiteFunktion () 
   {
      // Hier wird etwas ausgeführt
   }


   // Objekte -> Instanze einer Klasse
   // Objekt -> MEIN Jäger
}
