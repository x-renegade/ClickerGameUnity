using UnityEngine;

public class MathfExample : MonoBehaviour {
    private void Const() {
        var infinity = Mathf.Infinity;
        var negativeInfinity = Mathf.NegativeInfinity;
        var pi = Mathf.PI;
    }

    private void Method() {
        var abs = Mathf.Abs(-100); //Пример с Input или положением одного относительно другого.
        var ceil = Mathf.Ceil(10.2f); // Округление до целого большего.
        var floor = Mathf.Floor(10.8f); // Округленеи до меньшего.
        var rount = Mathf.Round(10.8f); // Округленеи до ближнего.
        //ToInt(); Вернут инты.
        var clamp = Mathf.Clamp(abs, 0, 1); //Ограничивает в нужном диапозоне.
    }
}
