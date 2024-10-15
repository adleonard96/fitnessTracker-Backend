class Workout {
    public int? Id {get; set;}

    private DateTime start;
    public DateTime Start 
    {
        get {return start;}
    }
    private DateTime? stop;
    public DateTime? Stop;

    public void StartWorkout() 
    {
        start = new DateTime();
    }

    public void StopWorkout()
    {
        stop = new DateTime();
    }
    public List<Set> Sets {get; set;}
    public User User {get; set;}

    public Workout(User user){
        User = user;
        Sets = [];
        StartWorkout();
    }
}