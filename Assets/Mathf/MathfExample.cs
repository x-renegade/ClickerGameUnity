using UnityEngine;

public class MathfExample : MonoBehaviour {
    private void Const() {
        var infinity = Mathf.Infinity;
        var negativeInfinity = Mathf.NegativeInfinity;
        var pi = Mathf.PI;
    }

    private void Method() {
        var abs = Mathf.Abs(-100); //������ � Input ��� ���������� ������ ������������ �������.
        var ceil = Mathf.Ceil(10.2f); // ���������� �� ������ ��������.
        var floor = Mathf.Floor(10.8f); // ���������� �� ��������.
        var rount = Mathf.Round(10.8f); // ���������� �� ��������.
        //ToInt(); ������ ����.
        var clamp = Mathf.Clamp(abs, 0, 1); //������������ � ������ ���������.
    }
}
