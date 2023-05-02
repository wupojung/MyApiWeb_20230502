namespace MyApi.Services;

public class RpgService
{
    private static IList<Rpg> database;

    static RpgService()
    {
        database = new List<Rpg>();
        database.Add(new Rpg() { id = 0, name = "boss", lv = 999 });
        database.Add(new Rpg() { id = 1, name = "史萊姆", lv = 1 });
        database.Add(new Rpg() { id = 2, name = "骷顱", lv = 2 });
        database.Add(new Rpg() { id = 3, name = "A", lv = 3 });
        database.Add(new Rpg() { id = 4, name = "B", lv = 4 });
        database.Add(new Rpg() { id = 5, name = "C", lv = 5 });
        database.Add(new Rpg() { id = 6, name = "D", lv = 6 });
    }
    
    
    public List<Rpg> List()
    {
        List<Rpg>  result = null;

        var db = from d in database
            select d;

        if (db.Any())
        {
            result = db.ToList();
        }
        
        return result;
    }
    
    
    //GET/READ 
    public Rpg Get(int id)
    {
        Rpg result = null;

        var db = from d in database
            where d.id == id
            select d;

        if (db.Any())
        {
            result = db.First();
        }
        
        return result;
    }
    
    
    //POST/CREATE  新增
    public Rpg Create(Rpg rpg)
    {
        //Rpg result = null;

        rpg.id = database.Max(x=>x.id)+1;  //修正id 
        
        database.Add(rpg);
        
        return rpg;
    }
    
}