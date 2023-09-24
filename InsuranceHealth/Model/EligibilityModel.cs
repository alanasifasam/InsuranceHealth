namespace InsuranceHealth.Model
{
    [Serializable]
    public class EligibilityModel
    {
        public Guid Id { get; set; }
        public string Pet { get; set; }
        public int NumeroPlano { get; set; }
    }
}
