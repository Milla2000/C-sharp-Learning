namespace ExceptionHandling
{
    public  class Twitter
    {

        public static void GetTweets(string username)
        {
            /// call twitter API 
            /// passing a username
            /// getting the tweets 
            /// an error occured 
            try
            {
                throw new Exception("An error occured");
            }catch (Exception ex)
            {
                throw new TwitterException(" Username Does not exist", ex);
            }
        }
    }
}
