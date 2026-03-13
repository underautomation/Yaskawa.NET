//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace HighSpeedEServer {
	/// <summary>
	/// Cartesian position result from a kinematics conversion.
	/// Provides named X/Y/Z and orientation properties in engineering units in addition to the raw axis values.
	/// </summary>
	public class RobotKinematicsCartesianData : RobotKinematicsPositionData {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the X position in millimetres (derived from the raw µm axis value).
		/// </summary>
		public double X { get; }

		/// <summary>
		/// Gets the Y position in millimetres.
		/// </summary>
		public double Y { get; }

		/// <summary>
		/// Gets the Z position in millimetres.
		/// </summary>
		public double Z { get; }

		/// <summary>
		/// Gets the Rx orientation in degrees (derived from the raw 0.0001° axis value).
		/// </summary>
		public double Rx { get; }

		/// <summary>
		/// Gets the Ry orientation in degrees.
		/// </summary>
		public double Ry { get; }

		/// <summary>
		/// Gets the Rz orientation in degrees.
		/// </summary>
		public double Rz { get; }
	}
}
