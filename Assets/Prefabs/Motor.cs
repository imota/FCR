using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

    public enum InputType {wasd, arrows};
    public enum MotorSide { right, left };

    public Transform parent;

    public InputType input_type;
    public MotorSide motor_side;

    private float input = 0f;
    private float power = 0;
    private Timer timer = new Timer();

    private string getButton(InputType type, MotorSide side) {
        string axis;
        axis = (type == InputType.wasd) ? "wasd" : "arrows";

        return axis.Insert(axis.Length, "Vertical");
    }

	void Update () {
        input = Input.GetAxis(getButton(input_type, motor_side));
        if (input < 0) input = -1;
        if (input > 0) input = 1;
        power = power + input/10;

        float th = parent.rotation.z - Mathf.PI/2;
        //Debug.LogError("Th = " + th);
        GetComponent<Rigidbody2D>().velocity = new Vector2(power*Mathf.Cos(th),power * Mathf.Sin(th));
	}
}
