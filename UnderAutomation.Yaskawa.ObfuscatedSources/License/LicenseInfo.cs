//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace License {

	public sealed class LicenseInfo {


		public LicenseInfo(string licenseIdentifier, string licenseKey)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// The license key supplied by UnderAutomation (null for trial period)
		/// </summary>
		public string LicenseKey { get; set; }

		/// <summary>
		/// Commercial name of this .NET Software library
		/// </summary>
		public string Product { get; set; }

		/// <summary>
		/// Remaining days of the trial period. Null if the product is licensed. It could be negative if the trial period is ended since several days.
		/// </summary>
		public int? EvaluationDaysLeft { get; set; }

		/// <summary>
		/// The date the trial period starts. If the product is licensed, the date of the library first use.
		/// </summary>
		public DateTime EvaluationStartDate { get; set; }

		/// <summary>
		/// Name of your organisation
		/// </summary>
		public string Licensee { get; set; }

		/// <summary>
		/// The date the product will expire. Null if the product is licensed.
		/// </summary>
		public DateTime? TrialPeriodExpirationDate { get; set; }


		public LicenseState State { get; }

		/// <summary>
		/// The date this version of the product was released.
		/// </summary>
		public DateTime ProductReleaseDate { get; set; }

		/// <summary>
		/// Number of maintenance years included in your license
		/// </summary>
		public int MaintenanceYears { get; set; }

		/// <summary>
		/// The date you get the license
		/// </summary>
		public DateTime? LicenseIssuedDate { get; set; }

		/// <summary>
		/// The date your maintenance contract ends, and you no longer can use this license with newer versions.
		/// </summary>
		public DateTime? MaintenanceExpirationDate { get; set; }
	}
}
