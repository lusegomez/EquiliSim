using System.IO.Ports;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller : MonoBehaviour
{
    public string portName = "COM4"; 
    public int baudRate = 115200; 

    private const int DATA_LENGTH = 2;
    enum DataIndex
    {
        RollSpeed,
        PitchSpeed,
        YawSpeed,
        LinearAcceleration
    }

    SerialPort serialPort;

    void Start()
    {
        
        serialPort = new SerialPort(portName, baudRate);

        serialPort.Open();

    }

    void Update()
    {
        if (serialPort.IsOpen){
            string data = serialPort.ReadExisting();
            string[] values = data.Split(',');
            Debug.Log(data);
            if (values.Length >= DATA_LENGTH)
            {
                float rollSpeed = float.Parse(values[(int)DataIndex.RollSpeed]);
                float pitchSpeed = float.Parse(values[(int)DataIndex.PitchSpeed]);

                transform.Rotate(Vector3.forward, rollSpeed * Time.deltaTime);
                transform.Rotate(Vector3.right, pitchSpeed * Time.deltaTime);
            }
        }
        
    }

    void OnApplicationQuit()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close();
        }
    }
}
