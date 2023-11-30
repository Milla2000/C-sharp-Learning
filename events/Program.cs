using events;

Video video = new Video();//publisher
SMSMessage sms = new SMSMessage();//subscriber
MailMessage mail = new MailMessage();//subscriber


video.Videopublished += sms.OnVideoPublished;
video.Videopublished += mail.OnVideoPublished;

video.PublishVideo();

