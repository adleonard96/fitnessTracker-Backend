public class Set {
    public int Id {get; set;}
    public Exercise Exercise {get; set;}
    public int? Weight {get; set;}
    public bool IsBodyWeight {get; set;}
    public DateTime StartTime {get; set;}
    public DateTime? EndTime {get; set;}

    Set(int id, Exercise exercise){
        Id = id;
        Exercise = exercise;
        StartTime = DateTime.Now;
        IsBodyWeight = true;
    }
    Set(int id, Exercise exercise, DateTime startTime){
        Id = id;
        Exercise = exercise;
        StartTime = startTime;
        IsBodyWeight = true;
    }
}