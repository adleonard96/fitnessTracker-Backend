public class BodyPart {
    public int Id {get; set;}
    public string Name {get; set;}

    public BodyPart(string name, int id){
        Id = id;
        Name = name;
    }
}