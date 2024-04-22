namespace Task3
{
    internal class Patient
    {
        public string patientName {  get; set; }
        public int urgency { get; set; }

        public Patient(string patientName, int urgency)
        {
            this.patientName = patientName;
            this.urgency = urgency;
        }
    }
}
