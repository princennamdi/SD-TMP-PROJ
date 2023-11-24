namespace ncs1
{
    public class Methods


    {



        public static string timez(long timestamp)
        {
            long unixTimestamp = timestamp;

            // Create a DateTime object from the Unix timestamp
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).DateTime;

            // Format the DateTime object as a string in the desired format
            string formattedDateTime = dateTime.ToString("h:mm tt dd/MM/yyyy");



            return formattedDateTime;
        }

    }
}
