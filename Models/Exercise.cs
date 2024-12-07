namespace FitnessTracker.Models;

public class Exercise {
    public int Id {get; set;}
    public string Name {get; set;}
    public BodyPart BodyPart {get; set;}
    public Equipment? Equipment {get; set;}

    public Exercise(string name, BodyPart bodyPart){
        Name = name;
        BodyPart = bodyPart;
    }

    public Exercise(string name, BodyPart bodyPart, Equipment equipment){
        Name = name;
        BodyPart = bodyPart;
        Equipment = equipment;
    }
}