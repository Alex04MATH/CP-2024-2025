using System.ComponentModel;

public class Set
{
    private List<int> set = new List<int>();
    private int cardinal;
    public List<int> GetSet { get => set; }
    public Set(IEnumerable<int> set)
    {
        this.set = CreateSet(set.ToList());
        cardinal = this.set.Count;
    }
    // public Set(params int[] set)
    // {
    //     this.set = CreateSet(set.ToList());
    //     cardinal = this.set.Count;
    // }
    private static List<int> CreateSet(List<int> set)
    {
        int count = 0;
        List<int> newSet = new List<int>();
        bool existe = false;
        while (count < set.Count)
        {
            if (count == 0)
            {
                newSet.Add(set[count]);
                count++;
                continue;
            }
            for (int i = 0; i < newSet.Count; i++)
            {
                if (set[count] == newSet[i])
                {
                    existe = true;
                    break;
                }
            }
            if (existe == false) newSet.Add(set[count]);

            existe = false;
            count++;
        }
        return newSet;
    }
    public void Add(int a)
    {
        if(set.Contains(a)) return;
        set.Add(a); 
    }
    public void Remove(int a)
    {
        set.Remove(a);
    }
    public bool Contains(int a)
    {
        return set.Contains(a);
    }
    public void Clear()
    {
        set=new List<int>();
    }
    public static Set Intersection(Set set1,Set set2)
    {
        List<int> intersection=new List<int>();
        bool cardinal=set1.cardinal>=set2.cardinal?true:false;
        int val=0;
        if(cardinal) val=set1.cardinal;
        else val=set2.cardinal;
        for(int i=0;i<val;i++)
        {
            if(cardinal && set2.Contains(set1.set[i])) intersection.Add(set1.set[i]);
            if(!cardinal && set1.Contains(set2.set[i])) intersection.Add(set2.set[i]);
        }
        return new Set(intersection);
    }
}