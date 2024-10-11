public class Equipment {
    public int Id {get; set;}
    public string Name {get; set;}

    public Equipment(string name, int id){
        Id = id;
        Name = name;
    }
}