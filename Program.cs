namespace Challenge2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFile = "C:\\MSSA-CCAD14\\sample.txt";
            string myDestination = "C:\\MSSA-CCAD14\\test\\sample.txt";
            Console.WriteLine("Here is the content of " + myFile);
            using (StreamReader sr = new StreamReader(myFile))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            try
            {
                File.Copy(myFile, myDestination, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("File transfer succesfful to " + myDestination);

            Console.WriteLine("Here is the content of " + myDestination);
            using (StreamReader sr = new StreamReader(myDestination))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
