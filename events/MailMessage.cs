
namespace events
{
    public class MailMessage
    {

        public void OnVideoPublished(object source, VideoEvent eventArgs)
        {
            //SMS sending Logic
            Console.WriteLine("Sending Email..." + eventArgs.data.Title + " published ");
        }
    }
}
