namespace Reto2G5.Model
{
    public class eMailModel
    {
            public string recipient { get; set; }
            public string msgBody { get; set; }
            public string subject { get; set; }

        public eMailModel() { }
        public eMailModel(string recipient, string msgBody, string subject) 
        { 
            this.recipient = recipient;
            this.msgBody = msgBody;
            this.subject = subject;
        }
    }
}
