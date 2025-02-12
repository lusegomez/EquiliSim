# EquiliSim

EquiliSim is a simulation interface designed to visualize sensor data in real time using Unity3D. It allows the representation of an IMU (Inertial Measurement Unit) sensor's pitch and roll angles through a 3D model.

## Features
- **Real-time data visualization**: The simulation updates according to the IMU sensor's pitch and roll values.
- **Unity3D Integration**: Uses Unity for 3D rendering and animation.
- **Serial Communication**: Communicates with a microcontroller via a serial port.
- **Custom 3D Model**: Integrates a model from Mixamo to represent movements dynamically.

## Hardware
- **Microcontroller**: ESP8266
- **IMU Sensor**: MPU6050

## Installation

### Prerequisites
- Unity3D installed ([Download Unity](https://unity.com/))
- ESP8266 microcontroller with an MPU6050 IMU sensor
- ArduinoIDE or another method for handling serial communication (optional)

### Setup
```bash
# Clone this repository
git clone https://github.com/yourusername/equiliSim.git
cd equiliSim
```

1. Open the Unity project in Unity3D.
2. Connect the ESP8266 microcontroller via USB.
3. Modify the serial port settings in the script to match your device:

```csharp
using System.IO.Ports;
SerialPort serialPort = new SerialPort("COM3", 115200);
```

4. Run the Unity simulation to visualize sensor data in real time.

## Usage
1. Start the Unity simulation.
2. Ensure the ESP8266 microcontroller is properly sending data from the MPU6050.
3. Observe the 3D model adjusting its orientation based on IMU readings.

## Contributions
Contributions are welcome! Feel free to submit pull requests or open issues for improvements.

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.

## References
- [Unity3D Documentation](https://docs.unity3d.com/)
- [Mixamo 3D Models](https://www.mixamo.com/)

## Contact
For any inquiries, please contact lugomez@itba.edu.ar or sburgos@itba.edu.ar.


