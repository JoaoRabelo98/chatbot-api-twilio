namespace ApiTwilio.Models
{
  public class RequestTwilio
  {
    public string SmsMessageSid { get; set; }
    public string NumMedia {get;set;}
    public string SmsSid{get;set;}
    public string SmsStatus{get;set;}
    public string Body{get;set;}
    public string To{get;set;}
    public string NumSegments{get;set;}
    public string MessageSid{get;set;}
    public string AccountSid{get;set;}
    public string ApiVersion{get;set;}
  }
}