class DataBase
{
    List<Department> dep_table;
    List<Worker> worker_table;

    public DataBase()
    {
        dep_table = new();
        worker_table = new List<Worker>();
    }

    public void append_worker(Worker worker)
    {
        worker_table.Add(worker);
    }

    public void append_dep(Department department)
    {
        dep_table.Add(department);
    }

    public string select_all_dep()
    {
        string output = string.Empty;

        foreach (var item in dep_table)
        {
            output += $"{item.title}\n";
        }
        
        return output;
    }
}