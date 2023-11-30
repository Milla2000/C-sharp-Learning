namespace events
{
    public class SMSMessage
    {

        public void OnVideoPublished(object source, VideoEvent eventArgs)
        {   
            //SMS sending Logic
            Console.WriteLine("Sending SMS..." + eventArgs.data.Title +" published ");
        }
    }
}
