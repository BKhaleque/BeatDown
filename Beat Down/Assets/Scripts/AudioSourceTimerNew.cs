using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceTimerNew : MonoBehaviour

{
    AudioSource audioSource;
    private List<float> timings;
    private List<float>.Enumerator iterator;
    private float current;
    private bool moreNotes = true;
    public GameObject myPrefab, myPrefab2, myPrefab3, myPrefab4;
    public float fallTime;
    private int noteLane;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        noteLane = 1;
        timings = new List<float>() { 4.690431f - fallTime, 4.94585f - fallTime, 5.10839f - fallTime, 6.965986f - fallTime, 7.291066f - fallTime, 7.616145f - fallTime, 7.918005f - fallTime, 8.196644f - fallTime,
                                     8.521724f - fallTime, 8.800363f - fallTime, 9.079002f - fallTime, 9.287982f - fallTime, 9.659501f - fallTime, 11.49388f - fallTime, 11.84218f - fallTime, 13.69977f - fallTime, 13.97841f - fallTime, 14.14095f - fallTime,
                                     16.02177f - fallTime, 16.37007f - fallTime, 16.69515f - fallTime, 16.95057f - fallTime, 17.27565f - fallTime, 17.57751f - fallTime, 17.83293f - fallTime, 18.11156f - fallTime, 18.36698f - fallTime, 20.73542f - fallTime,
                                     20.99084f - fallTime, 21.26948f - fallTime, 21.57134f - fallTime, 21.8732f - fallTime, 22.15184f - fallTime, 22.40726f - fallTime, 22.70912f - fallTime, 22.98775f - fallTime, 23.26639f - fallTime, 23.52181f - fallTime,
                                     23.80045f - fallTime, 24.07909f - fallTime, 24.35773f - fallTime, 24.68281f - fallTime, 24.96145f - fallTime, 25.26331f - fallTime, 25.54195f - fallTime, 25.84381f - fallTime, 26.14567f - fallTime, 26.42431f - fallTime,
                                     26.70295f - fallTime, 27.00481f - fallTime, 27.28345f - fallTime, 27.58531f - fallTime, 27.88717f - fallTime, 28.16581f - fallTime, 28.44444f - fallTime, 28.72308f - fallTime, 29.02494f - fallTime, 29.3268f - fallTime,
                                     29.58222f - fallTime, 29.86086f - fallTime, 30.1395f - fallTime, 30.44136f - fallTime, 30.72f - fallTime, 30.99864f - fallTime, 31.27728f - fallTime, 31.57914f - fallTime, 31.85778f - fallTime, 32.13642f - fallTime,
                                     32.41506f - fallTime, 32.71692f - fallTime, 32.99556f - fallTime, 33.2742f - fallTime, 33.57605f - fallTime, 33.87791f - fallTime, 34.15656f - fallTime, 34.43519f - fallTime, 34.73705f - fallTime, 35.01569f - fallTime,
                                     35.29433f - fallTime, 35.59619f - fallTime, 35.87483f - fallTime, 36.17669f - fallTime, 36.47855f - fallTime, 36.75719f - fallTime, 37.05905f - fallTime, 37.36091f - fallTime, 37.63955f - fallTime, 37.96463f - fallTime,
                                     38.24327f - fallTime, 38.5219f - fallTime, 38.80054f - fallTime, 39.1024f - fallTime, 39.38104f - fallTime, 39.65968f - fallTime, 39.96154f - fallTime, 40.24018f - fallTime, 40.54204f - fallTime, 40.8439f - fallTime,
                                     41.09932f - fallTime, 41.40118f - fallTime, 41.70304f - fallTime, 42.0049f - fallTime, 42.30676f - fallTime, 42.5854f - fallTime, 42.86404f - fallTime, 43.1659f - fallTime, 43.44453f - fallTime, 43.7464f - fallTime,
                                     44.02504f - fallTime, 44.32689f - fallTime, 44.58231f - fallTime, 44.86095f - fallTime, 45.13959f - fallTime, 45.44145f - fallTime, 45.69687f - fallTime, 45.99873f - fallTime, 46.27737f - fallTime, 46.55601f - fallTime,
                                     46.85787f - fallTime, 47.13651f - fallTime, 47.43837f - fallTime, 47.71701f - fallTime, 48.04209f - fallTime, 48.32072f - fallTime, 48.59937f - fallTime, 48.87801f - fallTime, 49.15664f - fallTime, 49.43528f - fallTime,
                                     49.71392f - fallTime, 50.01578f - fallTime, 50.31764f - fallTime, 50.59628f - fallTime, 50.89814f - fallTime, 51.17678f - fallTime, 51.47864f - fallTime, 51.7805f - fallTime, 52.05914f - fallTime, 52.33778f - fallTime,
                                     52.63964f - fallTime, 52.91828f - fallTime, 53.19691f - fallTime, 53.47556f - fallTime, 53.77742f - fallTime, 54.05605f - fallTime, 54.33469f - fallTime, 54.59011f - fallTime, 54.86875f - fallTime, 55.17061f - fallTime,
                                     55.47247f - fallTime, 55.75111f - fallTime, 56.02975f - fallTime, 56.28517f - fallTime, 56.61025f - fallTime, 56.91211f - fallTime, 57.19075f - fallTime, 57.49261f - fallTime, 59.6985f - fallTime, 60.0468f - fallTime,
                                     61.9044f - fallTime, 62.27592f - fallTime, 64.20318f - fallTime, 64.59792f - fallTime, 64.89977f - fallTime, 65.20163f - fallTime, 65.4f - fallTime, 66.61805f - fallTime, 66.87347f - fallTime, 67.15211f - fallTime,
                                     67.40753f - fallTime, 67.68616f - fallTime, 67.96481f - fallTime, 68.26667f - fallTime, 68.5453f - fallTime, 68.82394f - fallTime, 69.12581f - fallTime, 69.40444f - fallTime, 69.68308f - fallTime, 69.96172f - fallTime,
                                     70.24036f - fallTime, 70.54222f - fallTime, 70.84408f - fallTime, 71.14594f - fallTime, 71.42458f - fallTime, 71.70322f - fallTime, 71.98186f - fallTime, 72.2605f - fallTime, 72.56236f - fallTime, 72.86422f - fallTime,
                                     73.16608f - fallTime, 73.44472f - fallTime, 73.70013f - fallTime, 74.002f - fallTime, 74.28063f - fallTime, 74.55927f - fallTime, 74.83791f - fallTime, 75.13977f - fallTime, 75.41841f - fallTime, 75.72028f - fallTime,
                                     75.99891f - fallTime, 76.30077f - fallTime, 76.55619f - fallTime, 76.85805f - fallTime, 77.09025f - fallTime, 77.41533f - fallTime, 77.69397f - fallTime, 77.99583f - fallTime, 78.29768f - fallTime, 78.59955f - fallTime,
                                     78.90141f - fallTime, 79.18005f - fallTime, 79.4819f - fallTime, 79.76054f - fallTime, 80.03918f - fallTime, 80.34104f - fallTime, 80.61968f - fallTime, 80.92154f - fallTime, 81.2234f - fallTime, 81.47882f - fallTime,
                                     81.75746f - fallTime, 82.0361f - fallTime, 82.31474f - fallTime, 82.59338f - fallTime, 82.87202f - fallTime, 83.17387f - fallTime, 83.4293f - fallTime, 83.73116f - fallTime, 84.0098f - fallTime, 84.31165f - fallTime,
                                     84.59029f - fallTime, 84.91537f - fallTime, 85.19402f - fallTime, 85.49587f - fallTime, 85.79773f - fallTime, 86.09959f - fallTime, 86.40145f - fallTime, 86.68009f - fallTime, 86.98195f - fallTime, 87.28381f - fallTime,
                                     87.49279f - fallTime, 87.74821f - fallTime, 88.05007f - fallTime, 88.3287f - fallTime, 88.60735f - fallTime, 88.83955f - fallTime, 89.09496f - fallTime, 89.32716f - fallTime, 89.6058f - fallTime, 90.04698f - fallTime }; // lyrics enter at 20.0f, starting next verse/chorus at 66.0f
        iterator = timings.GetEnumerator();
        iterator.MoveNext();

    }

    void Update()
    {
        //LogTimes();
        Iterate();
    }


        void Iterate()
        {
          if (noteLane == 1 && moreNotes && audioSource.time >= iterator.Current) //removed - 0.01f also this doesn't work with ==
        {
          GameObject newNote = Instantiate(myPrefab,transform.position,Quaternion.identity);
          SpriteRenderer sr = myPrefab.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          noteLane = 2;
        }
          if (noteLane == 2 && moreNotes && audioSource.time >= iterator.Current) //removed - 0.01f also this doesn't work with ==
        {
          //GameObject newNote = Instantiate(myPrefab2,transform.position,Quaternion.identity);
          GameObject newNote = Instantiate(myPrefab2, new Vector3(-0.5f, 12.1f, -5.6f),Quaternion.identity);
          SpriteRenderer sr = myPrefab2.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          noteLane  = 3;
        }
          if (noteLane == 3 && moreNotes && audioSource.time >= iterator.Current) //removed - 0.01f also this doesn't work with ==
        {
          GameObject newNote = Instantiate(myPrefab3,new Vector3(1f, 12.1f, -5.6f),Quaternion.identity);
          SpriteRenderer sr = myPrefab3.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          noteLane = 4;
        }
          if (noteLane == 4 && moreNotes && audioSource.time >= iterator.Current) //removed - 0.01f also this doesn't work with ==
        {
          GameObject newNote = Instantiate(myPrefab4,new Vector3(2.55f, 12.1f, -5.6f),Quaternion.identity);
          SpriteRenderer sr = myPrefab4.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          noteLane = 1;
        }
      }

        void LogTimes()
        {
          if (Input.GetKeyDown(KeyCode.Return))
        {
          Debug.Log(audioSource.time);
        }
      }

  }
