namespace Nurse_Backend.Entities.Patients;

public class PatientRecord
{
    public Guid RecordId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime Date { get; set; }
    public string Diagnosis { get; set; } = string.Empty;
    public string Symptom { get; set; } = string.Empty;
    public string Treatment { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}