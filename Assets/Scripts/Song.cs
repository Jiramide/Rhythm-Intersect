using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// The <c>Song</c> ScriptableObject.
/// This class contains all metadata concerning songs and charts including
/// BPM, crotchet, song length, etc.
/// </summary>
[CreateAssetMenu(menuName = "Song", fileName = "New Song")]
public class Song : ScriptableObject
{

  [Header("Song Data")]
  public string songName = "New Song";
  public float bpm;
  public float offset;
  public Sprite songVisual;

  [Header("Song Audio")]
  public AudioClip audio;
  [Range(0f, 5f)]
  [Tooltip("How much the volume of the song is scaled during gameplay. This is useful for altering the volume of loud or quiet songs to make them nicer to listen to.")]
  public float volumeModifier = 1f;
  public float pitch = 1f;

}
