using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    static class BasicCalculation
    {
        // Fields
        private static int region;
        private static int squareFeet;
        private static string insulation;
        private static string sunExposure;
        private static string sealTightness;
        private static int numOccupants;
        private static int numAppliances;
        private static string kitchen;
        private static string username;
        private static double btuNeed;
        private static double btuRecommended;
        private static bool dbWriteComplete;

        // Properties
        // From Step One
        public static int Region { get { return region; } set { region = value; } }

        // From Step Two
        public static int SquareFeet { get { return squareFeet; } set { squareFeet = value; } }
        public static string Insulation { get { return insulation; } set { insulation = value; } }
        public static string SunExposure { get { return sunExposure; } set { sunExposure = value; } }
        public static string SealTightness { get { return sealTightness; } set { sealTightness = value; } }
        public static int NumOccupants { get { return numOccupants; } set { numOccupants = value; } }
        public static int NumAppliances { get { return numAppliances; } set { numAppliances = value; } }
        public static string Kitchen { get { return kitchen; } set { kitchen = value; } }
        public static string Username { get { return username; } set { username = value; } }

        // From Step Three
        public static double BTUNeed { get { return btuNeed; } set { btuNeed = value; } }
        public static double BTURecommended { get { return btuRecommended; } set { btuRecommended = value; } }

        // Method To Perform Calculation
        public static double PerformCalculation()
        {
            // Step Two
            btuNeed = (squareFeet / 600) * 6000;
            switch (region)
            {
                case 1:
                    btuNeed += btuNeed * .02;
                    break;
                case 2:
                    btuNeed += btuNeed * .05;
                    break;
                case 3:
                    btuNeed += btuNeed * .07;
                    break;
                case 4:
                    btuNeed += btuNeed * .10;
                    break;
            }

            switch (insulation)
            {
                case "Extremely Well Insulated":
                    btuNeed -= btuNeed * 0.1;
                    break;
                case "Above Average Insulation":
                    btuNeed -= btuNeed * 0.05;
                    break;
                case "Below Average Insulation":
                    btuNeed += btuNeed * 0.05;
                    break;
                case "Poor Insulation":
                    btuNeed += btuNeed * 0.1;
                    break;
            }

            switch (sunExposure)
            {
                case "Heavy Sun Exposure":
                    btuNeed += btuNeed * 0.1;
                    break;
                case "Heavy Shade Exposure":
                    btuNeed -= btuNeed * 0.1;
                    break;
            }

            switch (sealTightness)
            {
                case "Single Pane, Not Perfectly Sealed":
                    btuNeed += btuNeed * 0.1;
                    break;
                case "Double Pane, Well Sealed":
                    btuNeed -= btuNeed * 0.1;
                    break;
            }

            // Step three
            btuNeed += numOccupants * 300;
            btuNeed += numAppliances * 300;

            // Step four
            if (kitchen == "Yes")
            {
                btuNeed += 1000;
            }

            Math.Round(btuNeed, 0);

            // Step five
            btuRecommended = Math.Round((btuNeed / 12000), 0) + .5;

            // Return size needed
            return btuRecommended;
        }

        // Method To Save Data to Database
        public static bool SaveToDatabase()
        {
            // Initially set completion tracker to true
            dbWriteComplete = true;

            // Use SQL connection to connect to database
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                // Try to complete save, else catch error and change completion tracker to false
                try
                {
                    // Open connection
                    connection.Open();

                    // Get DateTime object
                    DateTime date = DateTime.Now;

                    // Create SQL command
                    SqlCommand command = new SqlCommand("dbo.InsertBasicCalc", connection);

                    // Declare command as SQL Stored Procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameters to SQL command
                    command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@region", SqlDbType.Int).Value = region;
                    command.Parameters.Add("@squareFeet", SqlDbType.Int).Value = squareFeet;
                    command.Parameters.Add("@insulation", SqlDbType.NVarChar).Value = insulation;
                    command.Parameters.Add("@sunExposure", SqlDbType.NVarChar).Value = sunExposure;
                    command.Parameters.Add("@tightness", SqlDbType.NVarChar).Value = sealTightness;
                    command.Parameters.Add("@numOccupants", SqlDbType.Int).Value = numOccupants;
                    command.Parameters.Add("@numAppliances", SqlDbType.Int).Value = numAppliances;
                    command.Parameters.Add("@kitchen", SqlDbType.NVarChar).Value = kitchen;
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                    command.Parameters.Add("@btuNeeded", SqlDbType.Int).Value = btuNeed;
                    command.Parameters.Add("@btuRecommended", SqlDbType.Int).Value = btuRecommended;

                    // Execute command
                    command.ExecuteNonQuery();

                    // Close connection
                    connection.Close();
                }
                catch (Exception)
                {
                    dbWriteComplete = false;
                }
            }

            // Return whether database write was completed or not
            if (dbWriteComplete)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
