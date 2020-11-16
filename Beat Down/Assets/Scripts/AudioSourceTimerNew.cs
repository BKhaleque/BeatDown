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
        timings = new List<float>() { 4.690431f , 4.94585f , 5.10839f , 6.965986f , 7.291066f , 7.616145f , 7.918005f , 8.196644f  ,
                                     8.521724f  , 8.800363f  , 9.079002f  , 9.287982f  , 9.659501f  , 11.49388f  , 11.84218f  , 13.69977f  , 13.97841f  , 14.14095f  ,
                                     16.02177f  , 16.37007f  , 16.69515f  , 16.95057f  , 17.27565f  , 17.57751f  , 17.83293f  , 18.11156f  , 18.36698f  , 20.73542f  ,
                                     20.99084f  , 21.26948f  , 21.57134f  , 21.8732f  , 22.15184f  , 22.40726f  , 22.70912f  , 22.98775f  , 23.26639f  , 23.52181f  ,
                                     23.80045f  , 24.07909f  , 24.35773f  , 24.68281f  , 24.96145f  , 25.26331f  , 25.54195f  , 25.84381f  , 26.14567f  , 26.42431f  ,
                                     26.70295f  , 27.00481f  , 27.28345f  , 27.58531f  , 27.88717f  , 28.16581f  , 28.44444f  , 28.72308f  , 29.02494f  , 29.3268f  ,
                                     29.58222f  , 29.86086f  , 30.1395f  , 30.44136f  , 30.72f  , 30.99864f  , 31.27728f  , 31.57914f  , 31.85778f  , 32.13642f  ,
                                     32.41506f  , 32.71692f  , 32.99556f  , 33.2742f  , 33.57605f  , 33.87791f  , 34.15656f  , 34.43519f  , 34.73705f  , 35.01569f  ,
                                     35.29433f  , 35.59619f  , 35.87483f  , 36.17669f  , 36.47855f  , 36.75719f  , 37.05905f  , 37.36091f  , 37.63955f  , 37.96463f  ,
                                     38.24327f  , 38.5219f  , 38.80054f  , 39.1024f  , 39.38104f  , 39.65968f  , 39.96154f  , 40.24018f  , 40.54204f  , 40.8439f  ,
                                     41.09932f  , 41.40118f  , 41.9406f  , 42.5154f  , 43.21234f  , 43.76962f  , 44.35011f  , 44.93061f  , 45.51111f  , 46.04517f  ,
                                     46.60245f  , 47.18295f  , 47.76345f  , 48.36716f  , 48.94767f  , 49.52816f  , 50.10866f  , 50.6195f  , 51.22322f  , 51.82694f  ,
                                     52.40744f  , 52.98794f  , 53.54522f  , 54.12571f  , 54.65977f  , 55.24027f  , 55.82077f  , 56.35483f  , 56.95855f  , 57.39973f  ,
                                     57.72481f  , 59.6985f  , 60.0468f , 61.9044f  , 62.27592f  , 64.20318f  , 64.59792f  , 64.89977f  , 65.20163f  , 65.4f, 66.61805f,
                                     66.87347f  , 67.15211f  , 67.40753f  , 67.68616f  , 67.96481f , 68.26667f  , 68.5453f  , 68.82394f  , 69.12581f  , 69.40444f  ,
                                     69.68308f  , 69.96172f  , 70.24036f  , 70.54222f  , 70.84408f  , 71.14594f  , 71.42458f  , 71.70322f  , 71.98186f  , 72.2605f  ,
                                     72.56236f  , 72.86422f  , 73.16608f  , 73.44472f  , 73.70013f  , 74.002f  , 74.28063f  , 74.55927f  , 74.83791f  , 75.13977f  ,
                                     75.41841f  , 75.72028f  , 75.99891f  , 76.30077f  , 76.55619f  , 76.85805f  , 77.09025f  , 77.41533f  , 77.69397f  , 77.99583f,
                                     78.29768f  , 78.59955f  ,78.75141f  , 79.18005f  , 79.4819f  , 79.76054f  , 80.03918f  , 80.34104f  , 80.61968f  , 80.92154f  ,
                                     81.2234f  , 81.47882f  , 81.75746f  , 82.0361f  , 82.31474f  , 82.59338f  , 82.87202f  , 83.17387f  , 83.4293f  , 83.73116f  ,
                                     84.0098f  , 84.31165f  , 84.59029f  , 84.91537f  , 85.19402f  , 85.49587f  , 85.79773f  , 86.09959f  , 86.40145f  , 86.68009f  ,
                                     86.98195f  , 87.28381f  , 87.49279f  , 87.74821f  , 88.05007f  , 88.3287f  , 88.60735f  , 88.83955f  , 89.09496f  , 89.32716f  ,
                                     89.6058f  , 90.11665f  , 90.72036f  , 91.37052f  , 91.95102f  , 92.53152f  , 93.11201f  , 93.69252f  , 94.24979f  , 94.80708f  ,
                                     95.38757f  , 95.96807f  , 96.50213f  , 97.10585f  , 97.68635f  , 98.24363f  , 98.82413f  , 99.40462f  , 99.98512f  , 100.5656f  ,
                                     101.1461f  , 101.7266f  , 102.3536f  , 102.9341f  , 103.4681f  , 104.0254f  , 104.6059f  , 105.14f  , 105.7205f  , 108.0657f  ,
                                     110.3412f  , 112.64f  , 114.962f  , 117.2608f  , 119.5595f  , 121.8815f  , 124.2035f  , 126.4559f  , 128.7082f  , 131.0534f  ,
                                     133.4219f  , 133.9791f  , 134.5364f  , 135.1169f  , 135.7206f  , 136.2779f  , 136.8816f  , 137.4621f  , 138.0194f  , 138.5767f  ,
                                     139.1572f  , 139.7145f  , 140.3182f  , 140.8755f  , 141.4792f  , 142.0597f  , 142.5937f  , 143.1975f  , 143.778f  , 144.3585f  ,
                                     144.9622f  , 145.5427f  , 146.0767f  , 146.6108f  , 147.1449f  , 147.7486f  , 148.3291f  , 148.8864f  , 149.4901f  , 150.0706f  ,
                                     150.6511f  , 151.2316f  , 151.8121f  , 152.3926f  , 152.9731f  , 153.5536f  , 153.9947f  , 154.3895f  , 156.2935f  , 156.7347f  ,
                                     158.6155f  , 159.0103f  , 160.8678f  , 161.309f   }; // lyrics enter at 20.0f, starting next verse/chorus at 66.0f
        iterator = timings.GetEnumerator();
        iterator.MoveNext();

    }

    void Update()
    {
        LogTimes();
        Iterate();
    }


        void Iterate()
        {

          if (noteLane == 1 && moreNotes && audioSource.time >= iterator.Current - fallTime ) //-timings after iterator.Current
        {
          GameObject newNote = Instantiate(myPrefab,transform.position,Quaternion.identity);
          SpriteRenderer sr = myPrefab.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          //noteLane = 2;
          noteLane += Random.Range(0, 4);
        }

          if (noteLane == 2 && moreNotes && audioSource.time >= iterator.Current - fallTime ) //removed - 0.01f also this doesn't work with ==
        {
          //GameObject newNote = Instantiate(myPrefab2,transform.position,Quaternion.identity);
          GameObject newNote = Instantiate(myPrefab2, new Vector3(-0.5f, 12.1f, -5.6f),Quaternion.identity);
          SpriteRenderer sr = myPrefab2.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          //noteLane  = 3;
          noteLane += Random.Range(-1, 3);
        }

          if (noteLane == 3 && moreNotes && audioSource.time >= iterator.Current - fallTime ) //removed - 0.01f also this doesn't work with ==
        {
          GameObject newNote = Instantiate(myPrefab3,new Vector3(1f, 12.1f, -5.6f),Quaternion.identity);
          SpriteRenderer sr = myPrefab3.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          //noteLane = 4;
          noteLane += Random.Range(-2, 2);
        }

          if (noteLane == 4 && moreNotes && audioSource.time >= iterator.Current - fallTime ) //removed - 0.01f also this doesn't work with ==
        {
          GameObject newNote = Instantiate(myPrefab4,new Vector3(2.55f, 12.1f, -5.6f),Quaternion.identity);
          SpriteRenderer sr = myPrefab4.GetComponent<SpriteRenderer>();
          moreNotes = iterator.MoveNext();
          //noteLane = 1;
          noteLane += Random.Range(-3, 1);
        }
    }

        void LogTimes()
        {
          if (Input.GetKeyDown(KeyCode.Space))
        {
          Debug.Log(audioSource.time);
        }
      }

  }
