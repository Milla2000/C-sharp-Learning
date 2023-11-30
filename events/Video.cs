namespace events
{
    public class Video
    {
        public event EventHandler<VideoEvent> Videopublished;
        public void PublishVideo()
        {
            Console.WriteLine("Publishing..");

            //invoked

            Thread.Sleep(3000);

            OnVideoPublished("Introduction to C# Events and Delegates");

        }

         protected virtual void OnVideoPublished(string videoName) 
        { 
            //are there subscribers 
            if(Videopublished != null)
            {
                //there are subscribers 
                //let's notify them
                var data = new Data() { Title = videoName };

                Videopublished(this, new VideoEvent() {data=data});

            }
        }
    }
}
