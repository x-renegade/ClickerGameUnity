using System.Collections;
using UnityEngine;

public class SinCos : MonoBehaviour {
    //[SerializeField] private float _frequency = 1;
    //[SerializeField] private float _amplitude = 15;
    //[SerializeField] private float _upOffset = 0.6f;
    [SerializeField] private LerpExample_1 transform;

    //private IEnumerator Start() {
    //    float time = 0;
    //    while (time < 10) {
    //        time += Time.deltaTime;
    //        transform.position = new Vector3(transform.position.x, Mathf.Sin(time) + 1, transform.position.z);
    //        yield return null;
    //    }
    //}




    void Update() {
        //transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time) + 1, transform.position.z);
        //Vector3 name = new Vector3(1, 1, 1);
        //transform.localScale = Vector3.one * (Mathf.Sin(Time.time) + 5);

        //transform.localScale = Vector3.one * (Mathf.Sin(Time.time * _frequency * 2 * Mathf.PI) * _amplitude + _upOffset);
    }
}

//https://matematikam.ru/calculate-online/grafik.php