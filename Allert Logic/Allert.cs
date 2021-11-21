namespace Allert_Logic
{
    public class Allert
    {
        public bool ?State { get; set; }
        public string ?Name { get; set; }
        public string ?Pair { get; set; }
        public DateTime InitTime { get; set; }

        public Allert(string name, String pair)
        {
            State = false;
            Pair = "";
            Name = name;
            InitTime = DateTime.Now; 
        }


        public override string ToString() => " Name: " + Name + " Pair" + Pair +  " State: " + State + " creation Date " + InitTime;

    }
}